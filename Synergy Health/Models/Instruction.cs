using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Channels;

namespace Synergy_Health.Models
{
    public class Instruction
    {
        [Key]
        public int InstructionID { get; set; }
        [Required]
        public string? Notes { get; set; }
        
        public int PatientFileID { get; set; }
        public int DoctorID { get; set; }
    }
}
