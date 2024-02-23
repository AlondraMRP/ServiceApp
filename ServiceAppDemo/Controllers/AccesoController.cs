using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ServiceAppDemo.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string User, string Pass)
        {
            try
            {
                using (Models.ServiceAppEntities1 db = new Models.ServiceAppEntities1())
                {
                    var oUser = (from d in db.usuarios
                                 where d.codigo == User.Trim() && d.clave == Pass.Trim() 
                                 select d).FirstOrDefault();                  
                    if (oUser == null)
                    {                                                 
                        ViewBag.Error = "Usuario o contraseña invalida";
                        return View();
                    }
                    string TipoUse = oUser.TipoUser;
                    Session["User"] = oUser;
                    if(oUser.idroll == 2)
                    {                        
                        return RedirectToAction("clientIndex", "Home");
                    }
                    if (oUser.idroll == 3)
                    {
                        return RedirectToAction("operatorIndex", "Home");
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }                
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }
        public ActionResult LoginCli(string User, string Pass)
        {
            try
            {
                using (Models.ServiceAppEntities1 db = new Models.ServiceAppEntities1())
                {
                    var oUser = (from d in db.clientes
                                 where d.nombre == User.Trim() && d.clave == Pass.Trim()
                                 select d).FirstOrDefault();
                    if (oUser == null)
                    {
                        ViewBag.Error = "Usuario o contraseña invalida";
                        return View();
                    }
                    Session["User"] = oUser;
                }
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }
    }
}