using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities;

public class RentalPayment : BaseEntity
{
    public Guid RentalId { get; set; }
    public Rental? Rental { get; set; }
    public Guid CustomerId { get; set; }
    public double Amount { get; set; }
}
