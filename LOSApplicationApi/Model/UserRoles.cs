using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOSApplicationApi.Model
{
    public class UserRoles
    {
        [Key]
        public int UserRoleId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        [ForeignKey("Occupation")]
        public int OccupationId { get; set; } // Assuming this is a foreign key to an Occupation table
        [ForeignKey("Department")]
        public int DepartmentId { get; set; } // Assuming this is a foreign key to a Department table
        public DateTime AssignedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte IsDeleted { get; set; }
        // Navigation properties
        public Users User { get; set; }
        public Roles Role { get; set; }
        public OccupationType Occupation { get; set; } // Assuming this is a class representing an Occupation
        public Department Department { get; set; } // Assuming this is a class representing a Department
    }
}
