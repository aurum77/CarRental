using CarRental.Application.Repositories.Vehicle;
using CarRental.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Persistence.Repositories.Vehicle
{
    public class VehicleWriteRepository : WriteRepository<Domain.Entities.Vehicle>, IVehicleWriteRepository
    {
        public VehicleWriteRepository(CarRentalDbContext context) : base(context)
        {
        }
    }
}
