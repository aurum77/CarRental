using CarRental.Application.Repositories.VehicleFeature;
using CarRental.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Persistence.Repositories.VehicleFeature
{
    public class VehicleFeatureReadRepository : ReadRepository<Domain.Entities.VehicleFeature>, IVehicleFeatureReadRepository
    {
        public VehicleFeatureReadRepository(CarRentalDbContext context) : base(context)
        {
        }
    }
}
