using System;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class PaymentRepository
    {
        public static void SaveOrUpdate(Payment payment)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (payment.Id == 0)
                    {
                        dbContext.Payments.Add(payment);
                    }
                    else
                    {
                        dbContext.Entry(payment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Payment payment)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Payments.Remove(payment);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Payment? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Payments.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Payment> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Payments.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
