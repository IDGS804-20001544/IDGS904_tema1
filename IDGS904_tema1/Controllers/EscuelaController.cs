using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            //return Content("<h1>Axel </br> Hernandez</h1>");
            var pulque = new Productos()
            {
                Nombre = "pulque1",
                Descripcion = "fresa",
                Cantidad = 10,
                Produccion = new DateTime(2023, 11, 2)
            };
            return Json(pulque,JsonRequestBehavior.AllowGet);
            //return View();
        }
        public RedirectResult Vista()
        {
            return Redirect("https://google.com.mx");
        }
        public RedirectToRouteResult Vista2() {
            TempData["Nombre"] = "Axel";

            return RedirectToAction("Index2");

        }

        public ActionResult Index2()
        {
            ViewBag.Grupo = "IDGS904";
            ViewData["Materia"]="DWI";

            string nombre = "";
            if (TempData.ContainsKey("nombre"))
            {
                nombre = TempData["nombre"] as string;
            }
            ViewBag.valor=nombre;
            return View();
        }

    }
}
