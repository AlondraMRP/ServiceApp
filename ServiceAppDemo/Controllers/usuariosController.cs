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
    public class usuariosController : Controller
    {
        private ServiceAppEntities1 db = new ServiceAppEntities1();

        // GET: usuarios
        public ActionResult Index()
        {
            var usuarios = db.usuarios.Include(u => u.departamento).Include(u => u.Esta_Usua_clien).Include(u => u.Rol);
            return View(usuarios.ToList());
        }

        // GET: usuarios/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            usuario usuario = db.usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // GET: usuarios/Create
        public ActionResult Create()
        {
            ViewBag.Id_departamento = new SelectList(db.departamentoes, "id", "descripcion");
            ViewBag.estatus = new SelectList(db.Esta_Usua_clien, "CodTip_U_C", "DescripTip_U_C");
            ViewBag.idroll = new SelectList(db.Rols, "id", "descripcion");
            return View();
        }

        // POST: usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "codigo,nombre,clave,estatus,Id_departamento,cargo,idroll,fecha")] usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.usuarios.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_departamento = new SelectList(db.departamentoes, "id", "descripcion", usuario.Id_departamento);
            ViewBag.estatus = new SelectList(db.Esta_Usua_clien, "CodTip_U_C", "DescripTip_U_C", usuario.estatus);
            ViewBag.idroll = new SelectList(db.Rols, "id", "descripcion", usuario.idroll);
            return View(usuario);
        }

        // GET: usuarios/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            usuario usuario = db.usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_departamento = new SelectList(db.departamentoes, "id", "descripcion", usuario.Id_departamento);
            ViewBag.estatus = new SelectList(db.Esta_Usua_clien, "CodTip_U_C", "DescripTip_U_C", usuario.estatus);
            ViewBag.idroll = new SelectList(db.Rols, "id", "descripcion", usuario.idroll);
            return View(usuario);
        }

        // POST: usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "codigo,nombre,clave,estatus,Id_departamento,cargo,idroll,fecha")] usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_departamento = new SelectList(db.departamentoes, "id", "descripcion", usuario.Id_departamento);
            ViewBag.estatus = new SelectList(db.Esta_Usua_clien, "CodTip_U_C", "DescripTip_U_C", usuario.estatus);
            ViewBag.idroll = new SelectList(db.Rols, "id", "descripcion", usuario.idroll);
            return View(usuario);
        }

        // GET: usuarios/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            usuario usuario = db.usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            usuario usuario = db.usuarios.Find(id);
            db.usuarios.Remove(usuario);
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
