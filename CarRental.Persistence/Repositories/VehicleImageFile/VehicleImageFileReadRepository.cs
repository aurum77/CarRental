using CarRental.Application.Repositories.VehicleImageFile;
using CarRental.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Persistence.Repositories.VehicleImageFile
{
    public class VehicleImageFileReadRepository : ReadRepository<Domain.Entities.VehicleImageFile>, IVehicleImageFileReadRepository
    {
        public VehicleImageFileReadRepository(CarRentalDbContext context) : base(context)
        {
        }
    }
}
