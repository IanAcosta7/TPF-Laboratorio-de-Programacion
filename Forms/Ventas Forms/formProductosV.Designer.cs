namespace TPF_Laboratorio_de_Programacion.Forms.Ventas_Forms
{
    partial class formProductosV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProductosV));
            this.dgvProductosV = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.errorTextBox1 = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductosV
            // 
            this.dgvProductosV.AllowUserToAddRows = false;
            this.dgvProductosV.AllowUserToDeleteRows = false;
            this.dgvProductosV.AllowUserToOrderColumns = true;
            this.dgvProductosV.AllowUserToResizeColumns = false;
            this.dgvProductosV.AllowUserToResizeRows = false;
            this.dgvProductosV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductosV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosV.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvProductosV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colMarca,
            this.colNombre,
            this.colColor,
            this.colTalle,
            this.colStock,
            this.colPrecio});
            this.dgvProductosV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProductosV.Location = new System.Drawing.Point(28, 57);
            this.dgvProductosV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProductosV.MultiSelect = false;
            this.dgvProductosV.Name = "dgvProductosV";
            this.dgvProductosV.ReadOnly = true;
            this.dgvProductosV.RowHeadersVisible = false;
            this.dgvProductosV.RowHeadersWidth = 51;
            this.dgvProductosV.RowTemplate.Height = 24;
            this.dgvProductosV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductosV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosV.Size = new System.Drawing.Size(521, 222);
            this.dgvProductosV.TabIndex = 5;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.MinimumWidth = 6;
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colColor
            // 
            this.colColor.HeaderText = "Color";
            this.colColor.MinimumWidth = 6;
            this.colColor.Name = "colColor";
            this.colColor.ReadOnly = true;
            // 
            // colTalle
            // 
            this.colTalle.HeaderText = "Talle";
            this.colTalle.MinimumWidth = 6;
            this.colTalle.Name = "colTalle";
            this.colTalle.ReadOnly = true;
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
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarNombre.BackgroundImage = global::TPF_Laboratorio_de_Programacion.Properties.Resources.button1_0;
            this.btnBuscarNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarNombre.FlatAppearance.BorderSize = 0;
            this.btnBuscarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNombre.Location = new System.Drawing.Point(97, 20);
            this.btnBuscarNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(89, 19);
            this.btnBuscarNombre.TabIndex = 8;
            this.btnBuscarNombre.Text = "Buscar Nombre:";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.BtnBuscarNombre_Click);
            this.btnBuscarNombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBuscarNombre_MouseDown);
            this.btnBuscarNombre.MouseEnter += new System.EventHandler(this.btnBuscarNombre_MouseEnter);
            this.btnBuscarNombre.MouseLeave += new System.EventHandler(this.btnBuscarNombre_MouseLeave);
            // 
            // errorTextBox1
            // 
            this.errorTextBox1.BackColor = System.Drawing.Color.White;
            this.errorTextBox1.Location = new System.Drawing.Point(217, 20);
            this.errorTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.errorTextBox1.Name = "errorTextBox1";
            this.errorTextBox1.Size = new System.Drawing.Size(237, 20);
            this.errorTextBox1.TabIndex = 9;
            this.errorTextBox1.Validar = false;
            this.errorTextBox1.ValidarDoble = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackgroundImage = global::TPF_Laboratorio_de_Programacion.Properties.Resources.button1_0;
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(393, 305);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(59, 24);
            this.btnAñadir.TabIndex = 10;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAñadir_MouseDown);
            this.btnAñadir.MouseEnter += new System.EventHandler(this.btnAñadir_MouseEnter);
            this.btnAñadir.MouseLeave += new System.EventHandler(this.btnAñadir_MouseLeave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackgroundImage = global::TPF_Laboratorio_de_Programacion.Properties.Resources.button1_0;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(137, 305);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(59, 24);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            this.btnCancelar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseDown);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // formProductosV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.errorTextBox1);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.dgvProductosV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formProductosV";
            this.Text = "Lista de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarNombre;
        private ErrorTextBox errorTextBox1;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.DataGridView dgvProductosV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
    }
}