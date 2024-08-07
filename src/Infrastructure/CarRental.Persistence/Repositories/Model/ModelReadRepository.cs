using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class ModelReadRepository : ReadRepository<Model>, IModelReadRepository
{
    public ModelReadRepository(CarRentalDbContext context)
        : base(context) { }
}
