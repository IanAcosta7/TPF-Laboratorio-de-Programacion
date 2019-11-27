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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            formMain fmMain = Application.OpenForms.OfType<formMain>().FirstOrDefault();

            errProv.Clear(); // Se limpian todos los errores

            if (!Producto.validarFormulario(this, errProv))
            {
                //Funcionalidad de carga de producto
                string nombre = txtNombre.Text;
                string marca = txtMarca.Text;
                string color = txtColor.Text;
                double talle = Convert.ToDouble(txtTalle.Text);
                int stock = Convert.ToInt32(txtStock.Text);
                double precio = Convert.ToDouble(txtPrecio.Text);

                // Creo el producto
                Producto nuevo = new Producto(-1, nombre, marca, color, talle, stock, precio);

                // Actualizo el formulario y la BD
                nuevo.actualizarDB();
                fmMain.actualizarDVGStock(Producto.getAllProducts());

                this.Close();
            }
       }

        private void btnCargar_MouseEnter(object sender, EventArgs e)
        {
            btnCargar.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_1;

        }

        private void btnCargar_MouseLeave(object sender, EventArgs e)
        {
            btnCargar.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_0;

        }

        private void btnCargar_MouseDown(object sender, MouseEventArgs e)
        {
            btnCargar.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_2;

        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_1;

        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_0;

        }

        private void btnCancelar_MouseDown(object sender, MouseEventArgs e)
        {
            btnCancelar.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_2;

        }
    }
}
