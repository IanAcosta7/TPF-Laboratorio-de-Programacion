﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPF_Laboratorio_de_Programacion
{
    public partial class ErrorTextBox : TextBox
    {
        public ErrorTextBox()
        {
            InitializeComponent();
        }

        public Boolean Validar 
        {
            get;
            set;
        }

      
    }
}
