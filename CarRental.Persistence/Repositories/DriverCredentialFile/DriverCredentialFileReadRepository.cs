using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class DriverCredentialFileReadRepository
    : ReadRepository<DriverCredentialFile>,
        IDriverCredentialFileReadRepository
{
    public DriverCredentialFileReadRepository(CarRentalDbContext context)
        : base(context) { }
}
