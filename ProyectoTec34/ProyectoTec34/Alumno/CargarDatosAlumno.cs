using System;
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
    public partial class CargarDatosAlumno : Form
    {

        public CargarDatosAlumno()
        {
            InitializeComponent();
            AbrirFormHijo(new FormularioAlumno());
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

    }
}
