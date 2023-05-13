using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Distancia
    {
        public double NumX1 { get; set; }
        public double NumY1 { get; set; }
        public double NumX2 { get; set; }
        public double NumY2 { get; set; }
        public double Res { get; set; }

        public double DistanciaCal()
        {
            double X1 = NumX1;
            double Y1 = NumY1;
            double X2 = NumX2;
            double Y2 = NumY2;

            double Resultado= Math.Sqrt(Math.Pow(NumX2 - NumX1, 2) + Math.Pow(NumY2 - NumY1, 2));
            return Resultado;
        }


    }
}