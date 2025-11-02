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

        // Method to verify and populate the database with a default admin user if no credentials exist.
        private static void VerifyDatabase()
        {
            using (Repository dbContext = new Repository())
            {
                if (!dbContext.Credentials.Any())
                {
                    // Create default admin.

                    // Creating the models.
                    User adminUser = new User
                    {
                        Name = "Administrator",
                        Nickname = "Admin",
                        PhoneNumber = 38998103030,
                        Email = "admin@system.com"
                    };

                    Credential adminCredential = new Credential
                    {
                        Email = "admin@system.com",
                        Password = "admin123", // This will be hashed in the setter
                        Manager = true,
                        User = adminUser
                    };

                    // Ask the Repository to save the new admin.
                    /* As the Credential has the reference to the User, 
                    MS Entity Framework (DbContext) should be able to save both models. */

                    CredentialRepository.SaveorUpdate(adminCredential);
                }
            }
        }
    }
}