using System;

namespace IDGS904_tema1.Models
{
    public class OperasBas
    {

        public int Num1 { get; set; }

        public int Num2 { get; set; }

        public int Res { get; set; }

        public int calcular { set; get; }


        public int suma()
        {
            return (this.Num1 + this.Num2);
        }
        public int resta()
        {
            return (this.Num1 - this.Num2);
        }
        public int multiplicacion()
        {
            return (this.Num1 * this.Num2);
        }
        public int division()
        {
            return (this.Num1 / this.Num2);
        }

        public int Resultado()
        {
            int resultado = 0;
            if (this.calcular == 1)
            {
                resultado = suma();
            }
            if (this.calcular == 2)
            {
                resultado = resta();
            }
            if (this.calcular == 3)
            {
                resultado = multiplicacion();
            }
            if (this.calcular == 4)
            {
                resultado = division();
            }
            return resultado;
        }

    }
}