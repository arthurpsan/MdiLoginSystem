using System;
using System.Collections.Generic;
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
                    dbContext.Purchases.Remove(purchase);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Purchase? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Purchases.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Purchase> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Purchases.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Purchase> FindByDateRange(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Purchases
                        .Where(p => p.Implementation >= startDate && p.Implementation <= endDate)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Purchase> FindByDateRangeAndSeller(DateTime start,  DateTime end, UInt64 sellerId)
        {
            try
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
            catch (Exception)
            {
                throw;
            }
        }

        public static List <Purchase> FindByCustomerIdAndDate(UInt64 customerId, DateTime startDate)
        {
            try
            {
                DateTime endDate = DateTime.Now;

                using (Repository dbContext = new Repository())
                {
                    return dbContext.Purchases
                        .Include(p => p.Seller)
                        .Include(p => p.Items)
                        .Where(p => p.Customer != null && p.Customer.Id == customerId &&
                            p.Implementation >= startDate && p.Implementation <= endDate)
                        .OrderByDescending(p => p.Implementation)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
