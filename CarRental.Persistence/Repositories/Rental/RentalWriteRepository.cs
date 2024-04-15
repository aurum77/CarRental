using CarRental.Application.Repositories.Rental;
using CarRental.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Persistence.Repositories.Rental
{
    public class RentalWriteRepository : WriteRepository<Domain.Entities.Rental>, IRentalWriteRepository
    {
        public RentalWriteRepository(CarRentalDbContext context) : base(context)
        {
        }
    }
}
