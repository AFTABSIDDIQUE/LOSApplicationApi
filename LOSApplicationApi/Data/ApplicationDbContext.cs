using LOSApplicationApi.Model;
using Microsoft.EntityFrameworkCore;

namespace LOSApplicationApi.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Users> User { get; set; }
        public DbSet<Roles> Role { get; set; }
    }
}
