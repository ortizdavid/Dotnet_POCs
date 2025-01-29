using GenericRepository.Models;
using GenericRepository.Repositories;

namespace GenericRepository.Application;

public class CustomerManager
{
    public static void SeedData(CustomerRepository repository)
    {
        var customer = new Customer
        { 
            Name = "Customer 2", 
            Identification = "CL093" 
        };

        // Create
        repository.Create(customer);

        // FindAll
        foreach (var c in repository.GetAll())
        {
            Console.WriteLine($"{c.Name}\t{c.Identification}");
        }
        Console.WriteLine();
    }
}