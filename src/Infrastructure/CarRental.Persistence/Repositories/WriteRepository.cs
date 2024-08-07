using CarRental.Application.Repositories;
using CarRental.Domain.Entities.Common;
using CarRental.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CarRental.Persistence.Repositories;

public class WriteRepository<T>(CarRentalDbContext context) : IWriteRepository<T>
    where T : BaseEntity
{
    private readonly CarRentalDbContext _context = context;

    public DbSet<T> Table => _context.Set<T>();

    public async Task<bool> AddAsync(T entity)
    {
        EntityEntry<T> entityEntry = await Table.AddAsync(entity);
        return entityEntry.State == EntityState.Added;
    }

    public async Task<bool> AddMultipleAsync(List<T> entities)
    {
        await Table.AddRangeAsync(entities);
        return true;
    }

    public bool Remove(T entity)
    {
        EntityEntry<T> entityEntry = Table.Remove(entity);
        return entityEntry.State == EntityState.Deleted;
    }

    public async Task<bool> RemoveAsync(Guid id)
    {
        T entity = await Table.FirstOrDefaultAsync(data => data.Id == id);
        return Remove(entity);
    }

    public bool RemoveRange(List<T> entities)
    {
        Table.RemoveRange(entities);
        return true;
    }

    public Task<int> SaveAsync()
    {
        return _context.SaveChangesAsync();
    }

    public bool Update(T model)
    {
        EntityEntry entityEntry = Table.Update(model);
        return entityEntry.State == EntityState.Modified;
    }
}
