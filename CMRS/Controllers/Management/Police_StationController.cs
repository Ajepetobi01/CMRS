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
    public class Police_StationController : Controller
    {
        private CmrsModel db = new CmrsModel();

        // GET: Police_Station
        public ActionResult Index()
        {
            return View(db.Police_Station.ToList());
        }

        // GET: Police_Station/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Police_Station police_Station = db.Police_Station.Find(id);
            if (police_Station == null)
            {
                return HttpNotFound();
            }
            return View(police_Station);
        }

        // GET: Police_Station/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Police_Station/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,State,Branch,Contact")] Police_Station police_Station)
        {
            if (ModelState.IsValid)
            {
                db.Police_Station.Add(police_Station);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(police_Station);
        }

        // GET: Police_Station/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Police_Station police_Station = db.Police_Station.Find(id);
            if (police_Station == null)
            {
                return HttpNotFound();
            }
            return View(police_Station);
        }

        // POST: Police_Station/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,State,Branch,Contact")] Police_Station police_Station)
        {
            if (ModelState.IsValid)
            {
                db.Entry(police_Station).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(police_Station);
        }

        // GET: Police_Station/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Police_Station police_Station = db.Police_Station.Find(id);
            if (police_Station == null)
            {
                return HttpNotFound();
            }
            return View(police_Station);
        }

        // POST: Police_Station/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Police_Station police_Station = db.Police_Station.Find(id);
            db.Police_Station.Remove(police_Station);
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
