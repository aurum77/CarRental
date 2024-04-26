using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Repositories.VehicleFeature;

public interface IVehicleFeatureWriteRepository
    : IWriteRepository<Domain.Entities.VehicleFeature> { }
