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
    public class MissingItemsController : Controller
    {
        private CmrsModel db = new CmrsModel();

        // GET: MissingItems
        public ActionResult Index()
        {
            return View(db.MissingItems.ToList());
        }

        // GET: MissingItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissingItem missingItem = db.MissingItems.Find(id);
            if (missingItem == null)
            {
                return HttpNotFound();
            }
            return View(missingItem);
        }

        // GET: MissingItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MissingItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NameOfRep,NameOfOwner,Description,LastSeenLoc,LastSeenDate,PoliceStation,InvestigatingOff,ReportDate,CaseStatus")] MissingItem missingItem)
        {
            if (ModelState.IsValid)
            {
                db.MissingItems.Add(missingItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(missingItem);
        }

        // GET: MissingItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissingItem missingItem = db.MissingItems.Find(id);
            if (missingItem == null)
            {
                return HttpNotFound();
            }
            return View(missingItem);
        }

        // POST: MissingItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NameOfRep,NameOfOwner,Description,LastSeenLoc,LastSeenDate,PoliceStation,InvestigatingOff,ReportDate,CaseStatus")] MissingItem missingItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(missingItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(missingItem);
        }

        // GET: MissingItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissingItem missingItem = db.MissingItems.Find(id);
            if (missingItem == null)
            {
                return HttpNotFound();
            }
            return View(missingItem);
        }

        // POST: MissingItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MissingItem missingItem = db.MissingItems.Find(id);
            db.MissingItems.Remove(missingItem);
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
