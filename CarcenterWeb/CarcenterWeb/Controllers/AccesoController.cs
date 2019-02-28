using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarcenterWeb.Models;

namespace CarcenterWeb.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Enter(int user, string pwd)
        {
            try
            {
                using (carcenterEntities db = new carcenterEntities())
                {
                    var lstPersonas = from p in db.PERSONAS
                                      where p.IDENTIFICACION == user && p.CONTRASENA == pwd
                                      select p;

                    if (lstPersonas.Count() > 0)
                    {
                        PERSONAS oPersona = lstPersonas.First();
                        Session["User"] = oPersona;
                        return Content("1");
                    }
                    else
                    {
                        return Content("Usuario o contraseña incorrectos");
                    }
                }

            }
            catch (Exception ex)
            {
                return Content("Error: " + ex.Message);
            }

        }

    }
}