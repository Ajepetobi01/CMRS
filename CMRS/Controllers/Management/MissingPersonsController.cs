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
    public class MissingPersonsController : Controller
    {
        private CmrsModel db = new CmrsModel();

        // GET: MissingPersons
        public ActionResult Index()
        {
            return View(db.MissingPersons.ToList());
        }

        // GET: MissingPersons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissingPerson missingPerson = db.MissingPersons.Find(id);
            if (missingPerson == null)
            {
                return HttpNotFound();
            }
            return View(missingPerson);
        }

        // GET: MissingPersons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MissingPersons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NameOfReporter,NameOfMisPer,GenderOfMisPer,AgeOfMisPer,LastSeenDate,PocPer,AddOfMisPer,DetOfMisPer,SuspectValue,SuspectName,SuspectDetails,PoliceStation,InvestigatingOff,ReportDate,CaseStatus")] MissingPerson missingPerson)
        {
            if (ModelState.IsValid)
            {
                db.MissingPersons.Add(missingPerson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(missingPerson);
        }

        // GET: MissingPersons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissingPerson missingPerson = db.MissingPersons.Find(id);
            if (missingPerson == null)
            {
                return HttpNotFound();
            }
            return View(missingPerson);
        }

        // POST: MissingPersons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NameOfReporter,NameOfMisPer,GenderOfMisPer,AgeOfMisPer,LastSeenDate,PocPer,AddOfMisPer,DetOfMisPer,SuspectValue,SuspectName,SuspectDetails,PoliceStation,InvestigatingOff,ReportDate,CaseStatus")] MissingPerson missingPerson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(missingPerson).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(missingPerson);
        }

        // GET: MissingPersons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissingPerson missingPerson = db.MissingPersons.Find(id);
            if (missingPerson == null)
            {
                return HttpNotFound();
            }
            return View(missingPerson);
        }

        // POST: MissingPersons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MissingPerson missingPerson = db.MissingPersons.Find(id);
            db.MissingPersons.Remove(missingPerson);
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
