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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTalle = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.blPrecio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTextBox5 = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.errorTextBox4 = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.errorTextBox3 = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.errorTextBox2 = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.errorTextBox1 = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            this.errorTextBox6 = new TPF_Laboratorio_de_Programacion.ErrorTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(67, 126);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(57, 17);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(67, 175);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(51, 17);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color:";
            // 
            // lblTalle
            // 
            this.lblTalle.AutoSize = true;
            this.lblTalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalle.Location = new System.Drawing.Point(67, 221);
            this.lblTalle.Name = "lblTalle";
            this.lblTalle.Size = new System.Drawing.Size(49, 17);
            this.lblTalle.TabIndex = 5;
            this.lblTalle.Text = "Talle:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(67, 274);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(53, 17);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock:";
            // 
            // blPrecio
            // 
            this.blPrecio.AutoSize = true;
            this.blPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blPrecio.Location = new System.Drawing.Point(67, 325);
            this.blPrecio.Name = "blPrecio";
            this.blPrecio.Size = new System.Drawing.Size(59, 17);
            this.blPrecio.TabIndex = 7;
            this.blPrecio.Text = "Precio:";
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.Location = new System.Drawing.Point(153, 123);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(293, 22);
            this.txtMarca.TabIndex = 1;
            // 
            // txtColor
            // 
            this.txtColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColor.Location = new System.Drawing.Point(153, 172);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(293, 22);
            this.txtColor.TabIndex = 2;
            // 
            // txtTalle
            // 
            this.txtTalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTalle.Location = new System.Drawing.Point(153, 218);
            this.txtTalle.Name = "txtTalle";
            this.txtTalle.Size = new System.Drawing.Size(293, 22);
            this.txtTalle.TabIndex = 3;
            // 
            // txtStock
            // 
            this.txtStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStock.Location = new System.Drawing.Point(153, 271);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(293, 22);
            this.txtStock.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecio.Location = new System.Drawing.Point(153, 322);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(293, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(70, 388);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 29);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCargar.Location = new System.Drawing.Point(345, 388);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(101, 29);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCodigo.Location = new System.Drawing.Point(153, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(293, 22);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(67, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 17);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código:";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(153, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(293, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(67, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 17);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorTextBox5
            // 
            this.errorTextBox5.Location = new System.Drawing.Point(153, 121);
            this.errorTextBox5.Name = "errorTextBox5";
            this.errorTextBox5.Size = new System.Drawing.Size(231, 22);
            this.errorTextBox5.TabIndex = 22;
            this.errorTextBox5.Validar = true;
            // 
            // errorTextBox4
            // 
            this.errorTextBox4.Location = new System.Drawing.Point(149, 271);
            this.errorTextBox4.Name = "errorTextBox4";
            this.errorTextBox4.Size = new System.Drawing.Size(231, 22);
            this.errorTextBox4.TabIndex = 21;
            this.errorTextBox4.Validar = true;
            // 
            // errorTextBox3
            // 
            this.errorTextBox3.Location = new System.Drawing.Point(149, 170);
            this.errorTextBox3.Name = "errorTextBox3";
            this.errorTextBox3.Size = new System.Drawing.Size(231, 22);
            this.errorTextBox3.TabIndex = 20;
            this.errorTextBox3.Validar = true;
            // 
            // errorTextBox2
            // 
            this.errorTextBox2.Location = new System.Drawing.Point(149, 216);
            this.errorTextBox2.Name = "errorTextBox2";
            this.errorTextBox2.Size = new System.Drawing.Size(231, 22);
            this.errorTextBox2.TabIndex = 19;
            this.errorTextBox2.Validar = true;
            // 
            // errorTextBox1
            // 
            this.errorTextBox1.Location = new System.Drawing.Point(149, 320);
            this.errorTextBox1.Name = "errorTextBox1";
            this.errorTextBox1.Size = new System.Drawing.Size(231, 22);
            this.errorTextBox1.TabIndex = 18;
            this.errorTextBox1.Validar = true;
            // 
            // errorTextBox6
            // 
            this.errorTextBox6.Location = new System.Drawing.Point(167, 73);
            this.errorTextBox6.Name = "errorTextBox6";
            this.errorTextBox6.Size = new System.Drawing.Size(100, 22);
            this.errorTextBox6.TabIndex = 23;
            this.errorTextBox6.Validar = true;
            // 
            // formAgregar
            // 
            this.AcceptButton = this.btnCargar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(512, 455);
            this.Controls.Add(this.errorTextBox6);
            this.Controls.Add(this.errorTextBox5);
            this.Controls.Add(this.errorTextBox4);
            this.Controls.Add(this.errorTextBox3);
            this.Controls.Add(this.errorTextBox2);
            this.Controls.Add(this.errorTextBox1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.blPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblTalle);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtCodigo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 500);
            this.Name = "formAgregar";
            this.Text = "Nuevo Producto";
            this.Load += new System.EventHandler(this.FormAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private ErrorTextBox errorTextBox5;
        private ErrorTextBox errorTextBox4;
        private ErrorTextBox errorTextBox3;
        private ErrorTextBox errorTextBox2;
        private ErrorTextBox errorTextBox1;
        private ErrorTextBox errorTextBox6;
        // private TPF_Laboratorio_de_Programacion.Classes.ErrorTextBox;
    }
}