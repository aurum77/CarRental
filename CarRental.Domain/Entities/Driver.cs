using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities;

public class Driver : BaseEntity
{
    public string? Name { get; set; }
    public Guid CompanyId { get; set; }
    public Company? Company { get; set; }
    public string? PhoneNumber { get; set; }
    public ICollection<Rental>? Rentals { get; } = new List<Rental>();
    public ICollection<DriverCredentialFile>? DriverCredentialFiles { get; } =
        new List<DriverCredentialFile>();
    public ICollection<RentalReceiptFile>? RentalReceiptFiles { get; } =
        new List<RentalReceiptFile>();
}
