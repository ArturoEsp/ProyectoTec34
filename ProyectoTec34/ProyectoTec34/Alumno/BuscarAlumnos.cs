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
    public partial class BuscarAlumnos : Form
    {
        public BuscarAlumnos()
        {
            InitializeComponent();
            tbBuscar.AutoCompleteCustomSource = ScriptSQL.AutoCompletarBuscar();
            tbBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnPrimerBoleta_Click(object sender, EventArgs e)
        {
            FormularioBoleta1 frm = new FormularioBoleta1();
            frm.Show();
        }

        private void btnSegBoleta_Click(object sender, EventArgs e)
        {
            FormularioBoleta2 frm = new FormularioBoleta2();
            frm.Show();
        }

        private void btnTercerBoleta_Click(object sender, EventArgs e)
        {
            FormularioBoleta3 frm = new FormularioBoleta3();
            frm.Show();
        }

    }
}
