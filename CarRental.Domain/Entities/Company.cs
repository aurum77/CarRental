using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities;

public class Company : BaseEntity
{
    public string? Name { get; set; }
    public string? RepresentativeName { get; set; }
    public string? RepresentativeNumber { get; set; }
    public ICollection<Driver>? Drivers { get; } = new List<Driver>();
}
