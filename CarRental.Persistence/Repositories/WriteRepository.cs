using CarRental.Application.Repositories;
using CarRental.Domain.Entities.Common;
using CarRental.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CarRental.Persistence.Repositories;

public class WriteRepository<T> : IWriteRepository<T>
    where T : BaseEntity
{
    private readonly CarRentalDbContext _context;

    public WriteRepository(CarRentalDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public async Task<bool> AddAsync(T model)
    {
        EntityEntry<T> entity = await Table.AddAsync(model);

        return entity.State == EntityState.Added;
    }

    public async Task<bool> AddRangeAsync(List<T> models)
    {
        await Table.AddRangeAsync(models);
        return true;
    }

    public bool Remove(T model)
    {
        EntityEntry<T> entity = Table.Remove(model);

        return entity.State == EntityState.Deleted;
    }

    public async Task<bool> RemoveAsync(string id)
    {
        T model = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));

        return Remove(model);
    }

    public bool RemoveRange(List<T> models)
    {
        Table.RemoveRange(models);

        return true;
    }

    public Task<int> SaveAsync()
    {
        return _context.SaveChangesAsync();
    }

    public bool Update(T model)
    {
        EntityEntry entity = Table.Update(model);

        return entity.State == EntityState.Modified;
    }
}
