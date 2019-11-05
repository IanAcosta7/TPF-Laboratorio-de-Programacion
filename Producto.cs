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
        public string nombre;
        public string marca;
        public int stock;

        public Producto (string nombres, string marcas, int stocks)
        {
            nombre = nombres;
            marca = marcas;
            stock = stocks;
        }
    }
}
