using CarRental.Application.Repositories;
using CarRental.Application.Repositories.Vehicle;
using CarRental.Persistence.Contexts;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Persistence.Repositories.Vehicle
{
    public class VehicleReadRepository : ReadRepository<Domain.Entities.Vehicle>, IVehicleReadRepository
    {
        public VehicleReadRepository(CarRentalDbContext context) : base(context)
        {
        }
    }
}
