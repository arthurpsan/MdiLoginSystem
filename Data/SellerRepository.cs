using System;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class SellerRepository
    {
        public static void SaveOrUpdate(Salesperson seller)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (seller.Id == 0)
                    {
                        dbContext.Sellers.Add(seller);
                    }
                    else
                    {
                        dbContext.Entry(seller).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Salesperson seller)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Attach(seller);
                    dbContext.Sellers.Remove(seller);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Salesperson? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Sellers.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Salesperson? FindByName(String name)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Sellers.Find(name);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Salesperson? FindByEnrollment(UInt32 enrollment)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Sellers.Find(enrollment);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Salesperson> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Sellers.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
