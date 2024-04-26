using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Application.Repositories.Vehicle;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories.Vehicle;

public class VehicleWriteRepository
    : WriteRepository<Domain.Entities.Vehicle>,
        IVehicleWriteRepository
{
    public VehicleWriteRepository(CarRentalDbContext context)
        : base(context) { }
}
