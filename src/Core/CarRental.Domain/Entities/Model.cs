using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities
{
    public class Model : BaseEntity
    {
        public required string Name { get; set; }
        public Features? Features { get; set; }
        public Requirement? Requirement { get; set; }
        public double DailyRate { get; set; }
        public Guid BrandId { get; set; }
        public Brand? Brand { get; set; }
        public ICollection<Vehicle>? Vehicles { get; set; }
    }
}
