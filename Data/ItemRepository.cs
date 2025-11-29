using System;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class ItemRepository
    {
        public static List<Item> FindByPurchaseId(UInt64 purchaseId)
        {
            using (Repository dbContext = new Repository())
            {
                return dbContext.Items
                    .Include(i => i.Product)
                    .Where(i => i.Purchase != null && i.Purchase.Id == purchaseId)
                    .ToList();
            }
        }

        public static void Delete(Item item)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Items.Remove(item);
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
