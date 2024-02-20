using HospitalManagementSystem.DataAccess.Context;
using HospitalManagementSystem.Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HospitalManagementSystem.DataAccess.Repositories;
internal class Repository<T> : IRepository<T>
    where T : class
{
    private readonly ApplicationDbContext _context;
    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        await _context.Set<T>().AddAsync(entity, cancellationToken);
    }

    public IQueryable<T> GetAll()
    {
        return _context.Set<T>().AsNoTracking().AsQueryable();
    }

    public async Task<T?> GetByIdAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        return await _context.Set<T>().Where(expression).FirstOrDefaultAsync(cancellationToken);
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().AsNoTracking().Where(expression).AsQueryable();
    }

    public void Remove(T entity)
    {
        _context.Remove(entity);
    }

    public void Update(T entity)
    {
        _context.Update(entity);
    }
}