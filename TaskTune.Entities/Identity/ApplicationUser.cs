using Microsoft.AspNetCore.Identity;

namespace TaskTune.Entities.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
    }
}
