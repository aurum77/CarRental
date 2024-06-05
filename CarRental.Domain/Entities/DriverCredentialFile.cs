namespace CarRental.Domain.Entities;

public class DriverCredentialFile : Domain.Entities.Common.File
{
    public Guid DriverId { get; set; }
    public Driver? Driver { get; set; }
}
