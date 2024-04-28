using CarRental.Application.Abstractions;
using CarRental.Application.Abstractions.Services;
using CarRental.Application.Repositories.Vehicle;
using CarRental.Persistence.Contexts;
using CarRental.Persistence.Repositories.Vehicle;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<CarRentalDbContext>(options =>
            options.UseNpgsql(Configuration.ConnectionString)
        );

        services.AddScoped<IVehicleReadRepository, VehicleReadRepository>();

        services.AddScoped<IVehicleService, VehicleService>();
    }
}
