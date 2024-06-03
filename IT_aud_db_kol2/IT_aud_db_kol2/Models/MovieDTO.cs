using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_aud_db_kol2.Models
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DownloadURL { get; set; }
        public string ImageURL { get; set; }
        public float Rating { get; set; }
    }
}