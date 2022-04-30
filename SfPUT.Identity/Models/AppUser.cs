using Microsoft.AspNetCore.Identity;

namespace SfPUT.Identity.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }
    }
}
