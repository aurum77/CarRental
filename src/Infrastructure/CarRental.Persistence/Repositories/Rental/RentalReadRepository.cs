using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class RentalReadRepository : ReadRepository<Rental>, IRentalReadRepository
{
    public RentalReadRepository(CarRentalDbContext context)
        : base(context) { }
}
