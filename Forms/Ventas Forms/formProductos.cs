using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPF_Laboratorio_de_Programacion;

namespace TPF_Laboratorio_de_Programacion.Forms.Ventas_Forms
{
    public partial class formProductos : Form
    {
        public formProductos()
        {
            InitializeComponent();
        }

        //private void BtnAñadir_Click(object sender, EventArgs e)
        //{
        //    /////// ESTA FUNCION OBLIGA A QUE EL USUARIO A REALIZAR UNA SOLA OPERACION: CANCELAR O AÑADIR
        //    if (dgvProductos.Rows.Count == 1) ///SI SELECCIONO ALGO
        //    {
        //        DialogResult = DialogResult.OK;
        //        this.Close();
        //    }
        //    else
        //    {
        //        return;
        //    }
        //}

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscarNombre_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBuscar.Text.Trim()) == false)
            {
                   try
                   {
                    string busqueda = textBuscar.Text.Trim().ToString(); ///lo que tengo en la caja de texto lo convierto en string
                    this.actualizarDVGProductos(Producto.getProductByNameBuscar(busqueda));
                   }
                   catch(Exception error)
                   {
                       MessageBox.Show("El tincho se equivoco fuerte, y no consiguio buscar ese nombre" + error.Message);

                   }
                   

            }
            
        }

        private void btnBuscarNombre_MouseEnter(object sender, EventArgs e)
        {
            btnBuscarNombre.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_1;

        }

        private void btnBuscarNombre_MouseLeave(object sender, EventArgs e)
        {
            btnBuscarNombre.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_0;

        }

        private void btnBuscarNombre_MouseDown(object sender, MouseEventArgs e)
        {
            btnBuscarNombre.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_2;

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

        private void btnAñadir_MouseEnter(object sender, EventArgs e)
        {
            btnAñadir.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_1;

        }

        private void btnAñadir_MouseLeave(object sender, EventArgs e)
        {
            btnAñadir.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_0;

        }

        private void btnAñadir_MouseDown(object sender, MouseEventArgs e)
        {
            btnAñadir.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_2;

        }

        private void formProductos_Load(object sender, EventArgs e)
        {
            this.actualizarDVGProductos(Producto.getAllProducts());
        }

        public void actualizarDVGProductos(DataTable productos)
        {
            // Se cargan los datos en el DGV
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = productos;

            // Se insertan los datos en cada columna
            colNombre.DataPropertyName = "nombre";
            colMarca.DataPropertyName = "marca";
            colStock.DataPropertyName = "stock";
            colPrecio.DataPropertyName = "precio";
            colTalle.DataPropertyName = "talle";
            colColor.DataPropertyName = "color";
            colCodigo.DataPropertyName = "id_producto";
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            
            if (dgvProductos.SelectedRows.Count > 0 && nudCantidad.Value > 0)
            {
                formMain fmMain = Application.OpenForms.OfType<formMain>().FirstOrDefault();

                DataGridViewRow row = dgvProductos.SelectedRows[0];
                string desc = string.Format("{0} {1} {2} Talle:{3} #{4}", row.Cells["colNombre"].Value.ToString(), row.Cells["colMarca"].Value.ToString(), row.Cells["colColor"].Value.ToString(), row.Cells["colTalle"].Value.ToString(), row.Cells["colCodigo"].Value.ToString());
                int cantidad = Int32.Parse(nudCantidad.Value.ToString());
                float precio = float.Parse(row.Cells["colPrecio"].Value.ToString());

                // Creo la compra y la añado al carrito
                Compra nueva = new Compra(desc, cantidad, precio, cantidad*precio);
                nueva.AddCompra();

                // Actualizo el carrito
                fmMain.actualizarDVGVentas(Compra.getAllCompras());

                this.Close();
            } else
            {
                MessageBox.Show("No se ha seleccionado ningún producto");
            }
        }
    }
}
