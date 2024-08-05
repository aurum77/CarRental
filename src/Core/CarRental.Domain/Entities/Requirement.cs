using CarRental.Domain.Entities.Common;

namespace CarRental.Domain.Entities
{
    public class Requirement : BaseEntity
    {
        public int MaxJourneyLengthInKm { get; set; }
        public int DriverExperienceInYears { get; set; }
        public int MinDriverAge { get; set; }
        public int MinCreditCardCount { get; set; }
        public Guid ModelId { get; set; }
        public Model? Model { get; set; }
    }
}
