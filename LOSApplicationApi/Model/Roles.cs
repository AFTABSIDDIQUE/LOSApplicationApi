using System.ComponentModel.DataAnnotations;

namespace LOSApplicationApi.Model
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public byte IsActive { get; set; }
    }
}
