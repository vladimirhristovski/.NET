using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vezba_lab3.Models
{
    public class Hospital
    {
        public Hospital()
        {
            this.Doctors = new List<Doctor>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ImgURL { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}