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
            DataTable Productos = Producto.getAllProducts().Tables[0];
            dgvStock.DataSource = Producto.getAllProducts().Tables[0];
            //dgvStock.Columns[0].HeaderText = "Nombre";
            colNombre.DataPropertyName = Productos.Columns[1].ColumnName;
            colMarca.DataPropertyName = Productos.Columns[2].ColumnName;
            colStock.DataPropertyName = Productos.Columns[5].ColumnName;
            colPrecio.DataPropertyName = Productos.Columns[6].ColumnName;
            colTalle.DataPropertyName = Productos.Columns[4].ColumnName;
            colColor.DataPropertyName = Productos.Columns[3].ColumnName;
            colCodigo.DataPropertyName = Productos.Columns[0].ColumnName;
        }
    }
}
