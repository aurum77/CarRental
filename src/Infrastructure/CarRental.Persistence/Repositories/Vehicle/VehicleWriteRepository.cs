using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class VehicleWriteRepository : WriteRepository<Vehicle>, IVehicleWriteRepository
{
    public VehicleWriteRepository(CarRentalDbContext context)
        : base(context) { }
}
