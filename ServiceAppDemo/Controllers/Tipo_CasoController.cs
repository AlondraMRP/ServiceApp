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
    public class Tipo_CasoController : Controller
    {
        private ServiceAppEntities1 db = new ServiceAppEntities1();

        // GET: Tipo_Caso
        public ActionResult Index()
        {
            return View(db.Tipo_Caso.ToList());
        }

        // GET: Tipo_Caso/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipo_Caso tipo_Caso = db.Tipo_Caso.Find(id);
            if (tipo_Caso == null)
            {
                return HttpNotFound();
            }
            return View(tipo_Caso);
        }

        // GET: Tipo_Caso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tipo_Caso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodTip,DescripTip")] Tipo_Caso tipo_Caso)
        {
            if (ModelState.IsValid)
            {
                db.Tipo_Caso.Add(tipo_Caso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipo_Caso);
        }

        // GET: Tipo_Caso/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipo_Caso tipo_Caso = db.Tipo_Caso.Find(id);
            if (tipo_Caso == null)
            {
                return HttpNotFound();
            }
            return View(tipo_Caso);
        }

        // POST: Tipo_Caso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodTip,DescripTip")] Tipo_Caso tipo_Caso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipo_Caso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipo_Caso);
        }

        // GET: Tipo_Caso/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipo_Caso tipo_Caso = db.Tipo_Caso.Find(id);
            if (tipo_Caso == null)
            {
                return HttpNotFound();
            }
            return View(tipo_Caso);
        }

        // POST: Tipo_Caso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Tipo_Caso tipo_Caso = db.Tipo_Caso.Find(id);
            db.Tipo_Caso.Remove(tipo_Caso);
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
