using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPF_Laboratorio_de_Programacion.Forms.Ventas_Forms
{
    public partial class formProductosV : Form
    {
        public formProductosV()
        {
            InitializeComponent();
        }

        public void actualizarDVGProductosV(DataTable productos)
        {
            // Se cargan los datos en el DGV
            dgvProductosV.AutoGenerateColumns = false;
            dgvProductosV.DataSource = productos;

            // Se insertan los datos en cada columna
            colNombre.DataPropertyName = "nombre";
            colMarca.DataPropertyName = "marca";
            colStock.DataPropertyName = "stock";
            colPrecio.DataPropertyName = "precio";
            colTalle.DataPropertyName = "talle";
            colColor.DataPropertyName = "color";
            colCodigo.DataPropertyName = "id_producto";
        }
        private void formProductoV_Load(object sender, DataGridViewCellEventArgs e)
        {
            this.actualizarDVGProductosV(Producto.getAllProducts());
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            /////// ESTA FUNCION OBLIGA A QUE EL USUARIO A REALIZAR UNA SOLA OPERACION: CANCELAR O AÑADIR
            if (dgvProductosV.Rows.Count == 1) ///SI SELECCIONO ALGO
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscarNombre_Click(object sender, EventArgs e)
        {
            this.Close();///no va
        }
    }
}
