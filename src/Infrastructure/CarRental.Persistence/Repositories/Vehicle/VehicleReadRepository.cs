using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class VehicleReadRepository : ReadRepository<Vehicle>, IVehicleReadRepository
{
    public VehicleReadRepository(CarRentalDbContext context)
        : base(context) { }
}
