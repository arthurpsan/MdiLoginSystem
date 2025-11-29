using System;
using System.Globalization;
using UserManagementSystem.Data;
using UserManagementSystem.Models;

namespace UserManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            ApplicationConfiguration.Initialize();

            try
            {
                VerifyDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro crítico ao verificar banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Run(LoginForm.GetInstance());
        }

        private static void VerifyDatabase()
        {
            using (Repository dbContext = new Repository())
            {
                // seed the database if it is empty
                if (dbContext.Database.EnsureCreated() || !dbContext.Credentials.Any())
                {
                    // create Users
                    var adminUser = new User { Name = "Administrator", Nickname = "Admin", PhoneNumber = 5538998103030, Email = "admin@system.com" };
                    CredentialRepository.SaveOrUpdate(new Credential { Email = adminUser.Email, Password = "admin123", Manager = true, User = adminUser });

                    var sellerUser = new Salesperson { Name = "John Seller", Nickname = "Seller", PhoneNumber = 5538997654321, Email = "seller@system.com", SellerEnrollment = 1001 };
                    CredentialRepository.SaveOrUpdate(new Credential { Email = sellerUser.Email, Password = "seller123", Manager = false, User = sellerUser });

                    var cashierUser = new Cashier { Name = "Karen Cashier", Nickname = "Cashier", PhoneNumber = 5538993456789, Email = "cashier@system.com", CashierEnrollment = 2001 };
                    CredentialRepository.SaveOrUpdate(new Credential { Email = cashierUser.Email, Password = "cashier123", Manager = false, User = cashierUser });

                    // create Products
                    var catElectronics = new Category { Name = "Electronics" };

                    var prodLaptop = new Product { Name = "Dell Laptop", Price = 3500.00m, StockQuantity = 10, MinimumStock = 2, Category = catElectronics, IsActive = true };
                    var prodMouse = new Product { Name = "Wireless Mouse", Price = 50.00m, StockQuantity = 2, MinimumStock = 5, Category = catElectronics, IsActive = true };

                    ProductRepository.SaveOrUpdate(prodLaptop);
                    ProductRepository.SaveOrUpdate(prodMouse);

                    // create good purchase (Alice)
                    var goodCustomer = new Customer { Name = "Alice Reliable", Email = "alice@example.com" };
                    CustomerRepository.SaveOrUpdate(goodCustomer);

                    var goodPurchaseDate = DateTime.Now.AddDays(-20);
                    var goodPurchase = new Purchase
                    {
                        Customer = goodCustomer,
                        Seller = sellerUser,
                        State = State.FINISHED,
                        Beginning = goodPurchaseDate,
                        Implementation = goodPurchaseDate
                    };

                    // add Items
                    goodPurchase.Items.Add(new Item
                    {
                        Product = prodMouse,
                        Quantity = 2,
                        UnitPrice = prodMouse.Price,
                        Discount = 0,
                        Purchase = goodPurchase
                    });

                    // add Payment
                    var goodPayment = new Payment
                    {
                        ExpirationDate = goodPurchaseDate.AddDays(15),
                        PaymentFine = 0,
                        Purchase = goodPurchase,
                        DatePayment = goodPurchaseDate.AddDays(10),

                        Amount = 100.00m
                    };

                    using (var ctx = new Repository())
                    {
                        ctx.Attach(goodCustomer);
                        ctx.Attach(sellerUser);
                        ctx.Attach(prodMouse);

                        goodPurchase.Payments.Add(goodPayment);
                        ctx.Purchases.Add(goodPurchase);
                        ctx.SaveChanges();
                    }

                    // 4. create bad purchase (bob)
                    var badCustomer = new Customer { Name = "Bob Delinquent", Email = "bob@example.com" };
                    CustomerRepository.SaveOrUpdate(badCustomer);

                    var pastDate = DateTime.Now.AddDays(-40);
                    var badPurchase = new Purchase
                    {
                        Customer = badCustomer,
                        Seller = sellerUser,
                        State = State.FINISHED,
                        Beginning = pastDate,
                        Implementation = pastDate
                    };

                    // add items
                    badPurchase.Items.Add(new Item
                    {
                        Product = prodLaptop,
                        Quantity = 1,
                        UnitPrice = prodLaptop.Price,
                        Discount = 0,
                        Purchase = badPurchase
                    });

                    // add late payment
                    var badPayment = new Payment
                    {
                        ExpirationDate = pastDate.AddDays(30),
                        PaymentFine = 0,
                        Purchase = badPurchase,
                        DatePayment = null,

                        Amount = 3500.00m
                    };

                    using (var ctx = new Repository())
                    {
                        ctx.Attach(badCustomer);
                        ctx.Attach(sellerUser);
                        ctx.Attach(prodLaptop);

                        badPurchase.Payments.Add(badPayment);
                        ctx.Purchases.Add(badPurchase);
                        ctx.SaveChanges();
                    }
                }
            }
        }
    }
}