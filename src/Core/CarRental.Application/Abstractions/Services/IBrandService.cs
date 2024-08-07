using CarRental.Domain.Entities;

namespace CarRental.Application.Services;

public interface IBrandService 
{ 
    Task<List<Brand>> GetAllBrands();
}
