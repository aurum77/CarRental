using CarRental.Domain.Entities;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Persistence.Contexts;

public class CarRentalDbContext(DbContextOptions options)
    : IdentityDbContext<AppUser, AppRole, string>(options)
{
    public DbSet<Company>? Companies { get; set; }
    public DbSet<Driver>? Drivers { get; set; }
    public DbSet<DriverCredentialFile>? DriverCredentialFiles { get; set; }
    public DbSet<Rental>? Rentals { get; set; }
    public DbSet<RentalPayment>? RentalPayments { get; set; }
    public DbSet<RentalReceiptFile>? RentalReceiptFiles { get; set; }
    public DbSet<Vehicle>? Vehicles { get; set; }
    public DbSet<VehicleBrand>? VehicleBrands { get; set; }
    public DbSet<VehicleCategory>? VehicleCategories { get; set; }
    public DbSet<VehicleImageFile>? VehicleImageFiles { get; set; }
    public DbSet<VehicleModel>? VehicleModels { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entries = ChangeTracker.Entries<BaseEntity>();

        foreach (var entry in entries)
        {
            _ = entry.State switch
            {
                EntityState.Added => entry.Entity.CreateDate = DateTime.UtcNow,
                EntityState.Modified => entry.Entity.UpdateDate = DateTime.UtcNow,
                _ => DateTime.UtcNow
            };
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}
