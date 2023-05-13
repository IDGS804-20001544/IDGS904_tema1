using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Distancia(Distancia Dis)
        {
           
            Dis.Res = Dis.DistanciaCal();
            
            return View(Dis);

        }
    }
}
