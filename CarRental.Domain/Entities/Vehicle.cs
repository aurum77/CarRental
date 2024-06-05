using CarRental.Domain.Entities.Common;
using CarRental.Domain.Enums;

namespace CarRental.Domain.Entities;

public class Vehicle : BaseEntity
{
    public Guid BrandId { get; set; }
    public VehicleBrand? Brand { get; set; }
    public Guid ModelId { get; set; }
    public VehicleModel? Model { get; set; }
    public string? LicensePlate { get; set; }
    public int ModelYear { get; set; }
    public ICollection<Rental> RentalHistory { get; } = new List<Rental>();
    public ICollection<VehicleImageFile> Images { get; } = new List<VehicleImageFile>();
    public ICollection<RentalReceiptFile>? RentalReceiptFiles { get; } =
        new List<RentalReceiptFile>();
    public Guid CategoryId { get; set; }
    public VehicleCategory? Category { get; set; }
    public Guid RentalId { get; set; }
    public Rental? Rental { get; set; }
    public double DailyPrice { get; set; }
    public VehicleStatus Status { get; set; }
}
