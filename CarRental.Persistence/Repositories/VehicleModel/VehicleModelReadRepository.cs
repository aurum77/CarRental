using CarRental.Application.Repositories.VehicleModel;
using CarRental.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Persistence.Repositories.VehicleModel
{
    public class VehicleModelReadRepository : ReadRepository<Domain.Entities.VehicleModel>, IVehicleModelReadRepository
    {
        public VehicleModelReadRepository(CarRentalDbContext context) : base(context)
        {
        }
    }
}
