using UserManagementSystem.Data;
using UserManagementSystem.Models;

public class SaleService
{
    private readonly Repository _context;

    public SaleService(Repository context)
    {
        _context = context;
    }

    public void ProcessSale(Purchase purchase, int installments)
    {
        using var transaction = _context.Database.BeginTransaction();
        try
        {
            // 1. Validate Stock
            foreach (var item in purchase.Items)
            {
                if (item.Product.StockQuantity < item.Quantity)
                    throw new Exception($"Insufficient stock for {item.Product.Name}");

                // Deduct Stock
                item.Product.StockQuantity -= item.Quantity;
            }

            // 2. Generate Payments
            for (int i = 1; i <= installments; i++)
            {
                purchase.Payments.Add(new Payment
                {
                    ExpirationDate = DateTime.Now.AddMonths(i),
                    Purchase = purchase
                });
            }

            // 3. Save
            _context.Purchases.Add(purchase);
            _context.SaveChanges();
            transaction.Commit();
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }
}