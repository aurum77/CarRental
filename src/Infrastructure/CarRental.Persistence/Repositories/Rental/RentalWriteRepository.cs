using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class RentalWriteRepository : WriteRepository<Rental>, IRentalWriteRepository
{
    public RentalWriteRepository(CarRentalDbContext context)
        : base(context) { }
}
