using Serilog;

namespace CarRental.WebAPI.Extensions
{
    public static class SerilogLoggerExtension
    {
        public static void AddSerilogLoggerExtension(
            this IServiceCollection services,
            ILoggingBuilder logging
        )
        {
            // Configure logger
            var jsonConfiguration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile("appsettings.Development.json")
                .AddJsonFile(
                    $"appsettings.{Environment.GetEnvironmentVariable("LOG_LEVEL")}.json",
                    true
                )
                .Build();

            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(jsonConfiguration)
                .CreateLogger();

            // Setup logger
            logging.ClearProviders();
            services.AddSerilog(logger);
        }
    }
}
