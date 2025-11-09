using System;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class SellerRepository
    {
        public static void SaveOrUpdate(Seller seller)
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
        public static Seller? FindById(UInt64 id)
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
        public static List<Seller> FindAll()
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
