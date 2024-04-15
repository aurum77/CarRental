using CarRental.Application.Repositories.VehicleModel;
using CarRental.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Persistence.Repositories.VehicleModel
{
    public class VehicleModelWriteRepository : WriteRepository<Domain.Entities.VehicleModel>, IVehicleModelWriteRepository
    {
        public VehicleModelWriteRepository(CarRentalDbContext context) : base(context)
        {
        }
    }
}
