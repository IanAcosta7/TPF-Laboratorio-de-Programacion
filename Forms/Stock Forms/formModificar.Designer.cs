namespace TPF_Laboratorio_de_Programacion
{
    partial class formModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formModificar));
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombre = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.txtMarca = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.txtStock = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.txtColor = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.txtTalle = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.txtPrecio = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.blPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblTalle = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.errProv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImage = global::TPF_Laboratorio_de_Programacion.Properties.Resources.button1;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(179, 182);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(76, 24);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            this.btnActualizar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnActualizar_MouseDown);
            this.btnActualizar.MouseEnter += new System.EventHandler(this.btnActualizar_MouseEnter);
            this.btnActualizar.MouseLeave += new System.EventHandler(this.btnActualizar_MouseLeave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::TPF_Laboratorio_de_Programacion.Properties.Resources.button1;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(20, 182);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 24);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            this.btnCancelar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseDown);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.DarkGray;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(82, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.Validar = true;
            this.txtNombre.ValidarDoble = true;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.DarkGray;
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(82, 55);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(174, 20);
            this.txtMarca.TabIndex = 20;
            this.txtMarca.Validar = true;
            this.txtMarca.ValidarDoble = false;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.DarkGray;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStock.Location = new System.Drawing.Point(82, 124);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(174, 20);
            this.txtStock.TabIndex = 25;
            this.txtStock.Validar = true;
            this.txtStock.ValidarDoble = false;
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.DarkGray;
            this.txtColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColor.Location = new System.Drawing.Point(82, 78);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(174, 20);
            this.txtColor.TabIndex = 22;
            this.txtColor.Validar = true;
            this.txtColor.ValidarDoble = false;
            // 
            // txtTalle
            // 
            this.txtTalle.BackColor = System.Drawing.Color.DarkGray;
            this.txtTalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTalle.Location = new System.Drawing.Point(82, 101);
            this.txtTalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTalle.Name = "txtTalle";
            this.txtTalle.Size = new System.Drawing.Size(174, 20);
            this.txtTalle.TabIndex = 23;
            this.txtTalle.Validar = true;
            this.txtTalle.ValidarDoble = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.DarkGray;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecio.Location = new System.Drawing.Point(82, 146);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(174, 20);
            this.txtPrecio.TabIndex = 27;
            this.txtPrecio.Validar = true;
            this.txtPrecio.ValidarDoble = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(18, 35);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 13);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre:";
            // 
            // blPrecio
            // 
            this.blPrecio.AutoSize = true;
            this.blPrecio.BackColor = System.Drawing.Color.Transparent;
            this.blPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blPrecio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blPrecio.Location = new System.Drawing.Point(18, 149);
            this.blPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blPrecio.Name = "blPrecio";
            this.blPrecio.Size = new System.Drawing.Size(52, 13);
            this.blPrecio.TabIndex = 30;
            this.blPrecio.Text = "Precio:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(18, 126);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 13);
            this.lblStock.TabIndex = 29;
            this.lblStock.Text = "Stock:";
            // 
            // lblTalle
            // 
            this.lblTalle.AutoSize = true;
            this.lblTalle.BackColor = System.Drawing.Color.Transparent;
            this.lblTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTalle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalle.Location = new System.Drawing.Point(18, 103);
            this.lblTalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTalle.Name = "lblTalle";
            this.lblTalle.Size = new System.Drawing.Size(43, 13);
            this.lblTalle.TabIndex = 28;
            this.lblTalle.Text = "Talle:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(18, 80);
            this.lblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 13);
            this.lblColor.TabIndex = 26;
            this.lblColor.Text = "Color:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCodigo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(18, 12);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(55, 13);
            this.lblCodigo.TabIndex = 24;
            this.lblCodigo.Text = "Código:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMarca.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(18, 58);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 13);
            this.lblMarca.TabIndex = 21;
            this.lblMarca.Text = "Marca:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.DarkGray;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCodigo.Location = new System.Drawing.Point(82, 10);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(174, 20);
            this.txtCodigo.TabIndex = 19;
            this.txtCodigo.TabStop = false;
            // 
            // errProv
            // 
            this.errProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProv.ContainerControl = this;
            // 
            // formModificar
            // 
            this.AcceptButton = this.btnActualizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(277, 232);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtTalle);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.blPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblTalle);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(293, 271);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(293, 271);
            this.Name = "formModificar";
            this.Text = "Modificar producto";
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private ErrorTextBox txtNombre;
        private ErrorTextBox txtMarca;
        private ErrorTextBox txtStock;
        private ErrorTextBox txtColor;
        private ErrorTextBox txtTalle;
        private ErrorTextBox txtPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label blPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblTalle;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.ErrorProvider errProv;
    }
}