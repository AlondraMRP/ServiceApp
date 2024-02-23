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
    public class producto_clienteController : Controller
    {
        private ServiceAppEntities1 db = new ServiceAppEntities1();

        // GET: producto_cliente
        public ActionResult Index()
        {
            var producto_cliente = db.producto_cliente.Include(p => p.cliente).Include(p => p.producto);
            return View(producto_cliente.ToList());
        }

        // GET: producto_cliente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            producto_cliente producto_cliente = db.producto_cliente.Find(id);
            if (producto_cliente == null)
            {
                return HttpNotFound();
            }
            return View(producto_cliente);
        }

        // GET: producto_cliente/Create
        public ActionResult Create()
        {
            ViewBag.id_cliente = new SelectList(db.clientes, "id", "nombre");
            ViewBag.id_producto = new SelectList(db.productoes, "id", "descripcion");
            return View();
        }

        // POST: producto_cliente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,id_producto,id_cliente,cantidad")] producto_cliente producto_cliente)
        {
            if (ModelState.IsValid)
            {
                db.producto_cliente.Add(producto_cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_cliente = new SelectList(db.clientes, "id", "nombre", producto_cliente.id_cliente);
            ViewBag.id_producto = new SelectList(db.productoes, "id", "descripcion", producto_cliente.id_producto);
            return View(producto_cliente);
        }

        // GET: producto_cliente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            producto_cliente producto_cliente = db.producto_cliente.Find(id);
            if (producto_cliente == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_cliente = new SelectList(db.clientes, "id", "nombre", producto_cliente.id_cliente);
            ViewBag.id_producto = new SelectList(db.productoes, "id", "descripcion", producto_cliente.id_producto);
            return View(producto_cliente);
        }

        // POST: producto_cliente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,id_producto,id_cliente,cantidad")] producto_cliente producto_cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producto_cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_cliente = new SelectList(db.clientes, "id", "nombre", producto_cliente.id_cliente);
            ViewBag.id_producto = new SelectList(db.productoes, "id", "descripcion", producto_cliente.id_producto);
            return View(producto_cliente);
        }

        // GET: producto_cliente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            producto_cliente producto_cliente = db.producto_cliente.Find(id);
            if (producto_cliente == null)
            {
                return HttpNotFound();
            }
            return View(producto_cliente);
        }

        // POST: producto_cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            producto_cliente producto_cliente = db.producto_cliente.Find(id);
            db.producto_cliente.Remove(producto_cliente);
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
