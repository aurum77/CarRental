using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class DriverReadRepository : ReadRepository<Driver>, IDriverReadRepository
{
    public DriverReadRepository(CarRentalDbContext context)
        : base(context) { }
}
