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
    public partial class formStock : Form
    {
        public formStock()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            formAgregar nuevo = new formAgregar();
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            formModificar nuevo = new formModificar();
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

        private void gbMain_Enter(object sender, EventArgs e)
        {

        }

        private void formStock_Load(object sender, EventArgs e)
        {
            this.actualizarDVGStock();
        }

        public void actualizarDVGStock ()
        {
            // Se cargan los datos en el DGV
            DataTable productos = Producto.getAllProducts().Tables[0];
            dgvStock.AutoGenerateColumns = false;
            dgvStock.DataSource = productos;

            // Se insertan los datos en cada columna
            colNombre.DataPropertyName = productos.Columns[1].ColumnName;
            colMarca.DataPropertyName = productos.Columns[2].ColumnName;
            colStock.DataPropertyName = productos.Columns[5].ColumnName;
            colPrecio.DataPropertyName = productos.Columns[6].ColumnName;
            colTalle.DataPropertyName = productos.Columns[4].ColumnName;
            colColor.DataPropertyName = productos.Columns[3].ColumnName;
            colCodigo.DataPropertyName = productos.Columns[0].ColumnName;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count >= 1)
            {
                DataGridViewCellCollection data = dgvStock.SelectedRows[0].Cells;
                Producto.borrarProducto(data[0].Value.ToString());
                this.actualizarDVGStock();
            } else
            {
                MessageBox.Show("No se ha seleccionado ningún producto.");
            }
        }
    }
}
