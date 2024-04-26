using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities;

public class Rental : BaseEntity
{
    public Guid CustomerId { get; set; }
    public int Days { get; set; }
}
