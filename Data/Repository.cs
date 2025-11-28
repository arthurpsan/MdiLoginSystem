using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;

namespace UserManagementSystem.Data
{
    public class Repository : DbContext
    {
        // 1. Simple Static Configuration (No JSON needed)
        public const string ConnectionString = @"server=127.0.0.1;port=3308;uid=root;pwd=;database=StoreManagementSystem";

        // 2. DbSets (Fixed 'Itens' to 'Items')
        public DbSet<User> Users { get; set; }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Salesperson> Sellers { get; set; }
        public DbSet<Item> Items { get; set; } // Fixed typo
        public DbSet<Cashier> Cashiers { get; set; }

        public Repository()
        {
            // Optional: Uncomment to auto-create DB on startup if needed
            // Database.EnsureCreated(); 
        }

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

            // Configure Relationships
            modelBuilder.Entity<User>(user =>
            {
                user.HasOne(u => u.Credential)
                    .WithOne(c => c.User)
                    .HasForeignKey<Credential>(c => c.Id);
            });

            modelBuilder.Entity<Purchase>(purchase =>
            {
                purchase.HasMany(p => p.Payments)
                        .WithOne(pay => pay.Purchase); // Explicitly define both sides
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

            // Fixed typo reference here
            modelBuilder.Entity<Purchase>()
                .HasMany(p => p.Items)
                .WithOne(i => i.Purchase)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}