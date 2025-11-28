using System;
using System.Globalization;
using System.Windows.Forms;
using UserManagementSystem.Data;
using UserManagementSystem.Models;
// Adicione outros usings se necessário (ex: UserManagementSystem.Forms)

namespace UserManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // 1. Configuração de Cultura (Para R$ e datas)
            // Isso não cria janelas, então pode ficar no topo.
            CultureInfo culture = new CultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            // 2. Inicialização da Aplicação (CRÍTICO)
            // Esta linha configura o renderizador de texto.
            // NENHUMA janela (Form ou MessageBox) pode ser criada antes desta linha.
            ApplicationConfiguration.Initialize();

            // 3. Verificação do Banco de Dados
            // Agora é seguro chamar, pois se der erro e mostrar um MessageBox,
            // a aplicação já está inicializada.
            try
            {
                VerifyDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro crítico ao verificar banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 4. Iniciar o Login
            Application.Run(LoginForm.GetInstance());
        }

        private static void VerifyDatabase()
        {
            using (Repository dbContext = new Repository())
            {
                // Se o banco não existir ou não houver credenciais, cria os dados padrão
                if (dbContext.Database.EnsureCreated() || !dbContext.Credentials.Any())
                {
                    // 1. Create Users
                    var adminUser = new User { Name = "Administrator", Nickname = "Admin", PhoneNumber = 5538998103030, Email = "admin@system.com" };
                    CredentialRepository.SaveOrUpdate(new Credential { Email = adminUser.Email, Password = "admin123", Manager = true, User = adminUser });

                    var sellerUser = new Salesperson { Name = "John Seller", Nickname = "Seller", PhoneNumber = 5538997654321, Email = "seller@system.com", SellerEnrollment = 1001 };
                    CredentialRepository.SaveOrUpdate(new Credential { Email = sellerUser.Email, Password = "seller123", Manager = false, User = sellerUser });

                    var cashierUser = new Cashier { Name = "Karen Cashier", Nickname = "Cashier", PhoneNumber = 5538993456789, Email = "cashier@system.com", CashierEnrollment = 2001 };
                    CredentialRepository.SaveOrUpdate(new Credential { Email = cashierUser.Email, Password = "cashier123", Manager = false, User = cashierUser });

                    // 2. Create Products
                    var catElectronics = new Category { Name = "Electronics" };

                    var prodLaptop = new Product { Name = "Dell Laptop", Price = 3500.00m, StockQuantity = 10, MinimumStock = 2, Category = catElectronics, IsActive = true };
                    var prodMouse = new Product { Name = "Wireless Mouse", Price = 50.00m, StockQuantity = 2, MinimumStock = 5, Category = catElectronics, IsActive = true };

                    ProductRepository.SaveOrUpdate(prodLaptop);
                    ProductRepository.SaveOrUpdate(prodMouse);

                    // 3. Create History
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