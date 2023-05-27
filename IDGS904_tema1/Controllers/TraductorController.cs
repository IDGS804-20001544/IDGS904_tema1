using IDGS904_tema1.Models;
using IDGS904_tema1.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult RegistrarTraducc(Traduccion Trad)
        {
            //creamos una variable donde guardas la clase servicio
            var op1 = new GuardarServicesTraductor();
            //llamamos el servicio
            op1.GuardaArchivoTraduc(Trad);

            var arch = new LeerServicesTraductor();
            ViewBag.Archivo = arch.LeerArchivoTraducc();
            return View();
        }

        public ActionResult BuscarTraducc(Traduccion Trad)
        {
            Trad.Resultado = Trad.Radio();
            ViewBag.Resultado = Trad.Resultado;
            return View();

            
        }

    }
    }

