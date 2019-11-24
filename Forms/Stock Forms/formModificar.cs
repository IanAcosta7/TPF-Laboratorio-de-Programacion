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
    public partial class formModificar : Form
    {
        public formModificar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            // Logica de modificar

            this.Close();
        }

        public void cargarFormulario (string name)
        {
            // Consulto a la BD por el nombre
            DataRow producto = Producto.getProductByName(name).Tables[0].Rows[0];

            // Relleno los campos
            txtCodigo.Text = producto["id_producto"].ToString();
            txtNombre.Text = producto["nombre"].ToString();
            txtMarca.Text = producto["marca"].ToString();
            txtColor.Text = producto["color"].ToString();
            txtTalle.Text = producto["talle"].ToString();
            txtStock.Text = producto["stock"].ToString();
            txtPrecio.Text = producto["precio"].ToString();
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            formMain fmMain = Application.OpenForms.OfType<formMain>().FirstOrDefault();

            if (!Producto.validarFormulario(this, errProv))
            {
                //Funcionalidad de carga de producto
                int id_producto = Convert.ToInt32(txtCodigo.Text);
                string nombre = txtNombre.Text;
                string marca = txtMarca.Text;
                string color = txtColor.Text;
                double talle = Convert.ToDouble(txtTalle.Text);
                int stock = Convert.ToInt32(txtStock.Text);
                double precio = Convert.ToDouble(txtPrecio.Text);

                // Creo el producto
                Producto nuevo = new Producto(id_producto, nombre, marca, color, talle, stock, precio);

                // Actualizo el formulario y la BD
                nuevo.actualizarDB();
                fmMain.actualizarDVGStock();

                this.Close();
            }


            //formMain fmMain = Application.OpenForms.OfType<formMain>().FirstOrDefault();

            //// Funcionalidad de carga de producto
            //int id_producto = Convert.ToInt32(txtCodigo.Text);
            //string nombre = txtNombre.Text;
            //string marca = txtMarca.Text;
            //string color = txtColor.Text;
            //double talle = Convert.ToDouble(txtTalle.Text);
            //int stock = Convert.ToInt32(txtStock.Text);
            //double precio = Convert.ToDouble(txtPrecio.Text);

            //// Validaciones
            //// POR HACER

            //// Creo el producto
            //Producto nuevo = new Producto(id_producto, nombre, marca, color, talle, stock, precio);

            //// Actualizo el formulario y la BD
            //nuevo.actualizarDB();
            //fmMain.actualizarDVGStock();

            //this.Close();
        }
    }
}
