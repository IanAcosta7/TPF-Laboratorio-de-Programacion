using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPF_Laboratorio_de_Programacion
{
    class Compra
    {
        public static Compra[] compras;
        public string desc;
        public int cantidad;
        public int precio;
        public int importe;

        public Compra(string newDesc, int newCantidad, int newPrecio, int newImporte)
        {
            this.desc = newDesc;
            this.cantidad = newCantidad;
            this.precio = newPrecio;
            this.importe = newImporte;
        }
    }
}
