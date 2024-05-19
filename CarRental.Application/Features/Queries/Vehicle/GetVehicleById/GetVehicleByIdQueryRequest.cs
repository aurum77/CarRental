using MediatR;

namespace CarRental.Application.Features.Queries.Vehicle.GetVehicleById;

public class GetVehicleByIdQueryRequest : IRequest<GetVehicleByIdQueryResponse>
{
    public string? Id { get; set; }
}
