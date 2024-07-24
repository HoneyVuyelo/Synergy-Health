using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Channels;

namespace Synergy_Health.Models
{
    public class HospitalInfo
    {
        [Key]
        public int HospitalID { get; set; }
        [Required]
        public string? HospitalName { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Adress { get; set; }
        [Phone]
   
        public int Telephone { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? OperationHours { get; set; }
 
    }
}
