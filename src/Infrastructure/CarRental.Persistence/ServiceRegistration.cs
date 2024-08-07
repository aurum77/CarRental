using CarRental.Application.Repositories;
using CarRental.Application.Services;
using CarRental.Persistence.Contexts;
using CarRental.Persistence.Repositories;
using CarRental.Persistence.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<CarRentalDbContext>(options =>
        {
            options.UseNpgsql(Configuration.ConnectionString);
        });

        services.AddScoped<IBrandService, BrandService>();
        services.AddScoped<IBrandReadRepository, BrandReadRepository>();
        services.AddScoped<IBrandWriteRepository, BrandWriteRepository>();

        services.AddScoped<IFeaturesReadRepository, FeaturesReadRepository>();
        services.AddScoped<IFeaturesWriteRepository, FeaturesWriteRepository>();

        services.AddScoped<IModelReadRepository, ModelReadRepository>();
        services.AddScoped<IModelReadRepository, ModelReadRepository>();

        services.AddScoped<IRentalReadRepository, RentalReadRepository>();
        services.AddScoped<IRentalReadRepository, RentalReadRepository>();

        services.AddScoped<IRequirementReadRepository, RequirementReadRepository>();
        services.AddScoped<IRequirementReadRepository, RequirementReadRepository>();

        services.AddScoped<IVehicleReadRepository, VehicleReadRepository>();
        services.AddScoped<IVehicleReadRepository, VehicleReadRepository>();
    }
}
