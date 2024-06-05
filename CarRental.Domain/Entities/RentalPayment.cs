using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities;

public class RentalPayment : BaseEntity
{
    public Guid RentalId { get; set; }
    public Rental? Rental { get; set; }
    public Guid CompanyId { get; set; }
    public Company? Company { get; set; }
    public double Amount { get; set; }
    public Domain.Entities.Common.File? Receipt { get; set; }
}
