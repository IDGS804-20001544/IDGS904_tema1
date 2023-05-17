using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Grados
    {
        public double Grado { get; set; }
        public int Oper { get; set; }
        public double Res {get; set; }

        public double Convercion()
        {
            if (Oper ==2 )
            {
                //Convertir a farenheit

                return ((Grado * 9 / 5) + 32);
            }
            else
            {
                //Convertir a Celsius

                return ((Grado - 32) * 5/9);
            }
        }
    }
}