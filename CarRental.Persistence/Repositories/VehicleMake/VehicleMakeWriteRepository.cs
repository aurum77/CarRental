using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Application.Repositories;
using CarRental.Application.Repositories.VehicleMake;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories.VehicleMake;

public class VehicleMakeWriteRepository
    : WriteRepository<Domain.Entities.VehicleMake>,
        IVehicleMakeWriteRepository
{
    public VehicleMakeWriteRepository(CarRentalDbContext context)
        : base(context) { }
}
