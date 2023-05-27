using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Traduccion
    {
        public string Espanol {set;get;}
        public string Ingles { set; get; }
        public string Traducir {get; set;}
        public string Lenguaje {get; set;}
        public string Resultado {get; set;}
        
        public string Radio()
        {   //creacion de variable para que busque en minuscula 
       
            String NewTra = "";
            //creacion de variable donde esta la ruta
            var Buscar = HttpContext.Current.Server.MapPath("~/App_Data/traducciones.txt");
            //lee todas las lineas que tiene mi txt
            String[]Linea=File.ReadAllLines(Buscar);
            bool traduccionEncontrada =false;

            if (Lenguaje == "1")
            {
                //creacion de una lista
                List<string> palabra= new List<string>();
                foreach(string line in Linea)
                {
                    //agrega la palabra despues de que se cumple la condicion
                    String[] escribir = line.Split(' ');
                    if(escribir.Length >= 2 && escribir[1].ToLower()==Traducir) {
                        palabra.Add(escribir[0].ToLower());
                        return NewTra = escribir[0].ToLower();
                        traduccionEncontrada=true;


                    }
                   
                }

                    
                }else{
                List<string> palabra = new List<string>();
                foreach (string line in Linea)
                {
                    String[] escribir = line.Split(' ');
                    if (escribir.Length >= 2 && escribir[0].ToLower() == Traducir)
                    {
                        palabra.Add(escribir[1].ToLower());
                        return NewTra = escribir[1].ToLower();
                        traduccionEncontrada= true;
                    }

                }
                //si no encuentra la palabra en la traduccion regresa que no existe
                if(!traduccionEncontrada){
                    NewTra = "No existe la traduccion";
                }


            } return NewTra;
           


        }




    }
}