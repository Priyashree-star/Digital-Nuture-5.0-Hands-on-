using DependencyInjectionExample.Repositories;
using DependencyInjectionExample.Services;

Console.Write("Enter Customer ID: ");
int id = int.Parse(Console.ReadLine()!);

ICustomerRepository repository = new CustomerRepositoryImpl();

CustomerService service = new CustomerService(repository);

var customer = service.GetCustomer(id);

Console.WriteLine("\nCustomer Details");
Console.WriteLine($"ID   : {customer.Id}");
Console.WriteLine($"Name : {customer.Name}");