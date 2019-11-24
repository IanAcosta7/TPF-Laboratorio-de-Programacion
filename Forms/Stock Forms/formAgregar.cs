using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TPF_Laboratorio_de_Programacion
{
    public partial class formAgregar : Form
    {
        public formAgregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             *agregar nuevo
            *
            * actualizarlista()
             *
             *
             */
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //IMPORTANTE LAS CAJAS DE TEXTO CAMBIARON, USAMOS ERRORTEXBOX Y NO TEXBOX
           /* // Funcionalidad de carga de producto
             string nombre = txtNombre.Text.Trim();
             string marca = txtMarca.Text.Trim();
             string color = txtColor.Text.Trim();
             double talle = Convert.ToDouble(txtTalle.Text);
             int stock = Convert.ToInt32(txtStock.Text);
             double precio = Convert.ToDouble(txtPrecio.Text);

             // Validaciones
             // POR HACER ..*/
            // Creo el producto
            // Producto nuevo = new Producto(nombre, marca, color, talle, stock, precio);
             /* try  
              {
                   nuevo.actualizarDB();
                  string cmd = string.Format("EXEC ActualizarProducto '{0}','{1}','{2}','{3}','{4}','{5}'", nombre,marca, color,talle, stock,precio);
                 Utilidades.Ejecutar(cmd);
                  MessageBox.Show("ACTUALIZADO ");  

              }catch  (Exception ERROR)
              {
                  MessageBox.Show("ERROR::" + ERROR.Message);

              }*/
            //nuevo.actualizarDB();
           
           // this.Close();
            
       }
   

        private void TxtTalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void ErrorTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
