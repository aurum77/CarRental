using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Application.Repositories.VehicleCategory;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories.VehicleCategory;

public class VehicleCategoryWriteRepository
    : WriteRepository<Domain.Entities.VehicleCategory>,
        IVehicleCategoryWriteRepository
{
    public VehicleCategoryWriteRepository(CarRentalDbContext context)
        : base(context) { }
}
