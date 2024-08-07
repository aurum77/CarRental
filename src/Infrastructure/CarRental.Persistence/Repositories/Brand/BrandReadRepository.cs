using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class BrandReadRepository : ReadRepository<Brand>, IBrandReadRepository
{
    public BrandReadRepository(CarRentalDbContext context)
        : base(context) { }
}
