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
    public partial class BoletaPrimerAño : Form
    {
        public BoletaPrimerAño(/*string IDAlumno*/)
        {
            InitializeComponent();
            //ScriptSQL.MostrarBoletaPrimer(IDAlumno,tbNombreAlumno,tbCURP,tbGrupo);
        }

        private void BoletaPrimerAño_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            BoletaSegundoAño frm = new BoletaSegundoAño();
            frm.Show();
            this.Close();
        }
    }
}
