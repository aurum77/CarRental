using System.Linq.Expressions;
using CarRental.Application.Repositories;
using CarRental.Domain.Entities.Common;
using CarRental.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Persistence.Repositories;

public class ReadRepository<T>(CarRentalDbContext context) : IReadRepository<T>
    where T : BaseEntity
{
    private readonly CarRentalDbContext _context = context;

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll(bool tracking = true)
    {
        IQueryable<T> query = Table.AsQueryable();

        if (!tracking)
        {
            query = query = query.AsNoTracking();
        }

        return query;
    }

    public async Task<T> GetByIdAsync(Guid id, bool tracking = true)
    {
        IQueryable<T> query = Table.AsQueryable();

        if (!tracking)
        {
            query = query = query.AsNoTracking();
        }

        return await query.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking = true)
    {
        IQueryable<T> query = Table.AsQueryable();

        if (!tracking)
        {
            query = query.AsNoTracking();
        }

        return await query.FirstOrDefaultAsync(expression);
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool tracking = true)
    {
        IQueryable<T> query = Table.Where(expression);

        if (!tracking)
        {
            query = query.AsNoTracking();
        }

        return query;
    }
}
