namespace TPF_Laboratorio_de_Programacion
{
    partial class formAgregar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAgregar));
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTalle = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.blPrecio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.errProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMarca = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.txtStock = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.txtColor = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.txtTalle = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.txtPrecio = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.txtNombre = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMarca.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(21, 48);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(21, 71);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 13);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color:";
            // 
            // lblTalle
            // 
            this.lblTalle.AutoSize = true;
            this.lblTalle.BackColor = System.Drawing.Color.Transparent;
            this.lblTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTalle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalle.Location = new System.Drawing.Point(21, 93);
            this.lblTalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTalle.Name = "lblTalle";
            this.lblTalle.Size = new System.Drawing.Size(43, 13);
            this.lblTalle.TabIndex = 5;
            this.lblTalle.Text = "Talle:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(21, 116);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 13);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock:";
            // 
            // blPrecio
            // 
            this.blPrecio.AutoSize = true;
            this.blPrecio.BackColor = System.Drawing.Color.Transparent;
            this.blPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blPrecio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blPrecio.Location = new System.Drawing.Point(21, 139);
            this.blPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blPrecio.Name = "blPrecio";
            this.blPrecio.Size = new System.Drawing.Size(52, 13);
            this.blPrecio.TabIndex = 7;
            this.blPrecio.Text = "Precio:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::TPF_Laboratorio_de_Programacion.Properties.Resources.button1;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(23, 182);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 24);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseDown);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Transparent;
            this.btnCargar.BackgroundImage = global::TPF_Laboratorio_de_Programacion.Properties.Resources.button1;
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Location = new System.Drawing.Point(209, 182);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(89, 24);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            this.btnCargar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCargar_MouseDown);
            this.btnCargar.MouseEnter += new System.EventHandler(this.btnCargar_MouseEnter);
            this.btnCargar.MouseLeave += new System.EventHandler(this.btnCargar_MouseLeave);
            // 
            // errProv
            // 
            this.errProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProv.ContainerControl = this;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.DarkGray;
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(96, 46);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(203, 21);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.Validar = true;
            this.txtMarca.ValidarDoble = false;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.DarkGray;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStock.Location = new System.Drawing.Point(96, 114);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(203, 21);
            this.txtStock.TabIndex = 4;
            this.txtStock.Validar = true;
            this.txtStock.ValidarDoble = false;
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.DarkGray;
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColor.Location = new System.Drawing.Point(96, 68);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(203, 21);
            this.txtColor.TabIndex = 2;
            this.txtColor.Validar = true;
            this.txtColor.ValidarDoble = false;
            // 
            // txtTalle
            // 
            this.txtTalle.BackColor = System.Drawing.Color.DarkGray;
            this.txtTalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTalle.Location = new System.Drawing.Point(96, 91);
            this.txtTalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTalle.Name = "txtTalle";
            this.txtTalle.Size = new System.Drawing.Size(203, 21);
            this.txtTalle.TabIndex = 3;
            this.txtTalle.Validar = true;
            this.txtTalle.ValidarDoble = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.DarkGray;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecio.Location = new System.Drawing.Point(96, 136);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(203, 21);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.Validar = true;
            this.txtPrecio.ValidarDoble = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.DarkGray;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(96, 23);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(203, 21);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Validar = true;
            this.txtNombre.ValidarDoble = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 25);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 13);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre:";
            // 
            // formAgregar
            // 
            this.AcceptButton = this.btnCargar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(323, 232);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtTalle);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.blPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblTalle);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblMarca);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(339, 271);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(339, 271);
            this.Name = "formAgregar";
            this.Text = "Nuevo Producto";
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblTalle;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label blPrecio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.ErrorProvider errProv;
        private ErrorTextBox txtMarca;
        private ErrorTextBox txtStock;
        private ErrorTextBox txtColor;
        private ErrorTextBox txtTalle;
        private ErrorTextBox txtPrecio;
        private ErrorTextBox txtNombre;
        // private TPF_Laboratorio_de_Programacion.Classes.ErrorTextBox;
    }
}