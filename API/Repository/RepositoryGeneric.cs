using System.Linq.Expressions;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repository;


public class RepositoryGeneric<T> : IRepositoryGenric<T> where T : class
{
    private readonly PruebaContext _context;

    public RepositoryGeneric(PruebaContext context)
    {
        _context = context;
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void AddRange(IEnumerable<T> entities)
    {
       _context.Set<T>().AddRange(entities);
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
       return  _context.Set<T>().Where(expression).ToList();
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetById(int id)
    {
       return await _context.Set<T>().FindAsync(id);
    }

    public void Remove(T entity)
    {
       _context.Set<T>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }
}