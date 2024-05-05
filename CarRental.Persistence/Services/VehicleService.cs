using CarRental.Application.Exceptions;
using CarRental.Application.Repositories;
using CarRental.Domain.Entities;

namespace CarRental.Application.Abstractions.Services;

public class VehicleService : IVehicleService
{
    private readonly IVehicleReadRepository _vehicleReadRepository;

    public VehicleService(IVehicleReadRepository vehicleReadRepository)
    {
        _vehicleReadRepository = vehicleReadRepository;
    }

    public async Task<Vehicle> GetVehicleByIdAsync(string id)
    {
        var vehicle = await _vehicleReadRepository.GetByIdAsync(id);

        if (vehicle == null)
        {
            throw new NotFoundException("Requested vehicle not found");
        }

        return vehicle;
    }
}
