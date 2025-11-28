using System;
using System.Collections.Generic;
using System.Linq; // Required for LINQ methods like Where and FirstOrDefault
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class UserRepository
    {
        public static void SaveOrUpdate(User user)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (user.Id == 0)
                    {
                        dbContext.Users.Add(user);
                    }
                    else
                    {
                        // If updating, attach and mark as modified
                        dbContext.Entry(user).State = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(User user)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    // Ensure the object is tracked by this specific context context before removing
                    dbContext.Attach(user);
                    dbContext.Users.Remove(user);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static User? FindById(UInt64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Users.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static User? FindByName(String name)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    // FIX: .Find() expects an ID. Use FirstOrDefault to search by Name.
                    return dbContext.Users.FirstOrDefault(u => u.Name == name);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<User> FindByPartialName(String partialName)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Users
                        .Where(u => EF.Functions.Like(u.Name, $"%{partialName}%"))
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<User> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Users.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}