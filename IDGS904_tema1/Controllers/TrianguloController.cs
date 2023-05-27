using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Operacion(Triangulo tri)
        {   if (tri.NoEsTriangulo()== false)
            {
                tri.Res="NO Es un Triangulo";
            }
            else
            {
                tri.Res = tri.Operaciones();
                
               
            }
            ViewBag.Res = tri.Res;
            return View();

        }
    }
}
