using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace Infinite.Healthcare.MVC.Models
{
    public class PatientViewModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Please enter the patient name")]
        public string PatientName { get; set; }
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "Please enter your city")]
        public string Patientcity { get; set; }

        [Required(ErrorMessage = "Please enter your Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please enter your Age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter valid emailid")]
        public string email { get; set; }

      
        public int UserId { get; set; }



    }
}
