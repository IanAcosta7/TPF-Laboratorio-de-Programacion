namespace TPF_Laboratorio_de_Programacion
{
    partial class formMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.btnVaciarCarrito = new System.Windows.Forms.Button();
            this.dvgCarrito = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.tabCaja = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.tabPage.SuspendLayout();
            this.tabStock.SuspendLayout();
            this.tabVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCarrito)).BeginInit();
            this.tabCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::TPF_Laboratorio_de_Programacion.Properties.Resources.button1;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(9, 15);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 15, 15, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAgregar_MouseDown);
            this.btnAgregar.MouseEnter += new System.EventHandler(this.btnAgregar_MouseEnter);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::TPF_Laboratorio_de_Programacion.Properties.Resources.button1;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(224, 15);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 15, 15, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(91, 30);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            this.btnBorrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBorrar_MouseDown);
            this.btnBorrar.MouseEnter += new System.EventHandler(this.btnBorrar_MouseEnter);
            this.btnBorrar.MouseLeave += new System.EventHandler(this.btnBorrar_MouseLeave);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::TPF_Laboratorio_de_Programacion.Properties.Resources.button1;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(116, 15);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 15, 15, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 30);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModificar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnModificar_MouseDown);
            this.btnModificar.MouseEnter += new System.EventHandler(this.btnModificar_MouseEnter);
            this.btnModificar.MouseLeave += new System.EventHandler(this.btnModificar_MouseLeave);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToOrderColumns = true;
            this.dgvStock.AllowUserToResizeColumns = false;
            this.dgvStock.AllowUserToResizeRows = false;
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colMarca,
            this.colStock,
            this.colPrecio,
            this.colTalle,
            this.colColor,
            this.colCodigo});
            this.dgvStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStock.Location = new System.Drawing.Point(8, 55);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(827, 417);
            this.dgvStock.TabIndex = 4;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.MinimumWidth = 6;
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colTalle
            // 
            this.colTalle.HeaderText = "Talle";
            this.colTalle.MinimumWidth = 6;
            this.colTalle.Name = "colTalle";
            this.colTalle.ReadOnly = true;
            // 
            // colColor
            // 
            this.colColor.HeaderText = "Color";
            this.colColor.MinimumWidth = 6;
            this.colColor.Name = "colColor";
            this.colColor.ReadOnly = true;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabStock);
            this.tabPage.Controls.Add(this.tabVentas);
            this.tabPage.Controls.Add(this.tabCaja);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage.Location = new System.Drawing.Point(0, 0);
            this.tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(851, 518);
            this.tabPage.TabIndex = 5;
            // 
            // tabStock
            // 
            this.tabStock.BackColor = System.Drawing.Color.Transparent;
            this.tabStock.Controls.Add(this.dgvStock);
            this.tabStock.Controls.Add(this.btnModificar);
            this.tabStock.Controls.Add(this.btnAgregar);
            this.tabStock.Controls.Add(this.btnBorrar);
            this.tabStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabStock.Location = new System.Drawing.Point(4, 26);
            this.tabStock.Margin = new System.Windows.Forms.Padding(4);
            this.tabStock.Name = "tabStock";
            this.tabStock.Padding = new System.Windows.Forms.Padding(4);
            this.tabStock.Size = new System.Drawing.Size(843, 488);
            this.tabStock.TabIndex = 0;
            this.tabStock.Text = "Stock";
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.btnFinalizarVenta);
            this.tabVentas.Controls.Add(this.btnVaciarCarrito);
            this.tabVentas.Controls.Add(this.dvgCarrito);
            this.tabVentas.Controls.Add(this.btnAñadir);
            this.tabVentas.Location = new System.Drawing.Point(4, 26);
            this.tabVentas.Margin = new System.Windows.Forms.Padding(4);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Size = new System.Drawing.Size(843, 488);
            this.tabVentas.TabIndex = 2;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarVenta.BackgroundImage = global::TPF_Laboratorio_de_Programacion.Properties.Resources.button1;
            this.btnFinalizarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalizarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarVenta.FlatAppearance.BorderSize = 0;
            this.btnFinalizarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarVenta.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenta.Location = new System.Drawing.Point(683, 448);
            this.btnFinalizarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(153, 39);
            this.btnFinalizarVenta.TabIndex = 15;
            this.btnFinalizarVenta.Text = "Finalizar Venta";
            this.btnFinalizarVenta.UseVisualStyleBackColor = true;
            // 
            // btnVaciarCarrito
            // 
            this.btnVaciarCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVaciarCarrito.BackgroundImage = global::TPF_Laboratorio_de_Programacion.Properties.Resources.button1;
            this.btnVaciarCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVaciarCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaciarCarrito.FlatAppearance.BorderSize = 0;
            this.btnVaciarCarrito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVaciarCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVaciarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciarCarrito.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciarCarrito.Location = new System.Drawing.Point(505, 448);
            this.btnVaciarCarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVaciarCarrito.Name = "btnVaciarCarrito";
            this.btnVaciarCarrito.Size = new System.Drawing.Size(153, 39);
            this.btnVaciarCarrito.TabIndex = 14;
            this.btnVaciarCarrito.Text = "Vaciar Carrito";
            this.btnVaciarCarrito.UseVisualStyleBackColor = true;
            // 
            // dvgCarrito
            // 
            this.dvgCarrito.AllowUserToAddRows = false;
            this.dvgCarrito.AllowUserToDeleteRows = false;
            this.dvgCarrito.AllowUserToOrderColumns = true;
            this.dvgCarrito.AllowUserToResizeColumns = false;
            this.dvgCarrito.AllowUserToResizeRows = false;
            this.dvgCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion});
            this.dvgCarrito.Cursor = System.Windows.Forms.Cursors.Default;
            this.dvgCarrito.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgCarrito.Location = new System.Drawing.Point(8, 57);
            this.dvgCarrito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgCarrito.MultiSelect = false;
            this.dvgCarrito.Name = "dvgCarrito";
            this.dvgCarrito.ReadOnly = true;
            this.dvgCarrito.RowHeadersVisible = false;
            this.dvgCarrito.RowHeadersWidth = 51;
            this.dvgCarrito.RowTemplate.Height = 24;
            this.dvgCarrito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvgCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCarrito.Size = new System.Drawing.Size(827, 386);
            this.dvgCarrito.TabIndex = 11;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackgroundImage = global::TPF_Laboratorio_de_Programacion.Properties.Resources.button1;
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(8, 14);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(91, 30);
            this.btnAñadir.TabIndex = 9;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            this.btnAñadir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAñadir_MouseDown);
            this.btnAñadir.MouseEnter += new System.EventHandler(this.btnAñadir_MouseEnter);
            this.btnAñadir.MouseLeave += new System.EventHandler(this.btnAñadir_MouseLeave);
            // 
            // tabCaja
            // 
            this.tabCaja.Controls.Add(this.lblTotal);
            this.tabCaja.Controls.Add(this.dataGridView1);
            this.tabCaja.Location = new System.Drawing.Point(4, 26);
            this.tabCaja.Margin = new System.Windows.Forms.Padding(4);
            this.tabCaja.Name = "tabCaja";
            this.tabCaja.Padding = new System.Windows.Forms.Padding(4);
            this.tabCaja.Size = new System.Drawing.Size(843, 488);
            this.tabCaja.TabIndex = 1;
            this.tabCaja.Text = "Caja";
            this.tabCaja.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(8, 466);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 17);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtDescripcion,
            this.txtCantidad,
            this.txtFecha});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(827, 449);
            this.dataGridView1.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.HeaderText = "Descripción";
            this.txtDescripcion.MinimumWidth = 6;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.HeaderText = "Cantidad";
            this.txtCantidad.MinimumWidth = 6;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            // 
            // txtFecha
            // 
            this.txtFecha.HeaderText = "Fecha";
            this.txtFecha.MinimumWidth = 6;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::TPF_Laboratorio_de_Programacion.Properties.Resources.fotito;
            this.ClientSize = new System.Drawing.Size(851, 518);
            this.Controls.Add(this.tabPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(850, 515);
            this.Name = "formMain";
            this.Text = "Nombre del programa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.tabPage.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCarrito)).EndInit();
            this.tabCaja.ResumeLayout(false);
            this.tabCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.TabPage tabCaja;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFecha;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.DataGridView dvgCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Button btnFinalizarVenta;
        private System.Windows.Forms.Button btnVaciarCarrito;
    }
}

