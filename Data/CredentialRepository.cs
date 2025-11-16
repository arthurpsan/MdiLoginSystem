using System;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class CredentialRepository
    {
        public static void SaveOrUpdate(Credential credential)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (credential.Id == 0)
                    {
                        dbContext.Credentials.Add(credential);
                    }
                    else
                    {
                        dbContext.Entry(credential).State
                            = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Credential? FindById(long id)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Credentials.Find(id);

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Credential? FindByEmail(string email)
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Credentials
                        .Include(c => c.User)
                        .FirstOrDefault(c => c.Email == email);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Credential> FindAll()
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Credentials
                        .Include(c => c.User)
                        .ToList();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Boolean ValidateManagerCredentials(string email, string password)
        {
            try
            {
                Credential? dbCredential = FindByEmail(email);

                if (dbCredential == null)
                {
                    return false;
                }

                if (!dbCredential.Manager == false)
                {
                    return false;
                }

                string hashedInputPassword = Credential.ComputeSHA256(password, Credential.SALT);

                return dbCredential.Password == hashedInputPassword;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
