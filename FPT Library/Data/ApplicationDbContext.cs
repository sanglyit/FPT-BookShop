using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FPT_Library.Models;

namespace FPT_Library.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FPT_Library.Models.ApplicationRole> ApplicationRole { get; set; } = default!;
        public DbSet<FPT_Library.Models.Books> Books { get; set; } = default!;
    }
}