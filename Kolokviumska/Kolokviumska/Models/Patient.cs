using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_lab3.Models
{
    public class Patient
    {
        public Patient()
        {
            this.Doctors = new List<Doctor>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Gender { get; set; }
        [Required]
        [RegularExpression(@"[0-9]{5}", ErrorMessage = "Кодот мора да се состои од 5 цифри!")]
        [Display(Name = "Код на пациентот")]
        public string PatientCode { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}