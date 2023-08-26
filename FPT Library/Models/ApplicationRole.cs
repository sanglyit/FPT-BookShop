using Microsoft.AspNetCore.Identity;

namespace FPT_Library.Models
{
    public class ApplicationRole: IdentityRole
    {
        public string? Descriptions;
    }
}
