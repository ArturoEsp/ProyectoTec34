﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTec34.Home
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
      
        }
        TimeSpan _elapsed = new TimeSpan();
        public Boolean AbrirFormHijo(object formhijo)
        {

            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;

            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;

            fh.Show();
            return true;

        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            Application.Restart();
            //this.Close();
            //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Login.Login);
            //if (frm != null)
            //{
            //    frm.BringToFront();
            //    return;
            //}
            //frm = new Login.Login();
            //frm.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Alumno.BuscarAlumno frm = new Alumno.BuscarAlumno();
            frm.ShowDialog();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Alumno.IndexAlumnos());
        }


        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            AcercaDe.Acercade frm = new AcercaDe.Acercade();
            frm.Show();

        }

        private void timerAct_Tick(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            _elapsed = _elapsed.Add(TimeSpan.FromSeconds(1));
            lblTiempoAct.Text = _elapsed.ToString();

 
            lblHora.Text = DateTime.Now.ToString("hh:mm tt", CultureInfo.InvariantCulture);
            lblFecha.Text = DateTime.Now.ToLongDateString();

        }

        private void Index_SizeChanged(object sender, EventArgs e)
        {
            this.pnlContenedor.Left = this.Width / 2;
        }
    }
}
