using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OkZim.Models;

namespace OkZim.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OkZim.Models.Product> Product { get; set; } = default!;
        public DbSet<OkZim.Models.Cart> Cart { get; set; } = default!;
    }
}
