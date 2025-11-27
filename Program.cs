using System;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Verify and "populate" the Database on startup
            VerifyDatabase();

            Application.Run(LoginForm.GetInstance());
        }

        // Method to verify and populate the database default users if no credentials exist.
        private static void VerifyDatabase()
        {
            using (Repository dbContext = new Repository())
            {
                // OPTIONAL: Uncomment the next line if you want to WIPE the database clean for the video recording
                // dbContext.Database.EnsureDeleted(); 

                // Create the database if it doesn't exist
                if (dbContext.Database.EnsureCreated() || !dbContext.Credentials.Any())
                {
                    // --- 1. Create Users (Admin, Seller, Cashier) ---
                    var adminUser = new User { Name = "Administrator", Nickname = "Admin", PhoneNumber = 5538998103030, Email = "admin@system.com" };
                    CredentialRepository.SaveOrUpdate(new Credential { Email = adminUser.Email, Password = "admin123", Manager = true, User = adminUser });

                    var sellerUser = new Salesperson { Name = "John Seller", Nickname = "Seller", PhoneNumber = 5538997654321, Email = "seller@system.com", SellerEnrollment = 1001 };
                    CredentialRepository.SaveOrUpdate(new Credential { Email = sellerUser.Email, Password = "seller123", Manager = false, User = sellerUser });

                    var cashierUser = new Cashier { Name = "Karen Cashier", Nickname = "Cashier", PhoneNumber = 5538993456789, Email = "cashier@system.com", CashierEnrollment = 2001 };
                    CredentialRepository.SaveOrUpdate(new Credential { Email = cashierUser.Email, Password = "cashier123", Manager = false, User = cashierUser });

                    // --- 2. Create Categories & Products ---
                    var catElectronics = new Category { Name = "Electronics" };
                    var catOffice = new Category { Name = "Office" };

                    // Product 1: Normal Stock
                    var prodLaptop = new Product { Name = "Dell Laptop", Price = 3500.00m, Stockpile = 10, MinimumStock = 2, Category = catElectronics, IsActive = true };
                    // Product 2: LOW STOCK (For Report)
                    var prodMouse = new Product { Name = "Wireless Mouse", Price = 50.00m, Stockpile = 2, MinimumStock = 5, Category = catElectronics, IsActive = true };

                    ProductRepository.SaveOrUpdate(prodLaptop);
                    ProductRepository.SaveOrUpdate(prodMouse);

                    // --- 3. Create Customers ---

                    // Customer 1: Good Payer
                    var goodCustomer = new Customer { Name = "Alice Goodpayer", Email = "alice@example.com" };
                    CustomerRepository.SaveOrUpdate(goodCustomer);

                    // Customer 2: DELINQUENT (For Blocking Logic)
                    var badCustomer = new Customer { Name = "Bob Delinquent", Email = "bob@example.com" };
                    CustomerRepository.SaveOrUpdate(badCustomer);

                    // Create a PAST DUE purchase for the bad customer
                    var pastDate = DateTime.Now.AddDays(-40); // 40 days ago
                    var badPurchase = new Purchase
                    {
                        Customer = badCustomer,
                        Seller = sellerUser,
                        State = State.FINISHED,
                        Beggining = pastDate,
                        Implementation = pastDate
                    };

                    // Add a payment that expired 10 days ago
                    var badPayment = new Payment
                    {
                        ExpirationDate = pastDate.AddDays(30), // Expired 10 days ago
                        PaymentFine = 0,
                        Purchase = badPurchase,
                        DatePayment = null // Not paid!
                    };

                    // Save the bad purchase structure
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