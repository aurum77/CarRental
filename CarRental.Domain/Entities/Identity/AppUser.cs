using Microsoft.AspNetCore.Identity;

namespace CarRental.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<string>
    {
        [PersonalData]
        public string? Name { get; set; }

        [PersonalData]
        public string? Surname { get; set; }

        [PersonalData]
        public string? IdNumber { get; set; }

        [PersonalData]
        public DateTime DateOfBirth { get; set; }
    }
}
