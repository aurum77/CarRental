using CarRental.Application.Exceptions.Attributes;
using Serilog;
using System.Reflection;

namespace CarRental.API.Middlewares;

public static class SerilogLoggerMiddleware
{
    public static void AddSerilogLoggerMiddleware(this IServiceCollection services, ILoggingBuilder logging)
    {
        // Configure logger
        var jsonConfiguration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddJsonFile("appsettings.Development.json")
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNET_ENVIRONMENT")}.json", true)
            .Build();

        var logger = new LoggerConfiguration()
            .ReadFrom.Configuration(jsonConfiguration)
            .Filter.ByExcluding(x => x.Exception?.GetType().GetCustomAttribute<CustomException>() != null)
            .CreateLogger();

        // Setup logger
        logging.ClearProviders();
        services.AddSerilog(logger);

        logger.Information("---Starting Web Application---");
    }
}
