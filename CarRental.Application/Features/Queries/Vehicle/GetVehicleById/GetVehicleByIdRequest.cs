using MediatR;

namespace CarRental.Application.Features.Queries.Vehicle.GetVehicleById;

public class GetVehicleByIdRequest : IRequest<GetVehicleByIdResponse>
{
    public string? Id { get; set; }
}
