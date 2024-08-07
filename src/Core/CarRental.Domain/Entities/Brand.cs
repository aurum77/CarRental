using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities;

public class Brand : BaseEntity
{
    public required string Name { get; set; }
    public ICollection<Model>? Models { get; set; }
}
