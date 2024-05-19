using CarRental.Application.Abstractions;
using CarRental.Application.Features.Queries.Vehicle.GetVehicleById;
using MediatR;

namespace CarRental.Application.Features.Queries;

public class GetVehicleByIdQueryHandler : IRequestHandler<GetVehicleByIdQueryRequest, GetVehicleByIdQueryResponse>
{
    private readonly IVehicleService _vehicleService;

    public GetVehicleByIdQueryHandler(IVehicleService vehicleService)
    {
        _vehicleService = vehicleService;
    }

    public async Task<GetVehicleByIdQueryResponse> Handle(
        GetVehicleByIdQueryRequest request,
        CancellationToken cancellationToken
    )
    {
        var vehicle = await _vehicleService.GetVehicleByIdAsync(request.Id);

        return new()
        {
            MakeName = vehicle.Make?.BrandName,
            ModelName = vehicle.Model?.ModelName,
            DailyPrice = vehicle.DailyPrice,
            VehicleStatus = vehicle.Status.ToString()
        };
    }
}
