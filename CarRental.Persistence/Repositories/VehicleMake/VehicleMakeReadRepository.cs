using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class VehicleMakeReadRepository
    : ReadRepository<VehicleMake>,
        IVehicleMakeReadRepository
{
    public VehicleMakeReadRepository(CarRentalDbContext context)
        : base(context) { }
}
