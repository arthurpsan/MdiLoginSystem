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

            Application.Run(LoginScreen.GetInstance());
        }

        // Method to verify and populate the database default users if no credentials exist.
        private static void VerifyDatabase()
        {
            using (Repository dbContext = new Repository())
            {
                if (!dbContext.Credentials.Any())
                {
                    // Create default admin.
                    User adminUser = new User
                    {
                        Name = "Administrator",
                        Nickname = "Admin",
                        PhoneNumber = 38998103030,
                        Email = "admin@system.com"
                    };

                    Credential adminCredential = new Credential
                    {
                        Email = adminUser.Email,
                        Password = "admin123", // This will be hashed in the setter
                        Manager = true,
                        User = adminUser
                    };

                    // Ask the Repository to save the new admin.
                    /* As the Credential has the reference to the User, 
                    MS Entity Framework (DbContext) should be able to save both models. */
                    CredentialRepository.SaveOrUpdate(adminCredential);

                    // Create default customer user.
                    Customer customerUser = new Customer
                    {
                        Name = "Default Customer",
                        Email = "customer@system.com",
                        Purchases = new List<Purchase>()
                    };

                    // Ask the Repository to save the new customer.
                    CustomerRepository.SaveOrUpdate(customerUser);

                    // Create a default seller user.
                    User salespersonUser = new Salesperson
                    {
                        Name = "Default Seller",
                        Nickname = "Seller",
                        SalespersonEnrollment = 0,
                        PhoneNumber = 38997654321,
                        Email = "seller@system.com"
                    };

                    Credential sellerCredential = new Credential
                    {
                        Email = salespersonUser.Email,
                        Password = "seller123",
                        Manager = false,
                        User = salespersonUser
                    };

                    // Ask the Repository to save the new seller.
                    CredentialRepository.SaveOrUpdate(sellerCredential);

                    // Create a default cashier user.
                    User cashierUser = new Cashier
                    {
                        Name = "Default Cashier",
                        Nickname = "Cashier",
                        CashierEnrollment = 0,
                        PhoneNumber = 38993456789,
                        Email = "cashier@system.com"
                    };

                    Credential cashierCredential = new Credential
                    {
                        Email = cashierUser.Email,
                        Password = "cashier123",
                        Manager = false,
                        User = cashierUser
                    };

                    CredentialRepository.SaveOrUpdate(cashierCredential);
                }
            }
        }
    }
}