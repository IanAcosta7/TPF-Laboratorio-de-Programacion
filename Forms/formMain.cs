﻿using System;
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
    }
}
