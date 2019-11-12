using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //string cmd = string.Format("INSERT INTO Productos (marca, color, talle, stock, precio) VALUES (\'{0}\', \'{1}\', {2}, {3}, {4})", this.marca, this.color, this.talle, this.stock, this.precio);
            //Utilidades.agregarDB(cmd);  
            Utilidades.Ejecutar(cmd);
        }
    }
}
