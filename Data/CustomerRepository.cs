using System;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class CustomerRepository
    {
        public static void SaveOrUpdate(Customer customer)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (customer.Id == 0)
                    {
                        dbContext.Customers.Add(customer);
                    }
                    else
                    {
                        dbContext.Entry(customer).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Customer customer)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Customers.Remove(customer);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Customer? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Customers.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Customer? FindByIdWithPurchases(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Customers
                        .Include(c => c.Purchases)
                        .ThenInclude(p => p.Payments)
                        .FirstOrDefault(c => c.Id == id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Customer> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Customers.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
