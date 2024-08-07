using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class FeaturesWriteRepository : WriteRepository<Features>, IFeaturesWriteRepository
{
    public FeaturesWriteRepository(CarRentalDbContext context)
        : base(context) { }
}
