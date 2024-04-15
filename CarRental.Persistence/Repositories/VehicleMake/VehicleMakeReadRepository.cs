using CarRental.Application.Repositories.Vehicle;
using CarRental.Application.Repositories.VehicleMake;
using CarRental.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Persistence.Repositories.VehicleMake
{
    public class VehicleMakeReadRepository : ReadRepository<Domain.Entities.VehicleMake>, IVehicleMakeReadRepository
    {
        public VehicleMakeReadRepository(CarRentalDbContext context) : base(context)
        {
        }
    }
}
