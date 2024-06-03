using IT_aud_kol2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace IT_aud_kol2.Controllers
{
    public class MoviesController : Controller
    {
        public static List<Movie> moviesList = new List<Movie>()
        {
        new Movie() { Name = "Shrek!", Rating = 5, DownloadURL = "/", ImageURL = @"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRKZR3LgB_kPu-elRBgLF1Am5ciHPV0gdJiQCu5yJRSPQ&s" }
        };
        public static List<Client> clients = new List<Client>()
        {
            //new Client(){ Name = "Aleksandar S.", MovieCard = "1234", Address = "bul. Partizanski odredi 19", Phone = "076555444", Age = 29},
            //new Client(){ Name = "Petko Petkovski", MovieCard = "1111", Address = "Leninova 3", Phone = "075555333", Age = 17},
            //new Client(){ Name = "Trajko Trajkovski", MovieCard = "2222", Address = "Varsavska 4", Phone = "072222333", Age = 19},
        };
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowMovie(int id)
        {
            MovieRentals model = new MovieRentals();
            model.clients = clients;
            model.movie = moviesList.ElementAt(id);
            return View(model);
        }

        public ActionResult ShowClient(int id)
        {
            return View(clients.ElementAt(id));
        }

        public ActionResult NewMovie()
        {
            Movie model = new Movie();
            return View(model);
        }

        [HttpPost]
        public ActionResult InsertNewMovie(Movie model)
        {
            if (!ModelState.IsValid)
            {
                return View("NewMovie", model);
            }

            moviesList.Add(model);
            return View("GetAllMovies", moviesList);
        }

        public ActionResult GetAllMovies()
        {
            return View(moviesList);
        }

        public ActionResult EditMovie(int id)
        {
            var model = moviesList.ElementAt(id);
            model.Id = id;
            return View(model);
        }

        [HttpPost]
        public ActionResult EditMovie(Movie model)
        {
            if (!ModelState.IsValid)
            {
                return View("EditMovie", model);
            }

            var forUpdate = moviesList.ElementAt(model.Id);
            forUpdate.ImageURL = model.ImageURL;
            forUpdate.Name = model.Name;
            forUpdate.DownloadURL = model.DownloadURL;
            forUpdate.Rating = model.Rating;

            //return View("GetAllMovies", moviesList);
            return RedirectToAction("GetAllMovies");
        }

        public ActionResult DeleteMovie(int id)
        {
            if (id < moviesList.Count)
            {
                moviesList.RemoveAt(id);
            }

            return View("GetAllMovies", moviesList);
        }

        public ActionResult NewClient()
        {
            Client client = new Client();
            return View(client);
        }

        [HttpPost]
        public ActionResult InsertNewClient(Client model)
        {
            if (!ModelState.IsValid)
            {
                return View("NewClient", model);
            }

            clients.Add(model);
            return View("GetAllMovies", moviesList);
        }
    }
}