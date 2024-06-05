using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities;

public class VehicleBrand : BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public ICollection<VehicleModel> Models { get; } = new List<VehicleModel>();
}
