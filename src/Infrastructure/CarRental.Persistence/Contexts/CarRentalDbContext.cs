using CarRental.Domain.Entities;
using CarRental.Domain.Entities.Common;
using CarRental.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Persistence.Contexts;

public class CarRentalDbContext : IdentityDbContext<AppUser, AppRole, Guid>
{
    public CarRentalDbContext(DbContextOptions options)
        : base(options) { }

    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Features> Features { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Rental> Rentals { get; set; }
    public DbSet<Requirement> Requirements { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }

    public override int SaveChanges()
    {
        var entries = ChangeTracker.Entries<BaseEntity>();

        foreach (var entry in entries)
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreationDate = DateTime.UtcNow;
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdateDate = DateTime.UtcNow;
                    break;
                default:
                    break;
            }
        }

        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entries = ChangeTracker.Entries<BaseEntity>();

        foreach (var entry in entries)
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreationDate = DateTime.UtcNow;
                    break;
                case EntityState.Modified:
                    entry.Entity.UpdateDate = DateTime.UtcNow;
                    break;
                default:
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}
