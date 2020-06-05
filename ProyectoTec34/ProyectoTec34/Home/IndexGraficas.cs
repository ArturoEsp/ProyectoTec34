using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            lblDocentes.Text = Convert.ToString(Alumno.ScriptSQL.ConteoDocentes());
        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbGrupo.Text) && !string.IsNullOrEmpty(cbGrado.Text))
            {
                lblConsultaInd.Text = (Configuraciones.ScriptSQL.ConteoIndividual(cbGrado.Text, cbGrupo.Text)).ToString();
            }
        }

        private void cbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbGrupo.Text) && !string.IsNullOrEmpty(cbGrado.Text))
            {
                lblConsultaInd.Text = (Configuraciones.ScriptSQL.ConteoIndividual(cbGrado.Text, cbGrupo.Text)).ToString();
            }
        }
    }
}
