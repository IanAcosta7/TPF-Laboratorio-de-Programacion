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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            this.actualizarDGVStockProd(Producto.getAllProducts());
        }
        public void actualizarDGVStockProd(DataTable productos)
        {
            // Se cargan los datos en el DGV
            dgvStockProd.AutoGenerateColumns = false;
            dgvStockProd.DataSource = productos;

            // Se insertan los datos en cada columna
            colNombre.DataPropertyName = "nombre";
            colMarca.DataPropertyName = "marca";
            colStock.DataPropertyName = "stock";
            colPrecio.DataPropertyName = "precio";
            colTalle.DataPropertyName = "talle";
            colColor.DataPropertyName = "color";
            colCodigo.DataPropertyName = "id_producto";
        }
        /*
        public void Añador() 
        {
            DataGridViewCellCollection nueva = dgvStockProd.SelectedRows[0].Cells;
        
            if (dgvStockProd.SelectedRows.Count == 1)
            {
               INTENTO DE PASAR DE UNA DATAGRIDVIEW A OTRA(CARRITO)
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún producto.");
            }

           
        }
        */
    }
}
