using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vezba_lab3.Models
{
    public class Doctor
    {
        public Doctor()
        {
            this.Patients = new List<Patient>();
            this.Hospitals = new List<Hospital>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public List<Hospital> Hospitals { get; set; }
    }
}