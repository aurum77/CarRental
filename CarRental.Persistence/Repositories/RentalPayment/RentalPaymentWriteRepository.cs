using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Application.Repositories.RentalPayment;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories.RentalPayment;

public class RentalPaymentWriteRepository
    : WriteRepository<Domain.Entities.RentalPayment>,
        IRentalPaymentWriteRepository
{
    public RentalPaymentWriteRepository(CarRentalDbContext context)
        : base(context) { }
}
