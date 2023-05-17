using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class GradosController : Controller
    {
        // GET: Grados
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Grados() {
            return View();

        }

        public ActionResult Op(Grados grados)
        {
            double resultado = grados.Convercion();
            grados.Res = resultado;
            TempData["Res"] = grados.Res;
            return RedirectToAction("Resultado");
        }

        public ActionResult Resultado()
        {
            string Res = "";
            if (TempData.ContainsKey("Res"))
            {
                Res = TempData["Res"].ToString();
            }
            ViewBag.Resultado = Res;

            return View();
        }
       
    }
}
