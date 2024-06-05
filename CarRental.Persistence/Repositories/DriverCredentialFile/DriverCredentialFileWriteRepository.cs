using CarRental.Application.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;

namespace CarRental.Persistence.Repositories;

public class DriverCredentialFileWriteRepository
    : WriteRepository<DriverCredentialFile>,
        IDriverCredentialFileWriteRepository
{
    public DriverCredentialFileWriteRepository(CarRentalDbContext context)
        : base(context) { }
}
