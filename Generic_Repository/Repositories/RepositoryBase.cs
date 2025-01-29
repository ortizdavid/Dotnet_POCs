using GenericRepository.Models;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Repositories;

public class RepositoryBase<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public RepositoryBase(AppDbContext context) 
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public int Count()
    {
        return _dbSet.Count();
    }

    public void Create(T entity)
    {
        _dbSet.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
        _context.SaveChanges();
    }

    public bool Exists(string field, string value)
    {
        return _dbSet.Any(e => EF.Property<string>(e, field) == value);
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public T? GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
        _context.SaveChanges();
    }
}