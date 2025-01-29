using GenericRepository.Models;

namespace GenericRepository.Repositories;

public class CustomerRepository : RepositoryBase<Customer>
{
    public CustomerRepository(AppDbContext context) : base(context)
    {
    }
}