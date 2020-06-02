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
    public partial class IndexGraficas : Form
    {
        public IndexGraficas()
        {
            InitializeComponent();

            lblTotalAlumnos.Text = Convert.ToString(Alumno.ScriptSQL.ConteoAlumnos());
            lblTotalAlumnos1.Text = Convert.ToString(Alumno.ScriptSQL.ConteoAlumnosPorGrado(1));
            lblTotalAlumnos2.Text = Convert.ToString(Alumno.ScriptSQL.ConteoAlumnosPorGrado(2));
            lblTotalAlumnos3.Text = Convert.ToString(Alumno.ScriptSQL.ConteoAlumnosPorGrado(3));
        }
    }
}
