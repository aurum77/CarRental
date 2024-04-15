using CarRental.Domain.Entities;
using CarRental.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Persistence.Contexts
{
    public class CarRentalDbContext(DbContextOptions options) : IdentityDbContext<AppUser, AppRole, string>(options)
    {
        public DbSet<Vehicle>? Vehicles { get; set; }
        public DbSet<VehicleCategory>? VehicleCategories { get; set; }
        public DbSet<VehicleFeature>? VehicleFeatures { get; set; }
        public DbSet<VehicleImageFile>? VehicleImageFiles { get; set; }
        public DbSet<VehicleMake>? VehicleMakes { get; set; }
        public DbSet<VehicleModel>? VehicleModels { get; set; }
        public DbSet<Domain.Entities.File>? Files { get; set; }
        public DbSet<Rental>? Rentals { get; set; }
        public DbSet<RentalPayment>? RentalPayments { get; set; }
    }
}
