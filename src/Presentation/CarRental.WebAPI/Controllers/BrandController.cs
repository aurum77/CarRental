using CarRental.Application.Services;
using CarRental.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.WebAPI.Controllers;

[ApiController]
[Route("api/brands")]
public class BrandController(IBrandService brandService) : ControllerBase
{
    private readonly IBrandService _brandService = brandService;

    [HttpGet]
    public async Task<List<Brand>> Get()
    {
        return await _brandService.GetAllBrands();
    }
}
