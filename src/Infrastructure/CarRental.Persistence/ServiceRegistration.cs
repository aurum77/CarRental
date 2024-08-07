using CarRental.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<CarRentalDbContext>(options =>
            {
                options.UseNpgsql(Configuration.ConnectionString);
            });
        }
    }
}
