using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProyectoTec34.Home
{
    public partial class Index : Form
    {
        public Index(string Usuario)
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
            //Configuraciones.BackupAutomatic.Backup();
      
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
            if (MessageBox.Show("¿Desea salir del programa?","Advertencia",MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Alumno.BuscarAlumno frm = new Alumno.BuscarAlumno();
            btnBuscar.BackColor = Color.FromArgb(183, 190, 188);
            btnAlumnos.BackColor = Color.Transparent;
            btnConf.BackColor = Color.Transparent;
            frm.ShowDialog();
            
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Alumno.IndexAlumnos());
            btnAlumnos.BackColor = Color.FromArgb(183, 190, 188);
            btnConf.BackColor = Color.Transparent;
            btnBuscar.BackColor = Color.Transparent;
        }


        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            AcercaDe.Acercade frm = new AcercaDe.Acercade();
            frm.Show();

        }

        private void timerAct_Tick(object sender, EventArgs e)
        {
            _elapsed = _elapsed.Add(TimeSpan.FromSeconds(1));
            lblTiempoAct.Text = _elapsed.ToString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm tt");


           
        }

     

     

        private void btnConf_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Configuraciones.IndexConfiguracion());
            btnConf.BackColor = Color.FromArgb(183, 190, 188);
            btnBuscar.BackColor = Color.Transparent;
            btnAlumnos.BackColor = Color.Transparent;
        }

    

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
        }

    }
}
