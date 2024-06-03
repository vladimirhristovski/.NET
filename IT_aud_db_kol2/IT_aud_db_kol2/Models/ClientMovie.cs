using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT_aud_db_kol2.Models
{
    public class ClientMovie
    {
        public ClientMovie()
        {
            clients = new List<Client>();
        }
        public int MovieId { get; set; }
        public int ClientId { get; set; }
        public Movie movie { get; set; }
        public List<Client> clients { get; set; }
    }
}