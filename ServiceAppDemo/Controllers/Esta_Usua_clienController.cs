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
    public class Esta_Usua_clienController : Controller
    {
        private ServiceAppEntities1 db = new ServiceAppEntities1();

        // GET: Esta_Usua_clien
        public ActionResult Index()
        {
            return View(db.Esta_Usua_clien.ToList());
        }

        // GET: Esta_Usua_clien/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Esta_Usua_clien esta_Usua_clien = db.Esta_Usua_clien.Find(id);
            if (esta_Usua_clien == null)
            {
                return HttpNotFound();
            }
            return View(esta_Usua_clien);
        }

        // GET: Esta_Usua_clien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Esta_Usua_clien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CodTip_U_C,DescripTip_U_C")] Esta_Usua_clien esta_Usua_clien)
        {
            if (ModelState.IsValid)
            {
                db.Esta_Usua_clien.Add(esta_Usua_clien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(esta_Usua_clien);
        }

        // GET: Esta_Usua_clien/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Esta_Usua_clien esta_Usua_clien = db.Esta_Usua_clien.Find(id);
            if (esta_Usua_clien == null)
            {
                return HttpNotFound();
            }
            return View(esta_Usua_clien);
        }

        // POST: Esta_Usua_clien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CodTip_U_C,DescripTip_U_C")] Esta_Usua_clien esta_Usua_clien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(esta_Usua_clien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(esta_Usua_clien);
        }

        // GET: Esta_Usua_clien/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Esta_Usua_clien esta_Usua_clien = db.Esta_Usua_clien.Find(id);
            if (esta_Usua_clien == null)
            {
                return HttpNotFound();
            }
            return View(esta_Usua_clien);
        }

        // POST: Esta_Usua_clien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Esta_Usua_clien esta_Usua_clien = db.Esta_Usua_clien.Find(id);
            db.Esta_Usua_clien.Remove(esta_Usua_clien);
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
