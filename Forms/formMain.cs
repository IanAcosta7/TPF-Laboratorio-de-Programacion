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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formAgregar nuevo = new formAgregar();
            nuevo.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 1)
            {
                DataGridViewCellCollection data = dgvStock.SelectedRows[0].Cells;

                // Creo un formulario modificar y lo cargo
                formModificar nuevo = new formModificar();
                nuevo.cargarFormulario(data[0].Value.ToString());
                nuevo.Show();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún producto.");
            }
        }

        private void formStock_Load(object sender, EventArgs e)
        {
            this.actualizarDVGStock(Producto.getAllProducts());
        }

        public void actualizarDVGStock (DataTable productos)
        {
            // Se cargan los datos en el DGV
            dgvStock.AutoGenerateColumns = false;
            dgvStock.DataSource = productos;

            // Se insertan los datos en cada columna
            colNombre.DataPropertyName = "nombre";
            colMarca.DataPropertyName = "marca";
            colStock.DataPropertyName = "stock";
            colPrecio.DataPropertyName = "precio";
            colTalle.DataPropertyName = "talle";
            colColor.DataPropertyName = "color";
            colCodigo.DataPropertyName = "id_producto";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 1)
            {
                DataGridViewCellCollection data = dgvStock.SelectedRows[0].Cells;

                // Borro el proucto
                Producto.borrarProducto(data[0].Value.ToString());
                this.actualizarDVGStock(Producto.getAllProducts());
            } else
            {
                MessageBox.Show("No se ha seleccionado ningún producto.");
            }
        }
    }
}
