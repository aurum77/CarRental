using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Identity;

namespace CarRental.Domain.Entities;

public class Rental : BaseEntity
{
    public Guid RenterId { get; set; }
    public AppUser? Renter { get; set; }
    public Guid VehicleId { get; set; }
    public Vehicle? Vehicle { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
