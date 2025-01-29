using GenericRepository.Models;
using GenericRepository.Repositories;

namespace GenericRepository.Application;

public class ProductManager
{
    public static void SeedData(ProductRepository repository)
    {
        var Product = new Product
        { 
            Name = "Product 2", 
            Price = 10.99 
        };

        // Create
        repository.Create(Product);

        // FindAll
        foreach (var c in repository.GetAll())
        {
            Console.WriteLine($"{c.Name}\t{c.Price}");
        }
        Console.WriteLine();
    }
}