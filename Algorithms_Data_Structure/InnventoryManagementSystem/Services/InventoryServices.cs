using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Services
{
    public class InventoryService
    {
        private Dictionary<int, Product> products = new();

        public void AddProduct(Product product)
        {
            products[product.ProductId] = product;
            Console.WriteLine("Product Added Successfully.");
        }

        public void UpdateProduct(int id, int quantity, decimal price)
        {
            if (products.ContainsKey(id))
            {
                products[id].Quantity = quantity;
                products[id].Price = price;
                Console.WriteLine("Product Updated.");
            }
            else
            {
                Console.WriteLine("Product Not Found.");
            }
        }

        public void DeleteProduct(int id)
        {
            if (products.Remove(id))
                Console.WriteLine("Product Deleted.");
            else
                Console.WriteLine("Product Not Found.");
        }

        public void DisplayProducts()
        {
            Console.WriteLine("\nInventory");

            foreach (var p in products.Values)
            {
                Console.WriteLine($"{p.ProductId}  {p.ProductName}  Qty:{p.Quantity}  Price:{p.Price}");
            }
        }
    }
}