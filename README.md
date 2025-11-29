# Sales Management System (MdiLoginSystem)

Desktop system developed in C# (Windows Forms) for sales management, stock control, and cash flow. The project implements rigorous access control (RBAC) and complex business rules.

## Key Features

### Access Control and Security
- **Manager:** Access to management reports, administrative registrations (products, employees), and authorization of sensitive operations.
- **Salesperson:** Restricted access to sales processing and customer management.
- **Cashier:** Restricted access to payment processing and fine calculation.

### Sales and Stock Management
- Proactive **Low Stock** visual alert on the main menu.
- Automatic stock validation when adding items.
- Automatic calculation of totals and discounts.
- **Business Rule:** Discounts above 5% require Manager password.
- **Business Rule:** Automatic sales block for delinquent customers (with override via Manager password).

### Financial
- Sales installment plan up to 6x (with minimum installment validation).
- Automatic calculation of **late payment fine** (2% p.m.) upon receipt.

### Reports
- Sales by period.
- Salesperson commission.
- Customers (including delinquency filter).
- Critical stock.

## Default Testing Credentials

| Role | Email | Password |
| :--- | :--- | :--- |
| **Manager** | `admin@system.com` | `admin123` |
| **Salesperson** | `seller@system.com` | `seller123` |
| **Cashier** | `cashier@system.com` | `cashier123` |

## Developed by
Arthur Santos, Maria Luisa
IFNMG - Campus Montes Claros