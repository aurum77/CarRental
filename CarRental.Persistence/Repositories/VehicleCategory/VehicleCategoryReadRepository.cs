using CarRental.Application.Repositories;
using CarRental.Application.Repositories.VehicleCategory;
using CarRental.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Persistence.Repositories.VehicleCategory
{
    public class VehicleCategoryReadRepository : ReadRepository<Domain.Entities.VehicleCategory>, IVehicleCategoryReadRepository
    {
        public VehicleCategoryReadRepository(CarRentalDbContext context) : base(context)
        {
        }
    }
}
