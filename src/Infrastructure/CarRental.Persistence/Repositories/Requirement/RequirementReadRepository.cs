using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class RequirementReadRepository : ReadRepository<Requirement>, IRequirementReadRepository
{
    public RequirementReadRepository(CarRentalDbContext context)
        : base(context) { }
}
