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
    public partial class EditarInfoAlumno : Form
    {
        public string Id_Alumno;
        public EditarInfoAlumno(string Id_Alumno)
        {
            this.Id_Alumno = Id_Alumno;
            InitializeComponent();
            ScriptSQL.SelectDatosAlumno(Id_Alumno, txtGrado,txtGrupo,cbTurno,tbNomCom,tbDirecc,tbTelefono,dateTimePicker,tbCURP,tbTipoSangre,tbNacionalidad,tbObs);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea actualizar la información del alumno?", "Advertencia", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                ScriptSQL.ActualizaDatosAlumno(Id_Alumno, Convert.ToInt32(txtGrado.Text), txtGrupo.Text, cbTurno.Text, tbNomCom.Text, tbDirecc.Text, tbTelefono.Text, dateTimePicker.Text, tbCURP.Text, tbTipoSangre.Text, tbNacionalidad.Text, tbObs.Text);
                MessageBox.Show("Información Actualizada Correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }
    }
}
