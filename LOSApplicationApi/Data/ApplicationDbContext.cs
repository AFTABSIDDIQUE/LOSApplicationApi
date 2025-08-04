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
        public DbSet<UserRoles> UserRole { get; set; }
        public DbSet<Cities> City { get; set; }
        public DbSet<States> State { get; set; }
        public DbSet<Countries> Country { get; set; }
        public DbSet<Pincode> Pincode { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<OccupationType> OccupationTypes { get;set; }
        public DbSet<ReajectionReason> ReajectionReasons { get; set; }

    }
}
