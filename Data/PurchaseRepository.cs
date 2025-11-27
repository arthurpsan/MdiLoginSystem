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
                    if (purchase.Id == null || purchase.Id == 0) return;

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
                    // 1. Attach and Update Stock for all products
                    foreach (var item in purchase.Items)
                    {
                        if (item.Product != null)
                        {
                            // Attach the product to this specific context to track changes
                            dbContext.Attach(item.Product);

                            // Deduct stock (ensure logic prevents negative stock before this)
                            item.Product.Stockpile -= item.Quantity;

                            // Mark as modified
                            dbContext.Entry(item.Product).State = EntityState.Modified;
                        }
                    }

                    // 2. Attach Relationships (Seller, Customer) to avoid duplication
                    if (purchase.Seller != null) dbContext.Attach(purchase.Seller);
                    if (purchase.Customer != null) dbContext.Attach(purchase.Customer);

                    // 3. Add the Purchase (Items and Payments will be added by cascade)
                    dbContext.Purchases.Add(purchase);

                    // 4. Save and Commit
                    dbContext.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw; // Re-throw to handle UI error message
                }
            }
        }

    }
}