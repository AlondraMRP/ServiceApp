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
    public class Rol_OperacionController : Controller
    {
        private ServiceAppEntities1 db = new ServiceAppEntities1();

        // GET: Rol_Operacion
        public ActionResult Index()
        {
            var rol_Operacion = db.Rol_Operacion.Include(r => r.Operacion).Include(r => r.Rol);
            return View(rol_Operacion.ToList());
        }

        // GET: Rol_Operacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rol_Operacion rol_Operacion = db.Rol_Operacion.Find(id);
            if (rol_Operacion == null)
            {
                return HttpNotFound();
            }
            return View(rol_Operacion);
        }

        // GET: Rol_Operacion/Create
        public ActionResult Create()
        {
            ViewBag.idOperacion = new SelectList(db.Operacions, "id", "nombre");
            ViewBag.idrol = new SelectList(db.Rols, "id", "descripcion");
            return View();
        }

        // POST: Rol_Operacion/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idrol,idOperacion")] Rol_Operacion rol_Operacion)
        {
            if (ModelState.IsValid)
            {
                db.Rol_Operacion.Add(rol_Operacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idOperacion = new SelectList(db.Operacions, "id", "nombre", rol_Operacion.idOperacion);
            ViewBag.idrol = new SelectList(db.Rols, "id", "descripcion", rol_Operacion.idrol);
            return View(rol_Operacion);
        }

        // GET: Rol_Operacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rol_Operacion rol_Operacion = db.Rol_Operacion.Find(id);
            if (rol_Operacion == null)
            {
                return HttpNotFound();
            }
            ViewBag.idOperacion = new SelectList(db.Operacions, "id", "nombre", rol_Operacion.idOperacion);
            ViewBag.idrol = new SelectList(db.Rols, "id", "descripcion", rol_Operacion.idrol);
            return View(rol_Operacion);
        }

        // POST: Rol_Operacion/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idrol,idOperacion")] Rol_Operacion rol_Operacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rol_Operacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idOperacion = new SelectList(db.Operacions, "id", "nombre", rol_Operacion.idOperacion);
            ViewBag.idrol = new SelectList(db.Rols, "id", "descripcion", rol_Operacion.idrol);
            return View(rol_Operacion);
        }

        // GET: Rol_Operacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rol_Operacion rol_Operacion = db.Rol_Operacion.Find(id);
            if (rol_Operacion == null)
            {
                return HttpNotFound();
            }
            return View(rol_Operacion);
        }

        // POST: Rol_Operacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rol_Operacion rol_Operacion = db.Rol_Operacion.Find(id);
            db.Rol_Operacion.Remove(rol_Operacion);
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
