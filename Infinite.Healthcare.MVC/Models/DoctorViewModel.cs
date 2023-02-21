using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Infinite.Healthcare.MVC.Models
{
    public class DoctorViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter Doctor Name")]
        [Display(Name = "Doctor Name")]
        [StringLength(40, MinimumLength = 4, ErrorMessage = "Name Should be atleast 4 characters")]
        public string DoctorName { get; set; }
        public int Experience { get; set; }
        [Required(ErrorMessage = "Please enter age")]
        public int age { get; set; }

        [Required(ErrorMessage = "Please enter Qualification")]
        public string Qualification { get; set; }

        

        
        public string SpecializationName { get; set; }
    }
}
