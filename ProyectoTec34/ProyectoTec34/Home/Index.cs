using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            this.Close();
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Login.Login);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frm = new Login.Login();
            frm.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Alumno.BuscarAlumno frm = new Alumno.BuscarAlumno();
            frm.Show();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Alumno.FormularioAlumno());
        }
    }
}
