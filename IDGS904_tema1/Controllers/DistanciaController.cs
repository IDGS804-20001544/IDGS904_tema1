using IDGS904_tema1.Models;
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

        
        public ActionResult Distancia()
        {
            return View();
            }
        public RedirectToRouteResult Vista2(Distancia Dis)
        {
            Dis.Res = Dis.DistanciaCal();
            TempData["Res"] = Dis.Res;

            return RedirectToAction("DistanciaResultado");
        }
        public ActionResult DistanciaResultado()
        {
            string Res = "";
            if (TempData.ContainsKey("Res"))
            {
                Res = TempData["Res"].ToString();
            }
            ViewBag.Res = Res;

            return View();
        }
    }
}
