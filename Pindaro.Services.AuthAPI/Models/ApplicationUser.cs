using Microsoft.AspNetCore.Identity;

namespace Pindaro.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
