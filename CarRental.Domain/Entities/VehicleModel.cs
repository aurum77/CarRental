using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities;

public class VehicleModel : BaseEntity
{
    public string? ModelName { get; set; }
}
