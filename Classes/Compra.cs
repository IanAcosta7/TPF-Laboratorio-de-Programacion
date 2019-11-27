using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace TPF_Laboratorio_de_Programacion
{
    class Compra
    {
        // Compras es una lista global que guarda el contenido de mi carrito
        private static List<Compra> compras = new List<Compra>();
        public string desc;
        public int cantidad;
        public float precio;
        public float importe;

        public Compra(string newDesc, int newCantidad, float newPrecio, float newImporte)
        {
            this.desc = newDesc;
            this.cantidad = newCantidad;
            this.precio = newPrecio;
            this.importe = newImporte;
        }

        public static DataTable getAllCompras ()
        {
            DataTable dt = new DataTable();

            dt.TableName = "Compras";
            dt.Columns.Add("descripcion");
            dt.Columns.Add("cantidad");
            dt.Columns.Add("precio");
            dt.Columns.Add("importe");

            foreach (Compra compra in compras)
            {
                dt.Rows.Add(compra.desc, compra.cantidad, compra.precio, compra.importe);
            }

            return dt;
        }

        public void AddCompra ()
        {
            int pos = this.findCompra();
            if (pos != -1)
            {
                compras[pos].cantidad += this.cantidad;
                compras[pos].importe = compras[pos].cantidad * compras[pos].precio;
            } else
            compras.Add(this);
        }

        private int findCompra () // Comprueba si ya existe una compra con la misma desc actual y retorna su pos
        {
            int pos = -1;

            for (int i = 0; i < compras.Count; i++)
            {
                if (compras[i].desc == this.desc)
                    pos = i;
            }

            return pos;
        }

        public static void vaciarCompras ()
        {
            compras.RemoveRange(0, compras.Count);
        }
    }
}
