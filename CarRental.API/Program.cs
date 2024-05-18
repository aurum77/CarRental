using CarRental.API.Extensions;
using CarRental.API.Middlewares;
using CarRental.Application;
using CarRental.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Configure logger
builder.Services.AddSerilogLoggerMiddleware(builder.Logging);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices();

builder.Services.AddExceptionHandler<CustomExceptionHandlerMiddleware>();
builder.Services.AddProblemDetails();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.EnsureDatabaseCreated();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
