using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Persistence.Repositories;

public class VehicleReadRepository : ReadRepository<Vehicle>, IVehicleReadRepository
{
    public VehicleReadRepository(CarRentalDbContext context)
        : base(context) { }
}
