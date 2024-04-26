using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Repositories.VehicleCategory;

public interface IVehicleCategoryWriteRepository
    : IWriteRepository<Domain.Entities.VehicleCategory> { }
