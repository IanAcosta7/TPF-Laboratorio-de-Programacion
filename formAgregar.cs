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

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Funcionalidad de carga de producto
            string marca = txtMarca.Text;
            string color = txtColor.Text;
            double talle = Convert.ToDouble(txtTalle.Text);
            int stock = Convert.ToInt32(txtStock.Text);
            double precio = Convert.ToDouble(txtPrecio.Text);

            // Validaciones

            // Creo el producto
            Producto nuevo = new Producto(marca, color, talle, stock, precio);
            nuevo.actualizarDB();

            //Console.WriteLine(nuevo.marca);
            
            this.Close();
        }
    }
}
