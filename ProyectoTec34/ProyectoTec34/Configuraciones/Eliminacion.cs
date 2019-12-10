using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTec34.Configuraciones
{
    public partial class Eliminacion : Form
    {
        public Eliminacion()
        {
            InitializeComponent();
            tbNombreAlumno.AutoCompleteCustomSource = Alumno.ScriptSQL.AutoCompletarBuscar();
            tbNombreAlumno.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbNombreAlumno.AutoCompleteSource = AutoCompleteSource.CustomSource;

            cboxGrado.Enabled = false;
        }

        private string IDAlumno;
        private void btnAceptarE_Click(object sender, EventArgs e)
        {
            IDAlumno = Alumno.ScriptSQL.getIDAlumno(tbNombreAlumno.Text);
            if (MessageBox.Show("El alumno " + tbNombreAlumno.Text + " sera eliminado completamente.\n" +
                "¿Desea continuar?", "Eliminacion de alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                ScriptSQL.EliminarAlumno(IDAlumno);
                MessageBox.Show("Alumno eliminado correctamente.", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNombreAlumno.Text = IDAlumno = String.Empty;

            }
        }

        private void cbGrado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGrado.Checked == true)
                cboxGrado.Enabled = true;
            else
                cboxGrado.Enabled = false;

        }
    }
}
