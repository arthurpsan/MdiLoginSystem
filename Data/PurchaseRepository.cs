using System;
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
                                if (item.Product.Category != null)
                                    dbContext.Attach(item.Product.Category);
                            }
                        }
                    }

                    if (purchase.Id == 0)
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
                    .Include(p => p.Customer)
                    .Include(p => p.Items)
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
                    foreach (var item in purchase.Items)
                    {
                        if (item.Product != null)
                        {
                            var existingProduct = dbContext.Products.Local
                                .FirstOrDefault(p => p.Id == item.Product.Id);

                            if (existingProduct != null)
                            {
                                item.Product = existingProduct;
                            }
                            else
                            {
                                dbContext.Attach(item.Product);
                            }

                            item.Product.StockQuantity -= item.Quantity;
                            dbContext.Entry(item.Product).State = EntityState.Modified;
                        }
                    }

                    if (purchase.Seller != null)
                    {
                        var existingSeller = dbContext.Sellers.Local
                            .FirstOrDefault(s => s.Id == purchase.Seller.Id);

                        if (existingSeller != null) purchase.Seller = existingSeller;
                        else dbContext.Attach(purchase.Seller);
                    }

                    if (purchase.Customer != null)
                    {
                        var existingCustomer = dbContext.Customers.Local
                            .FirstOrDefault(c => c.Id == purchase.Customer.Id);

                        if (existingCustomer != null)
                        {
                            purchase.Customer = existingCustomer;
                        }
                        else
                        {
                            dbContext.Attach(purchase.Customer);
                        }
                    }

                    dbContext.Purchases.Add(purchase);
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