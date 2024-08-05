using CarRental.Domain.Entities.Common;
using CarRental.Domain.Enums;

namespace CarRental.Domain.Entities
{
    public class Features : BaseEntity
    {
        public int PassengerCount { get; set; }
        public int SuitcaseCount { get; set; }
        public bool PassengerAirbagAvailable { get; set; }
        public bool AntiLockBrakesAvailable { get; set; }
        public ICollection<FuelType>? FuelTypes { get; set; }
        public GearboxType GearboxType { get; set; }
        public Guid ModelId { get; set; }
        public Model? Model { get; set; }
    }
}
