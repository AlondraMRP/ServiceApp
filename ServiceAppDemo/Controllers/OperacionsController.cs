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
    public class OperacionsController : Controller
    {
        private ServiceAppEntities1 db = new ServiceAppEntities1();

        // GET: Operacions
        public ActionResult Index()
        {
            var operacions = db.Operacions.Include(o => o.modulo);
            return View(operacions.ToList());
        }

        // GET: Operacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operacion operacion = db.Operacions.Find(id);
            if (operacion == null)
            {
                return HttpNotFound();
            }
            return View(operacion);
        }

        // GET: Operacions/Create
        public ActionResult Create()
        {
            ViewBag.idModulo = new SelectList(db.moduloes, "id", "nombre");
            return View();
        }

        // POST: Operacions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,idModulo")] Operacion operacion)
        {
            if (ModelState.IsValid)
            {
                db.Operacions.Add(operacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idModulo = new SelectList(db.moduloes, "id", "nombre", operacion.idModulo);
            return View(operacion);
        }

        // GET: Operacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operacion operacion = db.Operacions.Find(id);
            if (operacion == null)
            {
                return HttpNotFound();
            }
            ViewBag.idModulo = new SelectList(db.moduloes, "id", "nombre", operacion.idModulo);
            return View(operacion);
        }

        // POST: Operacions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,idModulo")] Operacion operacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(operacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idModulo = new SelectList(db.moduloes, "id", "nombre", operacion.idModulo);
            return View(operacion);
        }

        // GET: Operacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Operacion operacion = db.Operacions.Find(id);
            if (operacion == null)
            {
                return HttpNotFound();
            }
            return View(operacion);
        }

        // POST: Operacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Operacion operacion = db.Operacions.Find(id);
            db.Operacions.Remove(operacion);
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
