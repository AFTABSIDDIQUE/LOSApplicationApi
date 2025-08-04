using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOSApplicationApi.Model
{
    public class Pincode
    {
        [Key]
        public int PincodeId { get; set; }
        public string Pincodes { get; set; }
        public string Area { get; set; }
        [ForeignKey("Cities")]
        public string CityId { get; set; }
        [ForeignKey("States")]
        public string StateId { get; set; }
        [ForeignKey("Countries")]
        public string CountryId { get; set; }
        public byte IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        // Navigation properties
        public Cities Cities { get; set; }
        public States States { get; set; }
        public Countries Countries { get; set; }

    }
}
