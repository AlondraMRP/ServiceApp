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
    public class quejasController : Controller
    {
        private ServiceAppEntities1 db = new ServiceAppEntities1();

        // GET: quejas
        public ActionResult Index()
        {
            return View(db.quejas.ToList());
        }

        // GET: quejas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            queja queja = db.quejas.Find(id);
            if (queja == null)
            {
                return HttpNotFound();
            }
            return View(queja);
        }

        // GET: quejas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: quejas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,fecha")] queja queja)
        {
            if (ModelState.IsValid)
            {
                db.quejas.Add(queja);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(queja);
        }

        // GET: quejas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            queja queja = db.quejas.Find(id);
            if (queja == null)
            {
                return HttpNotFound();
            }
            return View(queja);
        }

        // POST: quejas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,fecha")] queja queja)
        {
            if (ModelState.IsValid)
            {
                db.Entry(queja).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(queja);
        }

        // GET: quejas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            queja queja = db.quejas.Find(id);
            if (queja == null)
            {
                return HttpNotFound();
            }
            return View(queja);
        }

        // POST: quejas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            queja queja = db.quejas.Find(id);
            db.quejas.Remove(queja);
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
