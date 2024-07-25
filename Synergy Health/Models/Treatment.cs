
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Channels;

namespace Synergy_Health.Models
{
    public class Treatment
    {
        [Key]
        public int TreatmentID { get; set; }
        [Required]
        public string? TreatmentName { get; set; }
        [Required]
        public string? TreatmentType { get; set; }
        [Required]
        public string? Consummbles { get; set; }

    }
}
