using System.Net.Mime;
using System.Text.Json;
using Microsoft.AspNetCore.Diagnostics;

namespace CarRental.API.Extensions;

public static class ConfigureExceptionHandlerExtension
{
    // TODO add logger to this
    public static void ConfigureExceptionHandler<T>(this WebApplication application)
    {
        application.UseExceptionHandler(builder =>
        {
            builder.Run(async context =>
            {
                context.Response.StatusCode = (int)StatusCodes.Status500InternalServerError;
                context.Response.ContentType = MediaTypeNames.Application.Json;

                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                if (contextFeature != null)
                {
                    await context.Response.WriteAsync(
                        JsonSerializer.Serialize(
                            new
                            {
                                StatusCode = context.Response.StatusCode,
                                Message = contextFeature.Error.Message,
                                Title = "Internal Server Error"
                            }
                        )
                    );
                }
            });
        });
    }
}
