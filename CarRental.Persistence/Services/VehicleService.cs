using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Application.Repositories.Vehicle;
using CarRental.Domain.Entities;

namespace CarRental.Application.Abstractions.Services;

public class VehicleService : IVehicleService
{
    private readonly IVehicleReadRepository _vehicleReadRepository;

    public VehicleService(IVehicleReadRepository vehicleReadRepository)
    {
        _vehicleReadRepository = vehicleReadRepository;
    }

    public async Task<Vehicle> GetVehicleById(string id)
    {
        var vehicle = await _vehicleReadRepository.GetByIdAsync(id);

        if (vehicle == null)
        {
            throw new Exception("Requested Vehicle not found");
        }

        return vehicle;
    }
}
