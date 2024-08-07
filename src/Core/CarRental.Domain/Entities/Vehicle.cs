using CarRental.Domain.Entities.Common;
using CarRental.Domain.Enums;

namespace CarRental.Domain.Entities;

public class Vehicle : BaseEntity
{
    public required Guid ModelId { get; set; }
    public required Model? Model { get; set; }
    public int MileageInKm { get; set; }
    public Status Status { get; set; }
}
