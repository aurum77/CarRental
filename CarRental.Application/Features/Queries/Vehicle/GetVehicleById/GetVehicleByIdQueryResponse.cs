namespace CarRental.Application.Features.Queries.Vehicle.GetVehicleById;

public class GetVehicleByIdQueryResponse
{
    public string? MakeName { get; set; }
    public string? ModelName { get; set; }
    public double? DailyPrice { get; set; }
    public string? VehicleStatus { get; set; }
}
