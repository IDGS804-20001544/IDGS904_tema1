using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;

namespace IDGS904_tema1.Services
{
    public class ProductoServices
    {
        public List<Productos> ObtenerProducto()
        {
            var producto1 = new Productos()
            {
                Nombre = "Pulque1",
                Descripcion = "Frutis Rojos",
                Cantidad = 10,
                Produccion = new DateTime(2023, 11, 5)

            };

            var producto2 = new Productos()
            {
                Nombre = "Pulque2",
                Descripcion = "Mango piña",
                Cantidad = 35,
                Produccion = new DateTime(2023, 6, 10)

            };
            return new List<Productos> { producto1, producto2 };
        }
    }
}