using CarRental.Application.Repositories;
using CarRental.Application.Services;
using CarRental.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Persistence.Services;

public class BrandService(IBrandReadRepository brandReadRepository) : IBrandService
{
    private readonly IBrandReadRepository _readRepository = brandReadRepository;

    public async Task<List<Brand>> GetAllBrands()
    {
        return await _readRepository.Table.ToListAsync();
    }
}
