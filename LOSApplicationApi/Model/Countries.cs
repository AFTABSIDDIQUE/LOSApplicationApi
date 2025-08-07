using System.ComponentModel.DataAnnotations;

namespace LOSApplicationApi.Model
{
    public class Countries
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public byte IsActive { get; set; }

        public ICollection<States> States { get; set; }
        public ICollection<Pincode> Pincodes { get; set; }
    }
}
