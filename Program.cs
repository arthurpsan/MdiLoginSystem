using System;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            VerifyDatabase();
            Application.Run(LoginForm.GetInstance());
        }

        private static void VerifyDatabase()
        {
            using (Repository dbContext = new Repository())
            {
                if (dbContext.Database.EnsureCreated() || !dbContext.Credentials.Any())
                {
                    // 1. Create Users
                    var adminUser = new User { Name = "Administrator", Nickname = "Admin", PhoneNumber = 5538998103030, Email = "admin@system.com" };
                    CredentialRepository.SaveOrUpdate(new Credential { Email = adminUser.Email, Password = "admin123", Manager = true, User = adminUser });

                    var sellerUser = new Salesperson { Name = "John Seller", Nickname = "Seller", PhoneNumber = 5538997654321, Email = "seller@system.com", SellerEnrollment = 1001 };
                    CredentialRepository.SaveOrUpdate(new Credential { Email = sellerUser.Email, Password = "seller123", Manager = false, User = sellerUser });

                    var cashierUser = new Cashier { Name = "Karen Cashier", Nickname = "Cashier", PhoneNumber = 5538993456789, Email = "cashier@system.com", CashierEnrollment = 2001 };
                    CredentialRepository.SaveOrUpdate(new Credential { Email = cashierUser.Email, Password = "cashier123", Manager = false, User = cashierUser });

                    // 2. Create Products (FIXED: Using StockQuantity)
                    var catElectronics = new Category { Name = "Electronics" };

                    var prodLaptop = new Product { Name = "Dell Laptop", Price = 3500.00m, StockQuantity = 10, MinimumStock = 2, Category = catElectronics, IsActive = true };
                    var prodMouse = new Product { Name = "Wireless Mouse", Price = 50.00m, StockQuantity = 2, MinimumStock = 5, Category = catElectronics, IsActive = true };

                    ProductRepository.SaveOrUpdate(prodLaptop);
                    ProductRepository.SaveOrUpdate(prodMouse);

                    // 3. Create History (FIXED: Using Beginning)
                    var badCustomer = new Customer { Name = "Bob Delinquent", Email = "bob@example.com" };
                    CustomerRepository.SaveOrUpdate(badCustomer);

                    var pastDate = DateTime.Now.AddDays(-40);
                    var badPurchase = new Purchase
                    {
                        Customer = badCustomer,
                        Seller = sellerUser,
                        State = State.FINISHED,
                        Beginning = pastDate, // Fixed
                        Implementation = pastDate
                    };

                    var badPayment = new Payment
                    {
                        ExpirationDate = pastDate.AddDays(30),
                        PaymentFine = 0,
                        Purchase = badPurchase,
                        DatePayment = null
                    };

                    using (var ctx = new Repository())
                    {
                        ctx.Attach(badCustomer);
                        ctx.Attach(sellerUser);
                        badPurchase.Payments.Add(badPayment);
                        ctx.Purchases.Add(badPurchase);
                        ctx.SaveChanges();
                    }
                }
            }
        }
    }
}