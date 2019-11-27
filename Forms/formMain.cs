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
            /////////////////////////////////////// ES UNA FUNCION DE PRUEBA, ABIERTA A OTRAS SOLUCIONES
            // formProductosV nuevo = new formProductosV();
            //nuevo.Show();
            formProductos nuevoV = new formProductos();   ///llamo a la ventana productosV
            nuevoV.Show();

            //nuevoV.ShowDialog();  ///duncion para que tenga ponga cancelar o añadir nada mas

            //Int32 cantDada = Convert.ToInt32(textCantidad);

            /// puede ser una sola condicion con &
            /*
            if (nuevoV.DialogResult == DialogResult.OK)
            {
                if (Producto.validarCantidad(this, errorProvCant, cantDada) == false)
                {
                    Boolean existe = false;
                    int numFila = 0;
                    
                    if ((contFila == 0))  /// por primera vez q se ingresa algo en la factura
                    {
                        ColumnCodigo.DataPropertyName = nuevoV.dgvProductosV.Rows[nuevoV.dgvProductosV.CurrentRow.Index].Cells[0].Value.ToString();  /// relleno el codigo desde dgvProductoV
                        ColumnCantidad.DataPropertyName = cantDada.ToString();  /// duda con el tipo de dato, ingreso la cantidad en la dgvCarrrito
                        ColumnMarca.DataPropertyName = nuevoV.dgvProductosV.Rows[nuevoV.dgvProductosV.CurrentRow.Index].Cells[1].Value.ToString();  /// relleno la marca desde dgvProductoV
                        ColumnNombre.DataPropertyName = nuevoV.dgvProductosV.Rows[nuevoV.dgvProductosV.CurrentRow.Index].Cells[2].Value.ToString();  ///relleno el nombre desde dgvProductoV
                        ColumnPrecio.DataPropertyName = nuevoV.dgvProductosV.Rows[nuevoV.dgvProductosV.CurrentRow.Index].Cells[6].Value.ToString();  ///pongo el precio
                        ColumnTalle.DataPropertyName = nuevoV.dgvProductosV.Rows[nuevoV.dgvProductosV.CurrentRow.Index].Cells[3].Value.ToString();  /// relleno el talledesde dgvProductoV
                        ColumnColor.DataPropertyName = nuevoV.dgvProductosV.Rows[nuevoV.dgvProductosV.CurrentRow.Index].Cells[4].Value.ToString();  /// relleno el color desde dgvProductoV
                        double importe = ((Convert.ToDouble(dgvCarrito.Rows[contFila].Cells[6].Value)) * (Convert.ToDouble(dgvCarrito.Rows[contFila].Cells[5].Value)));  ///multiplico donde se ubica el precio y la cantidad;
                        dgvCarrito.Rows[contFila].Cells[7].Value = importe; ///pongo el total calculado en la columna importe del carrito
                        contFila++;
                        total = importe;
                        ///SON COLUMNAS DE PRUEBA REEMPLAZANDO A DESCRIPCION.....
                    }

                    else
                    {
                        foreach (DataGridViewRow Fila in dgvCarrito.Rows) ///me fijo uno x uno en el carrito
                        {
                            if (Fila.Cells[0].Value.ToString() == nuevoV.dgvProductosV.Rows[nuevoV.dgvProductosV.CurrentRow.Index].Cells[0].Value.ToString())
                            {
                                existe = true;
                                numFila = Fila.Index;
                            }
                        }

                        if (existe == true)  ///si el codigo existe entonces solamente se modifica la cantidad
                        {
                            dgvCarrito.Rows[numFila].Cells[5].Value = (cantDada + dgvCarrito.Rows[numFila].Cells[5].Value.ToString()); ///sumo las cantidades
                            double importe = ((Convert.ToDouble(dgvCarrito.Rows[contFila].Cells[6].Value)) * (Convert.ToDouble(dgvCarrito.Rows[numFila].Cells[5].Value)));  ///multiplico donde se ubica el precio y la cantidad;
                            dgvCarrito.Rows[numFila].Cells[7].Value = importe; ///ponfo el importe en la agvCarrito
                            textTotal.Text = (total + importe).ToString(); ///mucha duda, voy sumando cada importe al total
                        }
                        else
                        {
                            ColumnCodigo.DataPropertyName = nuevoV.dgvProductosV.Rows[nuevoV.dgvProductosV.CurrentRow.Index].Cells[0].Value.ToString();  /// relleno el codigo desde dgvProductoV
                            ColumnCantidad.DataPropertyName = cantDada.ToString();  /// duda con el tipo de dato, ingreso la cantidad en la dgvCarrrito
                            ColumnMarca.DataPropertyName = nuevoV.dgvProductosV.Rows[nuevoV.dgvProductosV.CurrentRow.Index].Cells[1].Value.ToString();  /// relleno la marca desde dgvProductoV
                            ColumnNombre.DataPropertyName = nuevoV.dgvProductosV.Rows[nuevoV.dgvProductosV.CurrentRow.Index].Cells[2].Value.ToString();  ///relleno el nombre desde dgvProductoV
                            ColumnPrecio.DataPropertyName = nuevoV.dgvProductosV.Rows[nuevoV.dgvProductosV.CurrentRow.Index].Cells[6].Value.ToString();  ///pongo el precio
                            ColumnTalle.DataPropertyName = nuevoV.dgvProductosV.Rows[nuevoV.dgvProductosV.CurrentRow.Index].Cells[3].Value.ToString();  /// relleno el talledesde dgvProductoV
                            ColumnColor.DataPropertyName = nuevoV.dgvProductosV.Rows[nuevoV.dgvProductosV.CurrentRow.Index].Cells[4].Value.ToString();  /// relleno el color desde dgvProductoV
                            double importe = ((Convert.ToDouble(dgvCarrito.Rows[contFila].Cells[6].Value)) * (Convert.ToDouble(dgvCarrito.Rows[contFila].Cells[5].Value)));  ///multiplico donde se ubica el precio y la cantidad;
                            dgvCarrito.Rows[contFila].Cells[7].Value = importe; ///pongo el total calculado en la columna importe del carrito
                            textTotal.Text = (total + importe).ToString();///mucha duda, voy sumando cada importe al total
                            contFila++;

                        }





                    }
                }

            }
            */
        }

        private void BtnVaciarCarrito_Click(object sender, EventArgs e)
        {
            //queremos que vacíe el carrito
            dgvCarrito.Rows.Clear();
            textCantidad.Text = "";
            contFila =0;
            textTotal.Text = "";

        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            //finalize stock y avisos...
        }
    }
}
