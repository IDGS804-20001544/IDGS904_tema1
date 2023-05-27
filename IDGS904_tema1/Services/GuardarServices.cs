using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class GuardarServices
    {
        public void GuardaArchivo(Maestros maes)
        {
            var nombre = maes.Nombre;
            var apaterno= maes.Apaterno;
            var amaterno= maes.Amaterno;
            var edad = maes.Edad;
            var email = maes.Email;
            var datos = nombre +","+apaterno+","+amaterno+","+edad+","
                        //esto es un salto de linea
                +email+Environment.NewLine;                 //IDENTIFiCA LA CARPETA QUE ESTA EN EL PROYECTO
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            //crea el archivo o si esta creado lo sbre escribe
            File.WriteAllText(archivo, datos);

            //Crea el archivo y añade y si no existe lo crea
            //File.AppendAllText(archivo, datos);
        }
    }
}