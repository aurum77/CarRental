namespace CarRental.Domain.Entities;

public class VehicleImageFile : Domain.Entities.Common.File
{
    public Vehicle? Vehicle { get; set; }
}
