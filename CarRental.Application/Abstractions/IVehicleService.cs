using CarRental.Domain.Entities;

namespace CarRental.Application.Abstractions;

public interface IVehicleService
{
    Task<Vehicle> GetVehicleByIdAsync(string id);
}
