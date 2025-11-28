using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class Repository : DbContext
    {
        // Centralized Connection String
        public const string ConnectionString = @"server=127.0.0.1;port=3306;uid=root;pwd=;database=StoreManagementSystem";

        public DbSet<User> Users { get; set; }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Salesperson> Sellers { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Cashier> Cashiers { get; set; }

        public Repository() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(user =>
            {
                user.HasOne(u => u.Credential)
                    .WithOne(c => c.User)
                    .HasForeignKey<Credential>(c => c.Id);
            });

            modelBuilder.Entity<Purchase>(purchase =>
            {
                purchase.HasMany(p => p.Payments);
            });

            modelBuilder.Entity<Payment>(payment =>
            {
                payment.HasOne(p => p.Purchase).WithMany(pu => pu.Payments);
            });

            modelBuilder.Entity<Cashier>(cashier =>
            {
                cashier.HasIndex(c => c.CashierEnrollment).IsUnique();
            });

            modelBuilder.Entity<Product>(product =>
            {
                product.HasOne(p => p.Category)
                .WithMany()
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Purchase>()
                .HasMany(p => p.Items)
                .WithOne(i => i.Purchase)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}