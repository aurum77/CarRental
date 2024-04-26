using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Application.Repositories.VehicleFeature;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories.VehicleFeature;

public class VehicleFeatureWriteRepository
    : WriteRepository<Domain.Entities.VehicleFeature>,
        IVehicleFeatureWriteRepository
{
    public VehicleFeatureWriteRepository(CarRentalDbContext context)
        : base(context) { }
}
