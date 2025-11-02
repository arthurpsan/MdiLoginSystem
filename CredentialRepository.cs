using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MdiLoginSystem
{
    public class CredentialRepository
    {
        public static void SaveorUpdate(Credential credential)
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

        public static Credential? FindById(Int64 id)
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
    }
}
