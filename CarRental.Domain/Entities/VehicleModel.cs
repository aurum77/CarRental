using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities;

public class VehicleModel : BaseEntity
{
    public Guid BrandId { get; set; }
    public VehicleBrand? Brand { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}
