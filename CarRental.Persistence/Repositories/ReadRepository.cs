using System.Linq.Expressions;
using CarRental.Application.Repositories;
using CarRental.Domain.Entities.Common;
using CarRental.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T>
        where T : BaseEntity
    {
        private readonly CarRentalDbContext _context;

        public ReadRepository(CarRentalDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            IQueryable<T> query = Table.AsQueryable();

            if (!tracking)
            {
                query = query.AsNoTracking();
            }

            return query;
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            IQueryable<T> query = Table.AsQueryable();

            if (!tracking)
            {
                query = query.AsNoTracking();
            }

            return await query.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            IQueryable<T> query = Table.AsQueryable();

            if (!tracking)
            {
                query = query.AsNoTracking();
            }

            return await query.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            IQueryable<T> query = Table.Where(method);

            if (!tracking)
            {
                query = query.AsNoTracking();
            }

            return query;
        }
    }
}
