using CarRental.Application.Abstractions;
using MediatR;

namespace CarRental.Application.Features.Queries.Vehicle.GetVehicleById;

public class GetVehicleByIdHandler : IRequestHandler<GetVehicleByIdRequest, GetVehicleByIdResponse>
{
    private readonly IVehicleService _vehicleService;

    public GetVehicleByIdHandler(IVehicleService vehicleService)
    {
        _vehicleService = vehicleService;
    }

    public async Task<GetVehicleByIdResponse> Handle(
        GetVehicleByIdRequest request,
        CancellationToken cancellationToken
    )
    {
        var vehicle = await _vehicleService.GetVehicleById(request.Id);

        return new()
        {
            MakeName = vehicle.Make?.BrandName,
            ModelName = vehicle.Model?.ModelName,
            DailyPrice = vehicle.DailyPrice,
            VehicleStatus = vehicle.Status.ToString()
        };
    }
}
