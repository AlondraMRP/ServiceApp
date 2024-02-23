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
    public class clientesController : Controller
    {
        private ServiceAppEntities1 db = new ServiceAppEntities1();

        // GET: clientes
        public ActionResult Index()
        {
            var clientes = db.clientes.Include(c => c.Esta_Usua_clien);
            return View(clientes.ToList());
        }

        // GET: clientes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cliente cliente = db.clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // GET: clientes/Create
        public ActionResult Create()
        {
            ViewBag.estatus = new SelectList(db.Esta_Usua_clien, "CodTip_U_C", "DescripTip_U_C");
            return View();
        }

        // POST: clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,clave,cedula,fecha_registro,correo,estatus,monto,telefono,cargo")] cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.clientes.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.estatus = new SelectList(db.Esta_Usua_clien, "CodTip_U_C", "DescripTip_U_C", cliente.estatus);
            return View(cliente);
        }

        // GET: clientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cliente cliente = db.clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            ViewBag.estatus = new SelectList(db.Esta_Usua_clien, "CodTip_U_C", "DescripTip_U_C", cliente.estatus);
            return View(cliente);
        }

        // POST: clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,clave,cedula,fecha_registro,correo,estatus,monto,telefono,cargo")] cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.estatus = new SelectList(db.Esta_Usua_clien, "CodTip_U_C", "DescripTip_U_C", cliente.estatus);
            return View(cliente);
        }

        // GET: clientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cliente cliente = db.clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cliente cliente = db.clientes.Find(id);
            db.clientes.Remove(cliente);
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
