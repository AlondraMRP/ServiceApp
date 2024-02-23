using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ServiceAppDemo.Models;

namespace ServiceAppDemo.Controllers
{
    public class RelevanciasController : Controller
    {
        private ServiceAppEntities1 db = new ServiceAppEntities1();

        // GET: Relevancias
        public ActionResult Index()
        {
            return View(db.Relevancias.ToList());
        }

        // GET: Relevancias/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relevancia relevancia = db.Relevancias.Find(id);
            if (relevancia == null)
            {
                return HttpNotFound();
            }
            return View(relevancia);
        }

        // GET: Relevancias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Relevancias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodRel,DescripRel")] Relevancia relevancia)
        {
            if (ModelState.IsValid)
            {
                db.Relevancias.Add(relevancia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relevancia);
        }

        // GET: Relevancias/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relevancia relevancia = db.Relevancias.Find(id);
            if (relevancia == null)
            {
                return HttpNotFound();
            }
            return View(relevancia);
        }

        // POST: Relevancias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodRel,DescripRel")] Relevancia relevancia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relevancia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relevancia);
        }

        // GET: Relevancias/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relevancia relevancia = db.Relevancias.Find(id);
            if (relevancia == null)
            {
                return HttpNotFound();
            }
            return View(relevancia);
        }

        // POST: Relevancias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Relevancia relevancia = db.Relevancias.Find(id);
            db.Relevancias.Remove(relevancia);
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
