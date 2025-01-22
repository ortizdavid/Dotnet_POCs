using GenericRepository.Application;
using GenericRepository.Models;
using GenericRepository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        // setup configuration
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        // Setup DI
        var services = new ServiceCollection();
        ConfigureServices(services, configuration);    
        var serviceProvider = services.BuildServiceProvider();

        // Get repositories from DI
        var productRepo = serviceProvider.GetRequiredService<ProductRepository>();
        var customerRepo = serviceProvider.GetRequiredService<CustomerRepository>();

        // Managers with Repositories
        ProductManager.SeedData(productRepo);
        CustomerManager.SeedData(customerRepo);
    }

    public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
        );
    
        // Register Dependencies
        services.AddScoped<ProductRepository>();
        services.AddScoped<CustomerRepository>();
    }
}