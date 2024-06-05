using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities;

public class Rental : BaseEntity
{
    public Guid DriverId { get; set; }
    public Driver? Driver { get; set; }
    public int Days { get; set; }
    public ICollection<RentalPayment> RentalPayments { get; } = new List<RentalPayment>();
    public ICollection<RentalReceiptFile>? RentalReceiptFiles { get; } =
        new List<RentalReceiptFile>();
    public DateTime? ValidUntil { get; set; }
    public bool Valid { get; set; }
}
