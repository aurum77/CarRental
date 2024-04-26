using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities;

public class VehicleCategory : BaseEntity
{
    public string? Name { get; set; }
    public ICollection<Vehicle> Vehicles { get; } = new List<Vehicle>();
}
