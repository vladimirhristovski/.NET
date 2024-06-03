using IT_lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kolokviumska.Models
{
    public class DoctorPatients
    {
        public DoctorPatients()
        {
            Patients = new List<Patient>();
        }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public Doctor Doctor { get; set; }
        public List<Patient> Patients { get; set; }
    }
}