using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CMRS.Models;

namespace CMRS.Controllers.Management
{
    public class MissingVehiclesController : Controller
    {
        private CmrsModel db = new CmrsModel();

        // GET: MissingVehicles
        public ActionResult Index()
        {
            return View(db.MissingVehicles.ToList());
        }

        // GET: MissingVehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissingVehicle missingVehicle = db.MissingVehicles.Find(id);
            if (missingVehicle == null)
            {
                return HttpNotFound();
            }
            return View(missingVehicle);
        }

        // GET: MissingVehicles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MissingVehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NameOfRep,VehicleType,NameOfOwner,NameOfVehicle,RegNumber,ChasisNumb,Color,LastSeenDate,LastSeenLoc,Description,PoliceStation,InvestigationOff,ReportDate,CaseStatus")] MissingVehicle missingVehicle)
        {
            if (ModelState.IsValid)
            {
                db.MissingVehicles.Add(missingVehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(missingVehicle);
        }

        // GET: MissingVehicles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissingVehicle missingVehicle = db.MissingVehicles.Find(id);
            if (missingVehicle == null)
            {
                return HttpNotFound();
            }
            return View(missingVehicle);
        }

        // POST: MissingVehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NameOfRep,VehicleType,NameOfOwner,NameOfVehicle,RegNumber,ChasisNumb,Color,LastSeenDate,LastSeenLoc,Description,PoliceStation,InvestigationOff,ReportDate,CaseStatus")] MissingVehicle missingVehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(missingVehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(missingVehicle);
        }

        // GET: MissingVehicles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissingVehicle missingVehicle = db.MissingVehicles.Find(id);
            if (missingVehicle == null)
            {
                return HttpNotFound();
            }
            return View(missingVehicle);
        }

        // POST: MissingVehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MissingVehicle missingVehicle = db.MissingVehicles.Find(id);
            db.MissingVehicles.Remove(missingVehicle);
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
    }
}
