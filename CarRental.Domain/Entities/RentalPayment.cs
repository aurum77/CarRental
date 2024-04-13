using CarRental.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Entities
{
    public class RentalPayment : BaseEntity
    {
        public Guid RentalId { get; set; }
        public Rental? Rental { get; set; }
        public Guid CustomerId { get; set; }
        public double Amount { get; set; }
    }
}
