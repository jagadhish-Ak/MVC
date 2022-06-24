using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectCrudOperations.Models;

namespace ProjectCrudOperations.Controllers
{
    public class AddSheetsController : Controller
    {
        private DBEntities db = new DBEntities();

        // GET: AddSheets
        public ActionResult Index(AddSheet addsheet)
        {
            db.AddSheets.Add(addsheet);
            db.SaveChanges();
            return View(db.AddSheets.ToList());
        }

        // GET: AddSheets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddSheet addSheet = db.AddSheets.Find(id);
            if (addSheet == null)
            {
                return HttpNotFound();
            }
            return View(addSheet);
        }

        // GET: AddSheets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddSheets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,projectName,hours,approval")] AddSheet addSheet)
        {
            if (ModelState.IsValid)
            {
                db.AddSheets.Add(addSheet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addSheet);
        }

        // GET: AddSheets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddSheet addSheet = db.AddSheets.Find(id);
            if (addSheet == null)
            {
                return HttpNotFound();
            }
            return View(addSheet);
        }

        // POST: AddSheets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,projectName,hours,approval")] AddSheet addSheet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addSheet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addSheet);
        }

        // GET: AddSheets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AddSheet addSheet = db.AddSheets.Find(id);
            if (addSheet == null)
            {
                return HttpNotFound();
            }
            return View(addSheet);
        }

        // POST: AddSheets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AddSheet addSheet = db.AddSheets.Find(id);
            db.AddSheets.Remove(addSheet);
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
