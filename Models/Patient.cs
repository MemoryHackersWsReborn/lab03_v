using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab03_v.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Името е задолжително")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Код на пациентот")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Кодот мора да биде точно 5 цифри.")]
        public int PatientCode { get; set; }

        public string Gender { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}