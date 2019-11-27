using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace TPF_Laboratorio_de_Programacion
{
    class Producto
    {
        public int id_producto;
        public string nombre;
        public string marca;
        public string color;
        public double talle;
        public int stock;
        public double precio;

        public Producto (int newID, string newNombre, string newMarca, string newColor, double newTalle, int newStock, double newPrecio)
        {
            id_producto = newID;
            nombre = newNombre;
            marca = newMarca;
            color = newColor;
            talle = newTalle;
            stock = newStock;
            precio = newPrecio;
        }

        public void actualizarDB()
        {
            string cmd = string.Format("EXEC ActualizarProducto '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'", this.id_producto, this.nombre, this.marca, this.color, this.talle.ToString().Replace(',', '.'), this.stock, this.precio.ToString().Replace(',', '.'));
            Utilidades.Ejecutar(cmd);
        }

        public static DataTable getAllProducts()
        {
            // Conexion BD
            string cmd = "SELECT * FROM Productos WHERE borrado=0";
            DataSet ds = Utilidades.Ejecutar(cmd);

            return ds.Tables[0];
        }

        public static DataSet getProductByName (string name)
        {
            // Conexion BD
            string cmd = string.Format("SELECT * FROM Productos WHERE nombre='{0}'", name);
            DataSet ds = Utilidades.Ejecutar(cmd);

            return ds;
        }
        
        public static void borrarProducto(string nombre)
        {
            string cmd = string.Format("EXEC EliminarProducto '{0}'", nombre);
            Utilidades.Ejecutar(cmd);
        }

        public static Boolean validarFormulario(Control Objeto, ErrorProvider ErrorProvider)
        {
            Boolean HayErrores = false;

            // Se busca el ID del producto en cuestion para la comprobacion de nombre
            int id = -1;
            Control[] idControl = Objeto.Controls.Find("txtCodigo", true);
            if (idControl.Length > 0)
                id = Int32.Parse(((TextBox)idControl[0]).Text);

            foreach (Control Item in Objeto.Controls) //revisa cada objeto uno x uno
            {
                if (Item is ErrorTextBox)
                {
                    ErrorTextBox Obj = (ErrorTextBox)Item;
                    Double dbResult;
                    int iResult;

                    if (Obj.Validar)
                    {
                        // ----- Validaciones -----
                        // Campo vacio o NULL
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(Obj, "Debe completar todos los campos");
                            HayErrores = true;
                        } else if (Obj.Name == "txtNombre" && validarNombre(Obj.Text, id)) //nombreExistente(Obj.Text) && !Obj.ValidarDoble) 
                        // Validacion nombre
                        {
                            ErrorProvider.SetError(Obj, "El nombre ya existe");
                            HayErrores = true;
                        } else if ((Obj.Name == "txtPrecio" || Obj.Name == "txtTalle") && !Double.TryParse(Obj.Text, out dbResult))
                        // Validacion talle y precio
                        {
                            ErrorProvider.SetError(Obj, "Solo se aceptan valores decimales");
                            HayErrores = true;
                        } else if (Obj.Name == "txtStock" && !Int32.TryParse(Obj.Text, out iResult))
                        // Validación stock
                        {
                            ErrorProvider.SetError(Obj, "No es un número entero");
                            HayErrores = true;
                        }
                    }
                    else
                    {
                        ErrorProvider.SetError(Obj, "");////en su momento se puede sacar
                    }
                }
            }
            return HayErrores;
        } 

        public static Boolean validarNombre(string nombre, int id)
        {
            Boolean flag = false;

            flag = nombreExistente(nombre);

            if (id != -1)
            {
                DataRowCollection DRC = Producto.getProductByName(nombre).Tables[0].Rows;

                if (DRC.Count > 0)
                {
                    if (Int32.Parse(DRC[0]["id_producto"].ToString()) == id)
                        flag = false;
                }
            }

            return flag;
        }

        public static Boolean nombreExistente (string nombre)
        {
            Boolean existe = false;

            DataTable productos = Producto.getAllProducts();

            foreach (DataRow fila in productos.Rows)
            {
                if (nombre == fila["nombre"].ToString())
                    existe = true;
            }

            return existe;
        }
        /////////////////////// FUNCION DE PRUEBA, VALIDA QUE EL USUARIO INGRESE UNA CANTIDAD SUPERIOR A CERO, ABIERTA A SOLUCIONES
        public static Boolean validarCantidad(Control ObjetoP, ErrorProvider errorProvider, int cant)
        {
            Boolean HayError = false;

            foreach (Control Item in ObjetoP.Controls)
            {
                if (Item is ErrorTextBox)
                {
                    ErrorTextBox Obj = (ErrorTextBox)Item;

                    if (Obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            errorProvider.SetError(Obj, "Falta ingresar una cantidad");
                            HayError = true;
                        }

                        if (cant < 1)
                        {
                            errorProvider.SetError(Obj, "Se permiten solamanete valores mayores a cero");
                            HayError = true;

                        }

                    }
                    else
                    {
                        errorProvider.SetError(Obj, "");//// se puede sacar
                    }
                }
            }
            return HayError;
        }


    }
}
