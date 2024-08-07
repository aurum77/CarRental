using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class RequirementWriteRepository : WriteRepository<Requirement>, IRequirementWriteRepository
{
    public RequirementWriteRepository(CarRentalDbContext context)
        : base(context) { }
}
