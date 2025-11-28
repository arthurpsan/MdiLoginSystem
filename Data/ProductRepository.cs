using System;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class ProductRepository
    {
        public static void SaveOrUpdate(Product product)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (product.Category != null && product.Category.Id > 0)
                    {
                        dbContext.Attach(product.Category);
                    }

                    if (product.Id == 0)
                    {
                        dbContext.Products.Add(product);
                    }
                    else
                    {
                        dbContext.Entry(product).State = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Product product)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    bool hasSales = dbContext.Items.Any(i => i.Product != null && i.Product.Id == product.Id);

                    if (hasSales)
                    {
                        dbContext.Attach(product);
                        product.IsActive = false;
                        dbContext.Entry(product).State = EntityState.Modified;

                        throw new InvalidOperationException("Product has sales history. It was marked as Inactive instead of deleted.");
                    }
                    else
                    {
                        dbContext.Products.Remove(product);
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Product? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Products.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Product? FindByName(String name)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Products.Find(name);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public static List<Product>? FindByPartialName(String partialName)
        {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Products
                        .Include(p => p.Category)
                        .Where(p => p.Name.ToLower().Contains(partialName.ToLower()))
                        .ToList();
                }
        }

        public static List<Product> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Products
                        .Include(p => p.Category)
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
