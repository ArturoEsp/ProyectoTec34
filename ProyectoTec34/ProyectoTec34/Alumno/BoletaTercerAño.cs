﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTec34.Alumno
{
    public partial class BoletaTercerAño : Form
    {
        public BoletaTercerAño()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            BoletaSegundoAño frm = new BoletaSegundoAño();
            frm.Show();
            this.Close();
        }
    }
}
