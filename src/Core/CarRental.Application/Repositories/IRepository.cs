using CarRental.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Application.Repositories
{
    public interface IRepository<T>
        where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
