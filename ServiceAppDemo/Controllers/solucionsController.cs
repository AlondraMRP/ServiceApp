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
    public class solucionsController : Controller
    {
        private ServiceAppEntities1 db = new ServiceAppEntities1();

        // GET: solucions
        public ActionResult Index()
        {
            var solucions = db.solucions.Include(s => s.caso);
            return View(solucions.ToList());
        }

        // GET: solucions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            solucion solucion = db.solucions.Find(id);
            if (solucion == null)
            {
                return HttpNotFound();
            }
            return View(solucion);
        }

        // GET: solucions/Create
        public ActionResult Create()
        {
            ViewBag.id_caso = new SelectList(db.casoes, "id", "codigo_usuario");
            ViewBag.id = new SelectList(db.casoes, "id","id");
            return View();
        }

        // POST: solucions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,id_caso,ComenSolu")] solucion solucion)
        {
            if (ModelState.IsValid)
            {
                db.solucions.Add(solucion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_caso = new SelectList(db.casoes, "id", "codigo_usuario", solucion.id_caso);
            ViewBag.id = new SelectList(db.casoes, "id", "id");
            return View(solucion);
        }

        // GET: solucions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            solucion solucion = db.solucions.Find(id);
            if (solucion == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_caso = new SelectList(db.casoes, "id", "codigo_usuario", solucion.id_caso);
            ViewBag.id = new SelectList(db.casoes, "id", "id");
            return View(solucion);
        }

        // POST: solucions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,id_caso,ComenSolu")] solucion solucion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(solucion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_caso = new SelectList(db.casoes, "id", "codigo_usuario", solucion.id_caso); 
            ViewBag.id = new SelectList(db.casoes, "id", "id");           
            return View(solucion);
        }

        // GET: solucions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            solucion solucion = db.solucions.Find(id);
            if (solucion == null)
            {
                return HttpNotFound();
            }
            return View(solucion);
        }

        // POST: solucions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            solucion solucion = db.solucions.Find(id);
            db.solucions.Remove(solucion);
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
