using System.Linq.Expressions;

namespace HospitalManagementSystem.Entities.Repositories;
public interface IRepository<T>
{
    Task AddAsync(T entity, CancellationToken cancellationToken = default);
    void Update(T entity);
    void Remove(T entity);
    Task<T> GetByIdAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
    IQueryable<T> GetAll();
    IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
}
