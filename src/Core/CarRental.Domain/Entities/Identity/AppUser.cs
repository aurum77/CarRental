using Microsoft.AspNetCore.Identity;

namespace CarRental.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<Guid>
    {
        public required string NameSurname { get; set; }
        public ICollection<Rental>? Rentals { get; set; }
    }
}
