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
    public class caso_clientController : Controller
    {
        private ServiceAppEntities1 db = new ServiceAppEntities1();

        // GET: caso_client
        public ActionResult Index()
        {
            var casoes = db.casoes.Include(c => c.usuario).Include(c => c.Estatu).Include(c => c.cliente).Include(c => c.queja).Include(c => c.reclamo).Include(c => c.Relevancia1).Include(c => c.Tipo_Caso1).Include(c => c.departamento);
            return View(casoes.ToList());
        }

        // GET: caso_client/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            caso caso = db.casoes.Find(id);
            if (caso == null)
            {
                return HttpNotFound();
            }
            return View(caso);
        }

        // GET: caso_client/Create
        public ActionResult Create()
        {
            ViewBag.codigo_usuario = new SelectList(db.usuarios, "codigo", "nombre");
            ViewBag.estatus = new SelectList(db.Estatus, "CodEst", "DescripEst");
            ViewBag.id_cliente = new SelectList(db.clientes, "id", "nombre");
            ViewBag.id_queja = new SelectList(db.quejas, "id", "id");
            ViewBag.id_reclamo = new SelectList(db.reclamoes, "id", "id");
            ViewBag.relevancia = new SelectList(db.Relevancias, "CodRel", "DescripRel");
            ViewBag.tipo_caso = new SelectList(db.Tipo_Caso, "CodTip", "DescripTip");
            ViewBag.id_departamento = new SelectList(db.departamentoes, "id", "descripcion");
            return View();
        }

        // POST: caso_client/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,id_cliente,codigo_usuario,relevancia,tipo_caso,id_queja,id_reclamo,id_departamento,fecha,Comentario,estatus")] caso caso)
        {
            if (ModelState.IsValid)
            {
                db.casoes.Add(caso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.codigo_usuario = new SelectList(db.usuarios, "codigo", "nombre", caso.codigo_usuario);
            ViewBag.estatus = new SelectList(db.Estatus, "CodEst", "DescripEst", caso.estatus);
            ViewBag.id_cliente = new SelectList(db.clientes, "id", "nombre", caso.id_cliente);
            ViewBag.id_queja = new SelectList(db.quejas, "id", "id", caso.id_queja);
            ViewBag.id_reclamo = new SelectList(db.reclamoes, "id", "id", caso.id_reclamo);
            ViewBag.relevancia = new SelectList(db.Relevancias, "CodRel", "DescripRel", caso.relevancia);
            ViewBag.tipo_caso = new SelectList(db.Tipo_Caso, "CodTip", "DescripTip", caso.tipo_caso);
            ViewBag.id_departamento = new SelectList(db.departamentoes, "id", "descripcion", caso.id_departamento);
            return View(caso);
        }

        // GET: caso_client/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            caso caso = db.casoes.Find(id);
            if (caso == null)
            {
                return HttpNotFound();
            }
            ViewBag.codigo_usuario = new SelectList(db.usuarios, "codigo", "nombre", caso.codigo_usuario);
            ViewBag.estatus = new SelectList(db.Estatus, "CodEst", "DescripEst", caso.estatus);
            ViewBag.id_cliente = new SelectList(db.clientes, "id", "nombre", caso.id_cliente);
            ViewBag.id_queja = new SelectList(db.quejas, "id", "id", caso.id_queja);
            ViewBag.id_reclamo = new SelectList(db.reclamoes, "id", "id", caso.id_reclamo);
            ViewBag.relevancia = new SelectList(db.Relevancias, "CodRel", "DescripRel", caso.relevancia);
            ViewBag.tipo_caso = new SelectList(db.Tipo_Caso, "CodTip", "DescripTip", caso.tipo_caso);
            ViewBag.id_departamento = new SelectList(db.departamentoes, "id", "descripcion", caso.id_departamento);
            return View(caso);
        }

        // POST: caso_client/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,id_cliente,codigo_usuario,relevancia,tipo_caso,id_queja,id_reclamo,id_departamento,fecha,Comentario,estatus")] caso caso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(caso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.codigo_usuario = new SelectList(db.usuarios, "codigo", "nombre", caso.codigo_usuario);
            ViewBag.estatus = new SelectList(db.Estatus, "CodEst", "DescripEst", caso.estatus);
            ViewBag.id_cliente = new SelectList(db.clientes, "id", "nombre", caso.id_cliente);
            ViewBag.id_queja = new SelectList(db.quejas, "id", "id", caso.id_queja);
            ViewBag.id_reclamo = new SelectList(db.reclamoes, "id", "id", caso.id_reclamo);
            ViewBag.relevancia = new SelectList(db.Relevancias, "CodRel", "DescripRel", caso.relevancia);
            ViewBag.tipo_caso = new SelectList(db.Tipo_Caso, "CodTip", "DescripTip", caso.tipo_caso);
            ViewBag.id_departamento = new SelectList(db.departamentoes, "id", "descripcion", caso.id_departamento);
            return View(caso);
        }

        // GET: caso_client/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            caso caso = db.casoes.Find(id);
            if (caso == null)
            {
                return HttpNotFound();
            }
            return View(caso);
        }

        // POST: caso_client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            caso caso = db.casoes.Find(id);
            db.casoes.Remove(caso);
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
