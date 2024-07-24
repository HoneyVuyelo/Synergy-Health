using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Channels;

namespace Synergy_Health.Models
{
    public class Vital
    {
        [Key]
        public int VitalID { get; set; }
        [Required]
        public decimal Weight  { get; set; }
        [Required]
        public decimal Temperature { get; set; }
        [Required]
        public decimal BloodPressure { get; set; }
        [Required]
        public decimal HeartRate { get; set; }

        [Required]
        public DateOnly Date { get; set; }
        public decimal Notes { get; set; }
        
    }
}
