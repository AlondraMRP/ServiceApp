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
    public class valoracion_respuestaController : Controller
    {
        private ServiceAppEntities1 db = new ServiceAppEntities1();

        // GET: valoracion_respuesta
        public ActionResult Index()
        {
            var valoracion_respuesta = db.valoracion_respuesta.Include(v => v.caso).Include(v => v.cliente).Include(v => v.usuario);
            return View(valoracion_respuesta.ToList());
        }

        // GET: valoracion_respuesta/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            valoracion_respuesta valoracion_respuesta = db.valoracion_respuesta.Find(id);
            if (valoracion_respuesta == null)
            {
                return HttpNotFound();
            }
            return View(valoracion_respuesta);
        }

        // GET: valoracion_respuesta/Create
        public ActionResult Create()
        {
            ViewBag.id_caso = new SelectList(db.casoes, "id", "codigo_usuario");
            ViewBag.id_cliente = new SelectList(db.clientes, "id", "nombre");
            ViewBag.id_usuario = new SelectList(db.usuarios, "codigo", "nombre");
            return View();
        }

        // POST: valoracion_respuesta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,id_caso,id_cliente,id_usuario,valor")] valoracion_respuesta valoracion_respuesta)
        {
            if (ModelState.IsValid)
            {
                db.valoracion_respuesta.Add(valoracion_respuesta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_caso = new SelectList(db.casoes, "id", "codigo_usuario", valoracion_respuesta.id_caso);
            ViewBag.id_cliente = new SelectList(db.clientes, "id", "nombre", valoracion_respuesta.id_cliente);
            ViewBag.id_usuario = new SelectList(db.usuarios, "codigo", "nombre", valoracion_respuesta.id_usuario);
            return View(valoracion_respuesta);
        }

        // GET: valoracion_respuesta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            valoracion_respuesta valoracion_respuesta = db.valoracion_respuesta.Find(id);
            if (valoracion_respuesta == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_caso = new SelectList(db.casoes, "id", "codigo_usuario", valoracion_respuesta.id_caso);
            ViewBag.id_cliente = new SelectList(db.clientes, "id", "nombre", valoracion_respuesta.id_cliente);
            ViewBag.id_usuario = new SelectList(db.usuarios, "codigo", "nombre", valoracion_respuesta.id_usuario);
            return View(valoracion_respuesta);
        }

        // POST: valoracion_respuesta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,id_caso,id_cliente,id_usuario,valor")] valoracion_respuesta valoracion_respuesta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(valoracion_respuesta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_caso = new SelectList(db.casoes, "id", "codigo_usuario", valoracion_respuesta.id_caso);
            ViewBag.id_cliente = new SelectList(db.clientes, "id", "nombre", valoracion_respuesta.id_cliente);
            ViewBag.id_usuario = new SelectList(db.usuarios, "codigo", "nombre", valoracion_respuesta.id_usuario);
            return View(valoracion_respuesta);
        }

        // GET: valoracion_respuesta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            valoracion_respuesta valoracion_respuesta = db.valoracion_respuesta.Find(id);
            if (valoracion_respuesta == null)
            {
                return HttpNotFound();
            }
            return View(valoracion_respuesta);
        }

        // POST: valoracion_respuesta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            valoracion_respuesta valoracion_respuesta = db.valoracion_respuesta.Find(id);
            db.valoracion_respuesta.Remove(valoracion_respuesta);
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
