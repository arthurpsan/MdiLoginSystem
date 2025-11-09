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
    }
}
