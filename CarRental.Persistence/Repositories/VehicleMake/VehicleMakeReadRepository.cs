using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Application.Repositories.Vehicle;
using CarRental.Application.Repositories.VehicleMake;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories.VehicleMake;

public class VehicleMakeReadRepository
    : ReadRepository<Domain.Entities.VehicleMake>,
        IVehicleMakeReadRepository
{
    public VehicleMakeReadRepository(CarRentalDbContext context)
        : base(context) { }
}
