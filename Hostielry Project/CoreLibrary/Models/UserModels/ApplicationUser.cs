using Microsoft.AspNetCore.Identity;

namespace HostelryAPI.APIModels.UserModels
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
