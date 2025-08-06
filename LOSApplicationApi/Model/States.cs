using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOSApplicationApi.Model
{
    public class States
    {
        [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }
        [ForeignKey("Countries")]
        public int CountryId { get; set; }
        public byte IsActive { get; set; }
        // Navigation property
        public Countries Country { get; set; }
        public ICollection<Cities> City { get; set; }
        public ICollection<Pincode> Pincodes { get; set; }
    }
}
