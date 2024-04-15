using CarRental.Application.Repositories;
using CarRental.Application.Repositories.RentalPayment;
using CarRental.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Persistence.Repositories.RentalPayment
{
    public class RentalPaymentReadRepository : ReadRepository<Domain.Entities.RentalPayment>, IRentalPaymentReadRepository
    {
        public RentalPaymentReadRepository(CarRentalDbContext context) : base(context)
        {
        }
    }
}
