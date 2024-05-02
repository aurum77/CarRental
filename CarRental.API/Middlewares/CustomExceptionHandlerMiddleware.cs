using System.Net;
using System.Net.Mime;
using System.Text.Json;
using CarRental.Application.Exceptions;
using Microsoft.AspNetCore.Diagnostics;

namespace CarRental.API.Middlewares;

public class CustomExceptionHandlerMiddleware : IExceptionHandler
{
    // TODO add logger to this
    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken
    )
    {
        string? message = null;
        httpContext.Response.StatusCode = (int)StatusCodes.Status500InternalServerError;
        httpContext.Response.ContentType = MediaTypeNames.Application.Json;

        switch (exception)
        {
            case NotImplementedException:
                httpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                message = "Not implemented";
                break;
            case NotFoundException:
                httpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
                message = exception.Message;
                break;
            default:
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                message = "Internal Server Error";
                break;
        }

        await httpContext.Response.WriteAsync(
            JsonSerializer.Serialize(
                new
                {
                    StatusCode = httpContext.Response.StatusCode,
                    Message = message != null ? message : exception.Message
                }
            )
        );

        return true;
    }
}
