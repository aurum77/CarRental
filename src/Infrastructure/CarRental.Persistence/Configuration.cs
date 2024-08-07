using Microsoft.Extensions.Configuration;

namespace CarRental.Persistence;

internal static class Configuration
{
    public static string ConnectionString
    {
        get
        {
            ConfigurationManager configurationManager = new();

            try
            {
                configurationManager.SetBasePath(
                    Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "../../Presentation/CarRental.WebAPI"
                    )
                );

                configurationManager.AddJsonFile("appsettings.Production.json");
            }
            catch
            {
                configurationManager.AddJsonFile("appsettings.Development.json");
            }

            return configurationManager.GetConnectionString("PostgreSQL")!;
        }
    }
}
