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
        public string StateId { get; set; }
        public byte IsActive { get; set; }
    }
}
