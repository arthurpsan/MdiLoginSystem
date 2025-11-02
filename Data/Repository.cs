using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class Repository : DbContext
    {
        private static readonly string _connectionsParams = @"server=127.0.0.1;port=3306;uid=root;pwd=;database=UserManagementSystem";

        public DbSet<User> Users { get; set; }
        public DbSet<Credential> Credentials { get; set; }

        public Repository() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_connectionsParams);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define the one-to-one relationship between User and Credential

            modelBuilder.Entity<User>(user =>
            {
                user.HasOne(u => u.Credential)
                    .WithOne(c => c.User)
                    .HasForeignKey<Credential>(c => c.Id);
            }
            );
        }
    }
}
