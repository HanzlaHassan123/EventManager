using Microsoft.AspNetCore.Identity;

namespace EventManager.Models.Domain
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }

        
    }
}
