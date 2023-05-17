using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TienditaController : Controller
    {
        // GET: Tiendita
        public ActionResult Index()
        {
            var alumno = new Alumnos()
            {
                Name = "Pedro",
                Edad = 20,
                Activo = true,
                Inscrito = new DateTime(2023, 1, 1)
            };
            ViewBag.Alumnos = alumno;  
            return View();
        }

        public ActionResult Registrar()
        {

            return View();
        }
       
    }
}
