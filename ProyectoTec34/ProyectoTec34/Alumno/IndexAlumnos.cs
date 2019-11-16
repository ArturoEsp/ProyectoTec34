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
    public partial class IndexAlumnos : Form
    {
        public IndexAlumnos()
        {
            InitializeComponent();
        }

        private void btnInsertarDatos_Click(object sender, EventArgs e)
        {
            CargarDatosAlumno frm = new CargarDatosAlumno();
            frm.Show();
        }

        private void btnIngresarCalif_Click(object sender, EventArgs e)
        {
            BuscarAlumnos frm = new BuscarAlumnos();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnIngresarEstudio_Click(object sender, EventArgs e)
        {
           
        }
    }
}
