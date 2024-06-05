using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class VehicleBrandWriteRepository
    : WriteRepository<VehicleBrand>,
        IVehicleBrandWriteRepository
{
    public VehicleBrandWriteRepository(CarRentalDbContext context)
        : base(context) { }
}
