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

        private void btnIngresarEstudio_Click(object sender, EventArgs e)
        {
            BuscarAlumno frm = new BuscarAlumno('E');
            frm.Show();
        }

        private void btnEditarInfo_Click(object sender, EventArgs e)
        {
            BuscarAlumno frm = new BuscarAlumno('A');
            frm.Show();
        }

        private void btnBoleta_Click(object sender, EventArgs e)
        {
            BuscarAlumno frm = new BuscarAlumno('B');
            frm.Show();
        }
    }
}
