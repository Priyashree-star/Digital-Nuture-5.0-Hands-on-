using EcommerceSearch.Models;
using EcommerceSearch.Services;

Product[] products =
{
    new Product{ProductId=101, ProductName="Keyboard", Category="Electronics"},
    new Product{ProductId=102, ProductName="Laptop", Category="Electronics"},
    new Product{ProductId=103, ProductName="Mouse", Category="Electronics"},
    new Product{ProductId=104, ProductName="Phone", Category="Mobiles"},
    new Product{ProductId=105, ProductName="Speaker", Category="Audio"}
};

// Required for Binary Search
Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

SearchService service = new SearchService();

Console.Write("Enter Product Name to Search: ");
string name = Console.ReadLine()!;

Console.WriteLine("\n1. Linear Search");
Console.WriteLine("2. Binary Search");

Console.Write("Choose Search Method: ");
int choice = int.Parse(Console.ReadLine()!);

Product? result = null;

if (choice == 1)
    result = service.LinearSearch(products, name);
else
    result = service.BinarySearch(products, name);

Console.WriteLine();

if (result != null)
{
    Console.WriteLine("Product Found");
    Console.WriteLine($"ID       : {result.ProductId}");
    Console.WriteLine($"Name     : {result.ProductName}");
    Console.WriteLine($"Category : {result.Category}");
}
else
{
    Console.WriteLine("Product Not Found");
}