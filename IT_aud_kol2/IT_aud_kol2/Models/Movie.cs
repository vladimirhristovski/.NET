using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_aud_kol2.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Download URL:")]
        public string DownloadURL { get; set; }
        [Display(Name = "The image URL:")]
        public string ImageURL { get; set; }
        public float Rating { get; set; }
    }
}