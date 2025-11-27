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
                    // 1. attach existing entities
                    // attach seller
                    if (purchase.Seller != null && purchase.Seller.Id > 0)
                    {
                        dbContext.Attach(purchase.Seller);
                    }

                    // attach customer
                    if (purchase.Customer != null && purchase.Customer.Id > 0)
                    {
                        dbContext.Attach(purchase.Customer);
                    }

                    // attach products inside items
                    if (purchase.Items != null)
                    {
                        foreach (var item in purchase.Items)
                        {
                            // FIX: removed '?? 0' since Id is not nullable anymore
                            if (item.Product != null && item.Product.Id > 0)
                            {
                                dbContext.Attach(item.Product);

                                if (item.Product.Category != null)
                                {
                                    dbContext.Attach(item.Product.Category);
                                }
                            }
                        }
                    }

                    // 2. save the purchase
                    // FIX: removed '?? 0' check here too
                    if (purchase.Id == null || purchase.Id == 0)
                    {
                        dbContext.Purchases.Add(purchase);
                    }
                    else
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
    }
}