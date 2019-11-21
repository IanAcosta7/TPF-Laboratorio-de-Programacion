using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TPF_Laboratorio_de_Programacion
{
    class Producto
    {
        public string nombre;
        public string marca;
        public string color;
        public double talle;
        public int stock;
        public double precio;

        public Producto (string newNombre, string newMarca, string newColor, double newTalle, int newStock, double newPrecio)
        {
            nombre = newNombre;
            marca = newMarca;
            color = newColor;
            talle = newTalle;
            stock = newStock;
            precio = newPrecio;
        }

        public void actualizarDB ()
        {
            string cmd = string.Format("EXEC ActualizarProducto '{0}', '{1}', '{2}', '{3}', '{4}', '{5}'", this.nombre, this.marca, this.color, this.talle, this.stock, this.precio);
            Utilidades.Ejecutar(cmd);
        }

        public static DataSet getAllProducts ()
        {
            // Conexion BD
            string cmd = "SELECT * FROM Productos WHERE borrado=0";
            DataSet ds = Utilidades.Ejecutar(cmd);

            return ds;
        }
        
        public static void borrarProducto(string nombre)
        {
            string cmd = string.Format("EXEC EliminarProducto '{0}'", nombre);
            Utilidades.Ejecutar(cmd);
        }

    }
}
