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

        public static User? FindById(long id)
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

