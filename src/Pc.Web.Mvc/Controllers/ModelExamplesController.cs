using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pc.Web.Mvc.Models;

namespace Pc.Web.Mvc.Controllers
{
    public class ModelExamplesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ModelExamples
        public ActionResult Index()
        {
            return View(db.ModelExamples.ToList());
        }

        // GET: ModelExamples/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelExample modelExample = db.ModelExamples.Find(id);
            if (modelExample == null)
            {
                return HttpNotFound();
            }
            return View(modelExample);
        }

        // GET: ModelExamples/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ModelExamples/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Number,Name")] ModelExample modelExample)
        {
            if (ModelState.IsValid)
            {
                db.ModelExamples.Add(modelExample);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modelExample);
        }

        // GET: ModelExamples/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelExample modelExample = db.ModelExamples.Find(id);
            if (modelExample == null)
            {
                return HttpNotFound();
            }
            return View(modelExample);
        }

        // POST: ModelExamples/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Number,Name")] ModelExample modelExample)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modelExample).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modelExample);
        }

        // GET: ModelExamples/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelExample modelExample = db.ModelExamples.Find(id);
            if (modelExample == null)
            {
                return HttpNotFound();
            }
            return View(modelExample);
        }

        // POST: ModelExamples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ModelExample modelExample = db.ModelExamples.Find(id);
            db.ModelExamples.Remove(modelExample);
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
