using CarRental.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CarRental.API.Extensions;

public static class EnsureDataabaseCreatedExtension
{
    public static void EnsureDatabaseCreated(this IApplicationBuilder app, CancellationToken cancellationToken = default)
    {
        using var scope = app.ApplicationServices.GetService<IServiceScopeFactory>()!.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<CarRentalDbContext>();

        if (context.Database.GetPendingMigrations().Any())
        {
            context.Database.Migrate();
        }
    }
}
