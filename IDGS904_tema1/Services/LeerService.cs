using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class LeerService
    {
        public Array LeerArchivo()
        {
            Array datos = null;
            var infoMaestro = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            if (File.Exists(infoMaestro))
            {
                datos=File.ReadAllLines(infoMaestro);
            }
            return datos;
        }
    }
}