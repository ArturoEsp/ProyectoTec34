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
        }

        private void btnAceptarE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("El alumno "+tbNombreAlumno.Text+" sera eliminado completamente.\n" +
                "¿Desea continuar?","Eliminacion de alumnos",MessageBoxButtons.YesNo,MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {

            }
        }
    }
}
