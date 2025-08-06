using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOSApplicationApi.Model
{
    public class Cities
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
        [ForeignKey("States")]
        public int StateId { get; set; }
        public byte IsActive { get; set; }

        public States States { get; set; }
        public ICollection<Pincode> Pincodes { get; set; }
    }
}
