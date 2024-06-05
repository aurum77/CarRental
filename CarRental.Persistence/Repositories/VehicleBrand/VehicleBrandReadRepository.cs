using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class VehicleBrandReadRepository
    : ReadRepository<VehicleBrand>,
        IVehicleBrandReadRepository
{
    public VehicleBrandReadRepository(CarRentalDbContext context)
        : base(context) { }
}
