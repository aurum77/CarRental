using CarRental.Application.Features.Queries.Vehicle.GetVehicleById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehicleController : ControllerBase
{
    private readonly IMediator _mediatr;

    public VehicleController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [HttpGet("{Id}")]
    public async Task<GetVehicleByIdResponse> Get([FromRoute] GetVehicleByIdRequest request)
    {
        return await _mediatr.Send(request);
    }

    [HttpPost]
    public String Create()
    {
        return "foo";
    }
}
