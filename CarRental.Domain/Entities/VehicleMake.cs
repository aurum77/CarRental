using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities
{
    public class VehicleMake : BaseEntity
    {
        public string? BrandName { get; set; }
        public ICollection<VehicleModel> Models { get; } = new List<VehicleModel>();
    }
}
