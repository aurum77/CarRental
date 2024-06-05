using CarRental.Application.Abstractions;
using CarRental.Application.Abstractions.Services;
using CarRental.Application.Repositories;
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
        // -- CONTEXT --
        services.AddDbContext<CarRentalDbContext>(options =>
            options.UseNpgsql(Configuration.ConnectionString)
        );

        // -- REPOSITORIES --
        services.AddScoped<IVehicleReadRepository, VehicleReadRepository>();
        services.AddScoped<IVehicleWriteRepository, VehicleWriteRepository>();
        services.AddScoped<ICompanyReadRepository, CompanyReadRepository>();
        services.AddScoped<ICompanyWriteRepository, CompanyWriteRepository>();
        services.AddScoped<IDriverReadRepository, DriverReadRepository>();
        services.AddScoped<IDriverWriteRepository, DriverWriteRepository>();
        services.AddScoped<
            IDriverCredentialFileReadRepository,
            DriverCredentialFileReadRepository
        >();
        services.AddScoped<
            IDriverCredentialFileWriteRepository,
            DriverCredentialFileWriteRepository
        >();
        services.AddScoped<IRentalReadRepository, RentalReadRepository>();
        services.AddScoped<IRentalWriteRepository, RentalWriteRepository>();
        services.AddScoped<IRentalPaymentReadRepository, RentalPaymentReadRepository>();
        services.AddScoped<IRentalPaymentWriteRepository, RentalPaymentWriteRepository>();
        services.AddScoped<IRentalReceiptFileReadRepository, RentalReceiptFileReadRepository>();
        services.AddScoped<IRentalReceiptFileWriteRepository, RentalReceiptFileWriteRepository>();
        services.AddScoped<IVehicleReadRepository, VehicleReadRepository>();
        services.AddScoped<IVehicleWriteRepository, VehicleWriteRepository>();
        services.AddScoped<IVehicleBrandReadRepository, VehicleBrandReadRepository>();
        services.AddScoped<IVehicleBrandWriteRepository, VehicleBrandWriteRepository>();
        services.AddScoped<IVehicleCategoryReadRepository, VehicleCategoryReadRepository>();
        services.AddScoped<IVehicleCategoryWriteRepository, VehicleCategoryWriteRepository>();
        services.AddScoped<IVehicleImageFileReadRepository, VehicleImageFileReadRepository>();
        services.AddScoped<IVehicleImageFileWriteRepository, VehicleImageFileWriteRepository>();
        services.AddScoped<IVehicleModelReadRepository, VehicleModelReadRepository>();

        // -- SERVICES --
        services.AddScoped<ICompanyService, CompanyService>();
        services.AddScoped<IDriverCredentialFileService, DriverCredentialFileService>();
        services.AddScoped<IDriverService, DriverService>();
        services.AddScoped<IRentalPaymentService, RentalPaymentService>();
        services.AddScoped<IRentalReceiptFileService, RentalReceiptFileService>();
        services.AddScoped<IRentalService, RentalService>();
        services.AddScoped<IVehicleBrandService, VehicleBrandService>();
        services.AddScoped<IVehicleCategoryService, VehicleCategoryService>();
        services.AddScoped<IVehicleImageFileService, VehicleImageFileService>();
        services.AddScoped<IVehicleModelService, VehicleModelService>();
        services.AddScoped<IVehicleService, VehicleService>();
    }
}
