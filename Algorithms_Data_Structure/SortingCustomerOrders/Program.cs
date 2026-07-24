using SortingCustomerOrders.Models;
using SortingCustomerOrders.Services;

Order[] orders =
{
    new Order { OrderId = 1, CustomerName = "Amit", TotalPrice = 4500 },
    new Order { OrderId = 2, CustomerName = "Riya", TotalPrice = 1200 },
    new Order { OrderId = 3, CustomerName = "John", TotalPrice = 8000 },
    new Order { OrderId = 4, CustomerName = "Sara", TotalPrice = 2500 }
};

SortService service = new SortService();

Console.WriteLine("1. Bubble Sort");
Console.WriteLine("2. Quick Sort");

Console.Write("Choose Sorting Method: ");
int choice = int.Parse(Console.ReadLine()!);

if (choice == 1)
{
    service.BubbleSort(orders);
    Console.WriteLine("\nSorted using Bubble Sort:");
}
else
{
    service.QuickSort(orders, 0, orders.Length - 1);
    Console.WriteLine("\nSorted using Quick Sort:");
}

service.Display(orders);