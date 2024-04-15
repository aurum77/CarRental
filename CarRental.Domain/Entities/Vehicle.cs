using CarRental.Domain.Entities.Common;
using CarRental.Domain.Enums;

namespace CarRental.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        public Guid MakeId { get; set; }
        public VehicleMake? Make { get; set; }
        public Guid ModelId { get; set; }
        public VehicleModel? Model { get; set; }
        public ICollection<VehicleFeature> Features { get; } = new List<VehicleFeature>();
        public ICollection<VehicleImageFile>? Images { get; } = new List<VehicleImageFile>();
        public Guid CategoryId { get; set; }
        public VehicleCategory? Category { get; set; }
        public Guid RentalId { get; set; }
        public Rental? Rental { get; set; }
        public double DailyPrice { get; set; }
        public VehicleStatus Status { get; set; }
    }
}
