using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Domain.Entities;

namespace CarRental.Application.Abstractions;

public interface IVehicleService
{
    Task<Vehicle> GetVehicleById(string id);
}
