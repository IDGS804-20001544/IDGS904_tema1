using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class LeerServicesTraductor
    {
        public Array LeerArchivoTraducc()
        {
            Array datos = null;
            var infoTraducir = HttpContext.Current.Server.MapPath("~/App_Data/traducciones.txt");
            if (File.Exists(infoTraducir))
            {
                datos = File.ReadAllLines(infoTraducir);
            }
            return datos;
        }
       
    }
}