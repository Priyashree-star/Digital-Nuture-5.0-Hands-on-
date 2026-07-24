using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;

InventoryService inventory = new InventoryService();

Console.Write("Enter Product ID: ");
int id = int.Parse(Console.ReadLine()!);

Console.Write("Enter Product Name: ");
string name = Console.ReadLine()!;

Console.Write("Enter Quantity: ");
int qty = int.Parse(Console.ReadLine()!);

Console.Write("Enter Price: ");
decimal price = decimal.Parse(Console.ReadLine()!);

inventory.AddProduct(new Product
{
    ProductId = id,
    ProductName = name,
    Quantity = qty,
    Price = price
});

inventory.DisplayProducts();

Console.WriteLine("\nUpdate Product");

Console.Write("Enter New Quantity: ");
qty = int.Parse(Console.ReadLine()!);

Console.Write("Enter New Price: ");
price = decimal.Parse(Console.ReadLine()!);

inventory.UpdateProduct(id, qty, price);

inventory.DisplayProducts();

Console.WriteLine("\nDelete Product");

inventory.DeleteProduct(id);

inventory.DisplayProducts();