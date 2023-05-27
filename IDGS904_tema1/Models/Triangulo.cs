using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class Triangulo
    {
        public double PtX1 { get; set; }
        public double PtY1 { get;set; }
        public double PtX2 { get; set;}
        public double PtY2 { get;set; }
        public double PtX3 { get; set;}
        public double PtY3 { get;set;}

        public string Res {get; set;} 

        public string Operaciones()
        {
            double AB = Math.Sqrt(Math.Pow(PtX2 - PtX1, 2) + Math.Pow(PtY2 - PtY1, 2));
            AB = Math.Round(AB,1); 
            double AC = Math.Sqrt(Math.Pow(PtX3 - PtX1, 2) + Math.Pow(PtY3 - PtY1, 2));
            AC = Math.Round(AC,1);
            double BC = Math.Sqrt(Math.Pow(PtX3 - PtX2, 2) + Math.Pow(PtY3 - PtY2, 2));
            BC = Math.Round(BC,1);

            if (AB == AC && AC==AB)
            {
                return "Es un Triangulo Equilatero";
            }else if (AB==AC ||  BC== AB || AC==BC)
            {
                return "Es un Triangulo Isoceles";
            }
            else
            {
                return "Es un Triangulo Escaleno";
            }

            
        }

        public bool NoEsTriangulo()
        {
            double AreaTriangulo = (PtX1 * (PtY2 - PtY3) + PtX2 * (PtY3 - PtY1) + PtX3 * (PtY1 - PtY2)) / 2;
            return AreaTriangulo > 0;
        }


    }
}