using Microsoft.AspNetCore.Identity;

namespace AuthApi.Data.Models
{
    public class ApplicationRole : IdentityRole
    {
        public string? Description { get; set; }
    }
}