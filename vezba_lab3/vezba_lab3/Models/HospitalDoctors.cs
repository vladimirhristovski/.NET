using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vezba_lab3.Models
{
    public class HospitalDoctors
    {
        public HospitalDoctors()
        {
            this.Hospitals = new List<Hospital>();
        }
        public int HospitalId { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public List<Hospital> Hospitals { get; set; }
    }
}