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
    }
}
