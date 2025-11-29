using System;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class CredentialRepository
    {
        public static void SaveOrUpdate(Credential credential)
        {
            using (Repository dbContext = new Repository())
            {
                if (credential.Id == 0)
                {
                    dbContext.Credentials.Add(credential);
                }
                else
                {
                    dbContext.Entry(credential).State = EntityState.Modified;
                }

                dbContext.SaveChanges();
            }
        }

        public static Credential? FindById(long id)
        {
            using (Repository dbContext = new Repository())
            {
                return dbContext.Credentials.Find(id);
            }
        }

        public static Credential? FindByEmail(string email)
        {
            using (Repository dbContext = new Repository())
            {
                return dbContext.Credentials
                    .Include(c => c.User)
                    .FirstOrDefault(c => c.Email == email);
            }
        }

        public static List<Credential> FindAll()
        {
            using (Repository dbContext = new Repository())
            {
                return dbContext.Credentials
                    .Include(c => c.User)
                    .ToList();
            }
        }

        public static bool ValidateManagerCredentials(string email, string password)
        {
            // Re-use existing method to avoid code duplication
            Credential? dbCredential = FindByEmail(email);

            if (dbCredential == null || !dbCredential.Manager)
            {
                return false;
            }

            string hashedInputPassword = Credential.ComputeSHA256(password, Credential.SALT);
            return dbCredential.Password == hashedInputPassword;
        }
    }
}