using System.Linq.Expressions;

namespace Dominio.Interfaces;

public interface IRepositoryGeneric<T>
{
    Task<T> GetById(int id);
    Task<IEnumerable<T>> GetAll();
    IEnumerable<T> Find(Expression<Func<T,bool>> expression);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
    void Add(T entity);
    void AddRange(IEnumerable<T> entities);
    void Update(T entity);
}