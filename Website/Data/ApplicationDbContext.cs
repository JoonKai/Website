using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Website.Models;

namespace Website.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Website.Models.Blog> Blog { get; set; }
        public DbSet<Website.Models.Post> Post { get; set; }
    }
}
