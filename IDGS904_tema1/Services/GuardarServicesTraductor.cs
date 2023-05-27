using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class GuardarServicesTraductor
    {
        public void GuardaArchivoTraduc(Traduccion trad)
        {
            var español = trad.Espanol;
            var ingles = trad.Ingles;
            var traducciones = español + " " + ingles 
                //esto es un salto de linea
               + Environment.NewLine;                 //IDENTIFiCA LA CARPETA QUE ESTA EN EL PROYECTO
            var Traducir = HttpContext.Current.Server.MapPath("~/App_Data/traducciones.txt");
            //crea el archivo o si esta creado lo sbre escribe
            //File.WriteAllText(Traducir, traducciones);

            //Crea el archivo y añade y si no existe lo crea
            File.AppendAllText(Traducir, traducciones);
        }
    }
}