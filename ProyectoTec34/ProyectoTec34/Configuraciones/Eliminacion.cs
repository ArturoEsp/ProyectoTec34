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
            cboxGrupo.Enabled = false;
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
            {
                cboxGrado.Enabled = true;
            }
            else
            {
                cboxGrado.SelectedIndex = -1;
                cboxGrado.Enabled = false;
            }
                
        }

        private void btnEliminacionGrupal_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cboxGrado.Text) || string.IsNullOrEmpty(cboxGrupo.Text))
            {
                MessageBox.Show("Seleccione el Grado y Grupo.", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("El Grado: " + cboxGrado.Text + " Grupo: " + cboxGrupo.Text + " sera eliminado completamente.\n" +
                "¿Desea continuar?", "Eliminacion de Grupos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                {
                    MessageBox.Show("Grupo eliminado correctamente.", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            

        }

        private void cbGrupo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGrupo.Checked == true)
            {
                cboxGrupo.Enabled = true;
            }
            else
            {
                cboxGrupo.SelectedIndex = -1;
                cboxGrupo.Enabled = false;
            }

                
        }
    }
}
