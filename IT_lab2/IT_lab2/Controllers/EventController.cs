using IT_lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace IT_lab2.Controllers
{
    public class EventController : Controller
    {
        private static List<EventModel> events = new List<EventModel>()
        {
            new EventModel(){Id = 1, Name ="Vladimir", Location="Skopje"}
        };
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowEvent(int id)
        {
            return View(events.ElementAt(id));
        }

        public ActionResult GetAllEvents()
        {
            return View(events);
        }

        public ActionResult EditEvent(int id)
        {
            var model = events.ElementAt(id);
            
            return View(model);
        }


        [HttpPost]
        public ActionResult EditEvent(EventModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("EditEvent", model);
            }

            var forUpdate = events.ElementAt(model.Id);
            forUpdate.Name = model.Name;
            forUpdate.Location = model.Location;

            //return View("GetAllMovies", moviesList);
            return RedirectToAction("GetAllEvents");
        }

        public ActionResult NewEvent()
        {
            EventModel model = new EventModel();

            return View(model);
        }


        [HttpPost]
        public ActionResult NewEvent(EventModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("NewEvent", model);
            }

            int last = events.Last().Id;
            model.Id = last+1;
            events.Add(model);

            //return View("GetAllMovies", moviesList);
            return RedirectToAction("GetAllEvents");
        }

        public ActionResult DeleteEvent(int id)
        {
            if(id < events.Count)
            {
                events.RemoveAt(id);
            }
            return View("GetAllEvents", events);
        }
    }
}