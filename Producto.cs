using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPF_Laboratorio_de_Programacion
{
    class Producto
    {
        // Ejemplo para el tincho
        public string marca;
        public string color;
        public double talle;
        public int stock;
        public double precio;

        public Producto (string newMarca, string newColor, double newTalle, int newStock, double newPrecio)
        {
            marca = newMarca;
            color = newColor;
            talle = newTalle;
            stock = newStock;
            precio = newPrecio;
        }
    }
}
