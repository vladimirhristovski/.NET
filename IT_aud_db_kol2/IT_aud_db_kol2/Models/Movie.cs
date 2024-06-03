using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_aud_db_kol2.Models
{
    public class Movie
    {
        public Movie()
        {
            clients = new List<Client>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Download URL:")]
        public string DownloadURL { get; set; }
        [Display(Name = "The image URL:")]
        public string ImageURL { get; set; }
        public float Rating { get; set; }
        public virtual ICollection<Client> clients { get; set; }
    }
}