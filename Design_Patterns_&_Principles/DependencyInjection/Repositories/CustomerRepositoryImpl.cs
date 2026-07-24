using DependencyInjectionExample.Models;

namespace DependencyInjectionExample.Repositories
{
    public class CustomerRepositoryImpl : ICustomerRepository
    {
        public Customer FindCustomerById(int id)
        {
            return new Customer
            {
                Id = id,
                Name = "Priyashree"
            };
        }
    }
}