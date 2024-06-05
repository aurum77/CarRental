using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class RentalReceiptFileWriteRepository
    : WriteRepository<RentalReceiptFile>,
        IRentalReceiptFileWriteRepository
{
    public RentalReceiptFileWriteRepository(CarRentalDbContext context)
        : base(context) { }
}
