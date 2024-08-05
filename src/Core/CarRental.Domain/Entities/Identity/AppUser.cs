using Microsoft.AspNetCore.Identity;

namespace CarRental.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<Guid>
    {
        public ICollection<Rental>? Rentals { get; set; }
    }
}
