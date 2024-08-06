using CarRental.Domain.Entities.Common;

namespace CarRental.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T>
        where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddMultipleAsync(List<T> entities);
        bool Remove(T entity);
        bool RemoveRange(List<T> entities);
        Task<bool> RemoveAsync(Guid id);
        bool Update(T entity);

        Task<int> SaveAsync();
    }
}
