using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class FeaturesReadRepository : ReadRepository<Features>, IFeaturesReadRepository
{
    public FeaturesReadRepository(CarRentalDbContext context)
        : base(context) { }
}
