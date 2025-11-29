using System;
using System.Collections.Generic;
using System.Linq; // Added for queries
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class PurchaseRepository
    {
        public static void SaveOrUpdate(Purchase purchase)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    // 1. Attach Existing Data (Crucial!)
                    if (purchase.Seller != null && purchase.Seller.Id > 0)
                        dbContext.Attach(purchase.Seller);

                    if (purchase.Customer != null && purchase.Customer.Id > 0)
                        dbContext.Attach(purchase.Customer);

                    if (purchase.Items != null)
                    {
                        foreach (var item in purchase.Items)
                        {
                            if (item.Product != null && item.Product.Id > 0)
                            {
                                dbContext.Attach(item.Product);
                                // If Category is loaded, attach it too to prevent duplicates
                                if (item.Product.Category != null)
                                    dbContext.Attach(item.Product.Category);
                            }
                        }
                    }

                    // 2. Save
                    if (purchase.Id == 0) // New
                    {
                        dbContext.Purchases.Add(purchase);
                    }
                    else // Update
                    {
                        dbContext.Entry(purchase).State = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Purchase purchase)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (purchase.Id == 0) return;

                    var dbPurchase = dbContext.Purchases.Find(purchase.Id);
                    if (dbPurchase != null)
                    {
                        dbContext.Purchases.Remove(dbPurchase);
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception) { throw; }
        }

        public static Purchase? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Purchases
                        .Include(p => p.Seller)
                        .Include(p => p.Customer)
                        .Include(p => p.Items)
                        .ThenInclude(i => i.Product)
                        .Include(p => p.Payments)
                        .FirstOrDefault(p => p.Id == id);
                }
            }
            catch (Exception) { throw; }
        }

        public static List<Purchase> FindAll()
        {
            using (Repository dbContext = new Repository())
            {
                return dbContext.Purchases.ToList();
            }
        }

        public static List<Purchase> FindByDateRange(DateTime startDate, DateTime endDate)
        {
            using (Repository dbContext = new Repository())
            {
                return dbContext.Purchases
                    .Include(p => p.Seller)
                    .Include(p => p.Customer) // Good to have
                    .Include(p => p.Items)    // FIX: Crucial! Needed for CalcTotal()
                    .Where(p => p.Implementation >= startDate && p.Implementation <= endDate)
                    .ToList();
            }
        }

        public static List<Purchase> FindByDateRangeAndSeller(DateTime start, DateTime end, UInt64 sellerId)
        {
            using (Repository dbContext = new Repository())
            {
                return dbContext.Purchases
                    .Include(p => p.Seller)
                    .Where(p => p.Implementation >= start && p.Implementation <= end &&
                        p.Seller != null && p.Seller.Id == sellerId)
                    .ToList();
            }
        }

        public static List<Purchase> FindByCustomerIdAndDate(UInt64 customerId, DateTime startDate)
        {
            try
            {
                DateTime endDate = DateTime.Now;
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Purchases
                        .Include(p => p.Seller)
                        .Include(p => p.Items)
                        .Include(p => p.Payments)
                        .Where(p => p.Customer != null && p.Customer.Id == customerId &&
                            p.Implementation >= startDate && p.Implementation <= endDate)
                        .OrderByDescending(p => p.Implementation)
                        .ToList();
                }
            }
            catch (Exception) { throw; }
        }

        public static void ProcessSaleTransaction(Purchase purchase)
        {
            using (Repository dbContext = new Repository())
            using (var transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    // 1. Safe Attach Products (Handles duplicate products in cart from different searches)
                    foreach (var item in purchase.Items)
                    {
                        if (item.Product != null)
                        {
                            // Check if this Product ID is already known to this Context
                            var existingProduct = dbContext.Products.Local
                                .FirstOrDefault(p => p.Id == item.Product.Id);

                            if (existingProduct != null)
                            {
                                // Use the existing tracker instead of the duplicate
                                item.Product = existingProduct;
                            }
                            else
                            {
                                // Not tracked yet, so attach it
                                dbContext.Attach(item.Product);
                            }

                            // Deduct stock (This logic works on whichever instance is active)
                            item.Product.StockQuantity -= item.Quantity;
                            dbContext.Entry(item.Product).State = EntityState.Modified;
                        }
                    }

                    // 2. Safe Attach Seller
                    if (purchase.Seller != null)
                    {
                        var existingSeller = dbContext.Sellers.Local
                            .FirstOrDefault(s => s.Id == purchase.Seller.Id);

                        if (existingSeller != null) purchase.Seller = existingSeller;
                        else dbContext.Attach(purchase.Seller);
                    }

                    // 3. Safe Attach Customer (Fixes your specific error)
                    if (purchase.Customer != null)
                    {
                        // Check if the Seller or Products dragged this Customer in already
                        var existingCustomer = dbContext.Customers.Local
                            .FirstOrDefault(c => c.Id == purchase.Customer.Id);

                        if (existingCustomer != null)
                        {
                            // If tracked, USE the tracked instance
                            purchase.Customer = existingCustomer;
                        }
                        else
                        {
                            // If not tracked, attach the one from the form
                            dbContext.Attach(purchase.Customer);
                        }
                    }

                    // 4. Add the Purchase
                    dbContext.Purchases.Add(purchase);

                    // 5. Save and Commit
                    dbContext.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

    }
}