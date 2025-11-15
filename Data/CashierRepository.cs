using System;
using UserManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace UserManagementSystem.Data
{
    public class CashierRepository
    {
        public static void SaveOrUpdate(Cashier cashier)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (cashier.Id == 0)
                    {
                        dbContext.Cashiers.Add(cashier);
                    }
                    else
                    {
                        dbContext.Entry(cashier).State = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Cashier cashier)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Attach(cashier);
                    dbContext.Cashiers.Remove(cashier);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Cashier> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Cashiers.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Cashier? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Cashiers.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Cashier> FindByPartialName(string partialName)
        {
            using (Repository dbContext = new Repository())
            {
                return dbContext.Cashiers
                    .Where(c => EF.Functions.Like(c.Name, $"%{partialName}%"))
                    .ToList();
            }
        }

    }
}
