using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities.Common;

public class File : BaseEntity
{
    public string? Filename { get; set; }
    public string? Path { get; set; }
    public string? Storage { get; set; }
}
