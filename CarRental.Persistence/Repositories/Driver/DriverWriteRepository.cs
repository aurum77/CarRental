using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class DriverWriteRepository : WriteRepository<Driver>, IDriverWriteRepository
{
    public DriverWriteRepository(CarRentalDbContext context)
        : base(context) { }
}
