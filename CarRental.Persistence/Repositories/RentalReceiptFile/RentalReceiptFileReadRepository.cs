using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class RentalReceiptFileReadRepository
    : ReadRepository<RentalReceiptFile>,
        IRentalReceiptFileReadRepository
{
    public RentalReceiptFileReadRepository(CarRentalDbContext context)
        : base(context) { }
}
