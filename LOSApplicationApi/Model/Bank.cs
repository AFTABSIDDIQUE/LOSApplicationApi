using System.ComponentModel.DataAnnotations;

namespace LOSApplicationApi.Model
{
    public class Bank
    {
        [Key]
        public int BankId { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string IFSCCode { get; set; }
        public int BranchId { get; set; }
        public string Address { get; set; }
        public byte IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte IsDeleted { get; set; }
        // Navigation property
        public Branch Branch { get; set; }

    }
}
