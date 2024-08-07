using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class ModelWriteRepository : WriteRepository<Model>, IModelWriteRepository
{
    public ModelWriteRepository(CarRentalDbContext context)
        : base(context) { }
}
