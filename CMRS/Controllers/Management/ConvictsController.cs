using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CMRS.Models;
using PagedList;

namespace CMRS.Controllers.Management

{
    public class ConvictsController : Controller
    {
        private CmrsModel db = new CmrsModel();

        // GET: Convicts
        public ActionResult Index(string option, string search, int? pageNumber)
        {

            if (option == "Name")
            {
                return View(db.Convicts.Where(x => x.ConvictName.Contains(search) || search == null).ToList().ToPagedList(pageNumber ?? 1, 6));
            }
            else if
                (option == "Offense")
            {
                return View(db.Convicts.Where(x => x.Offense.Contains(search) || search == null).ToList().ToPagedList(pageNumber ?? 1, 6));
            }
            else
            {
                return View(db.Convicts.Where(x => x.ConvictName.StartsWith(search) || search == null).ToList().ToPagedList(pageNumber ?? 1, 6));
            }
        }

        // GET: Convicts/Details/5
        
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Convict convict = db.Convicts.Find(id);

           byte[] photodisp = convict.Image;

            return File(photodisp, "Details");


            if (convict == null)
            {
                return HttpNotFound();
            }
   

            return View(convict);
        }

        // GET: Convicts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Convicts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ConvictName,ConvictAge,Offense,CaseStatus,JailTerm,StartDate,EndDate,PrisonName,Image")] Convict convict, HttpPostedFileBase uploadFile)
        {

            if (ModelState.IsValid)
            {
           if (uploadFile != null && uploadFile.ContentLength > 0)
                {
                    convict.Image = new byte[uploadFile.ContentLength];
                    uploadFile.InputStream.Read(convict.Image, 0, uploadFile.ContentLength);
                }
                
   
                    db.Convicts.Add(convict);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

            
                
                    return View(convict);
                

            }
        
    

        // GET: Convicts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Convict convict = db.Convicts.Find(id);
            if (convict == null)
            {
                return HttpNotFound();
            }
            return View(convict);
        }

        // POST: Convicts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ConvictName,ConvictAge,Offense,CaseStatus,JailTerm,StartDate,EndDate,PrisonName,Image")] Convict convict, HttpPostedFileBase uploadFile)
        {
            if (ModelState.IsValid)

            {
                if (uploadFile != null && uploadFile.ContentLength > 0)
                {
                    convict.Image = new byte[uploadFile.ContentLength];
                    uploadFile.InputStream.Read(convict.Image, 0, uploadFile.ContentLength);
                }

                db.Entry(convict).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(convict);
        }

        // This method displays convicts details in full
        public ActionResult Fulldet(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Convict convict = db.Convicts.Find(id);
            if (convict == null)
            {
                return HttpNotFound();
            }
            return View(convict);
        }

        //This method prints the convict details

        public ActionResult PrintReport(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Convict convict = db.Convicts.Find(id);
            if (convict == null)
            {
                return HttpNotFound();
            }

            return View(convict);

        }
        // GET: Convicts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Convict convict = db.Convicts.Find(id);
            if (convict == null)
            {
                return HttpNotFound();
            }
            return View(convict);
        }

        // POST: Convicts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Convict convict = db.Convicts.Find(id);
            db.Convicts.Remove(convict);
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
