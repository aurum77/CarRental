namespace CarRental.Domain.Entities;

public class RentalReceiptFile : Domain.Entities.Common.File
{
    public Guid CompanyId { get; set; }
    public Company? Company { get; set; }
    public Guid VehicleId { get; set; }
    public Vehicle? Vehicle { get; set; }
    public Guid DriverId { get; set; }
    public Driver? Driver { get; set; }
}
