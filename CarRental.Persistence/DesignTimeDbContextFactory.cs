using CarRental.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection.PortableExecutable;

namespace CarRental.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CarRentalDbContext>
    {
        public CarRentalDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<CarRentalDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);

            return new CarRentalDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
