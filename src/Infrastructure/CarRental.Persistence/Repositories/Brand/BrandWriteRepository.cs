using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class BrandWriteRepository : WriteRepository<Brand>, IBrandWriteRepository
{
    public BrandWriteRepository(CarRentalDbContext context)
        : base(context) { }
}
