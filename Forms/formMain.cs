using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPF_Laboratorio_de_Programacion.Forms.Ventas_Forms;

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
            this.actualizarDVGVentas(Compra.getAllCompras());
        }

        public void actualizarDVGStock(DataTable productos)
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

        public void actualizarDVGVentas(DataTable compras)
        {
            // Se cargan los datos en el DGV
            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.DataSource = compras;

            // Se insertan los datos en cada columna
            colDescripcion.DataPropertyName = "descripcion";
            ColCantidad.DataPropertyName = "cantidad";
            colPrice.DataPropertyName = "precio";
            colImporte.DataPropertyName = "importe";

            textTotal.Text = Compra.getTotal().ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 1)
            {
                DataGridViewCellCollection data = dgvStock.SelectedRows[0].Cells;

                // Borro el proucto
                Producto.borrarProducto(data[0].Value.ToString());
                this.actualizarDVGStock(Producto.getAllProducts());
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún producto.");
            }
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_1;
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_0;
        }

        private void btnAgregar_MouseDown(object sender, MouseEventArgs e)
        {
            btnAgregar.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_2;

        }

        private void btnModificar_MouseEnter(object sender, EventArgs e)
        {
            btnModificar.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_1;

        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_0;

        }

        private void btnModificar_MouseDown(object sender, MouseEventArgs e)
        {
            btnModificar.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_2;

        }

        private void btnBorrar_MouseEnter(object sender, EventArgs e)
        {
            btnBorrar.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_1;

        }

        private void btnBorrar_MouseLeave(object sender, EventArgs e)
        {
            btnBorrar.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_0;

        }

        private void btnBorrar_MouseDown(object sender, MouseEventArgs e)
        {
            btnBorrar.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_2;

        }

        private void btnAñadir_MouseEnter(object sender, EventArgs e)
        {
            btnAñadirPdto.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_1;

        }

        private void btnAñadir_MouseLeave(object sender, EventArgs e)
        {
            btnAñadirPdto.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_0;

        }

        private void btnAñadir_MouseDown(object sender, MouseEventArgs e)
        {
            btnAñadirPdto.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_2;

        }

        private void btnVaciarCarrito_MouseEnter(object sender, EventArgs e)
        {
            btnVaciarCarrito.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_1;

        }

        private void btnVaciarCarrito_MouseLeave(object sender, EventArgs e)
        {
            btnVaciarCarrito.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_0;

        }

        private void btnVaciarCarrito_MouseDown(object sender, MouseEventArgs e)
        {
            btnVaciarCarrito.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_2;

        }

        private void btnFinalizarVenta_MouseEnter(object sender, EventArgs e)
        {
            btnFinalizarVenta.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_1;

        }

        private void btnFinalizarVenta_MouseLeave(object sender, EventArgs e)
        {
            btnFinalizarVenta.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_0;

        }

        private void btnFinalizarVenta_MouseDown(object sender, MouseEventArgs e)
        {
            btnFinalizarVenta.BackgroundImage = TPF_Laboratorio_de_Programacion.Properties.Resources.button1_2;

        }

        public static int contFila = 0;
        public static double total;

        private void BtnAñadirPdto_Click(object sender, EventArgs e)
        {
            formProductos nuevoV = new formProductos();   ///llamo a la ventana productosV
            nuevoV.Show();
        }

        private void BtnVaciarCarrito_Click(object sender, EventArgs e)
        {
            Compra.vaciarCompras();
            actualizarDVGVentas(Compra.getAllCompras());
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            //finalize stock y avisos...
            Compra.vaciarCompras();
            this.actualizarDVGVentas(Compra.getAllCompras());
            MessageBox.Show("Se ha producido la venta");
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textBuscar.Text.Trim().ToString(); ///lo que tengo en la caja de texto lo convierto en string
            this.actualizarDVGStock(Producto.getProductByNameBuscar(busqueda));
        }
    }
}
