using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IT_lab3.Models;
using Microsoft.Ajax.Utilities;

namespace IT_lab3.Controllers
{
    public class DoctorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Doctors
        public ActionResult Index()
        {
            return View(db.Doctors.ToList());
        }

        // GET: Doctors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // GET: Doctors/Create
        public ActionResult Create()
        {
            Doctor model = new Doctor();
            model.Hospitals = db.Hospitals.ToList();
            return View(model);
        }

        // POST: Doctors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,HID")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                var hospital = db.Hospitals.Find(doctor.HID);
                doctor.Hospital = hospital;
                db.Doctors.Add(doctor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctor);
        }

        // GET: Doctors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            doctor.Hospitals = db.Hospitals.ToList();
            return View(doctor);
        }

        // POST: Doctors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,HID")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                var d = db.Doctors.Find(doctor.Id);
                var hospital = db.Hospitals.Find(doctor.HID);
                d.Hospital = hospital;
                d.Name = doctor.Name;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctor);
        }

        // GET: Doctors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // POST: Doctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Doctor doctor = db.Doctors.Find(id);
            db.Patients.ToList().ForEach(p =>
            {
                if (p.Doctors.Contains(doctor))
                {
                    p.Doctors.Remove(doctor);
                }
            });
            db.Doctors.Remove(doctor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult AddPatient(int id)
        {
            var model = db.Doctors.Find(id);
            model.All_Patients = db.Patients.ToList();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddPatientValidation(Doctor model)
        {
            var doctor = db.Doctors.Find(model.Id);
            var patient = db.Patients.Find(model.PID);
            doctor.Patients.Add(patient);
            patient.Doctors.Add(doctor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
