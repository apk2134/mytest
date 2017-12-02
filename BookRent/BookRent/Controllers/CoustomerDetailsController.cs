using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookRent.Models;

namespace BookRent.Controllers
{
    public class CoustomerDetailsController : Controller
    {
        private RentBookEntities db = new RentBookEntities();

        // GET: CoustomerDetails
        public ActionResult Index()
        {
            var coustomerDetails = db.CoustomerDetails.Include(c => c.Address);
            return View(coustomerDetails.ToList());
        }

        // GET: CoustomerDetails/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoustomerDetail coustomerDetail = db.CoustomerDetails.Find(id);
            if (coustomerDetail == null)
            {
                return HttpNotFound();
            }
            return View(coustomerDetail);
        }

        // GET: CoustomerDetails/Create
        public ActionResult Create()
        {
            ViewBag.AddressId = new SelectList(db.Addresses, "AddressId", "House");
            return View();
        }

        // POST: CoustomerDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CoustomerId,AddressId,Phone,BooksTaken")] CoustomerDetail coustomerDetail)
        {
            if (ModelState.IsValid)
            {
                db.CoustomerDetails.Add(coustomerDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AddressId = new SelectList(db.Addresses, "AddressId", "House", coustomerDetail.AddressId);
            return View(coustomerDetail);
        }

        // GET: CoustomerDetails/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoustomerDetail coustomerDetail = db.CoustomerDetails.Find(id);
            if (coustomerDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.AddressId = new SelectList(db.Addresses, "AddressId", "House", coustomerDetail.AddressId);
            return View(coustomerDetail);
        }

        // POST: CoustomerDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CoustomerId,AddressId,Phone,BooksTaken")] CoustomerDetail coustomerDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coustomerDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AddressId = new SelectList(db.Addresses, "AddressId", "House", coustomerDetail.AddressId);
            return View(coustomerDetail);
        }

        // GET: CoustomerDetails/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CoustomerDetail coustomerDetail = db.CoustomerDetails.Find(id);
            if (coustomerDetail == null)
            {
                return HttpNotFound();
            }
            return View(coustomerDetail);
        }

        // POST: CoustomerDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CoustomerDetail coustomerDetail = db.CoustomerDetails.Find(id);
            db.CoustomerDetails.Remove(coustomerDetail);
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
