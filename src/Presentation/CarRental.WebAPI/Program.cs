using CarRental.Persistence;
using CarRental.WebAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSerilogLoggerExtension(builder.Logging);
builder.Services.AddPersistenceServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
