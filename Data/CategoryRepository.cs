using System;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class CategoryRepository
    {
        public static void SaveOrUpdate(Category category)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (category.Id == 0)
                    {
                        dbContext.Categories.Add(category);
                    }
                    else
                    {
                        dbContext.Entry(category).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(Category category)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Categories.Remove(category);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Category? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Categories.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Category> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Categories.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Category> FindByName(string name)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Categories
                        .Where(c => c.Name.Contains(name))
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
