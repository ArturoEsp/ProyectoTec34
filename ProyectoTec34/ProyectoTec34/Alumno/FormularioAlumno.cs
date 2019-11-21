using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections;

namespace ProyectoTec34.Alumno
{
    public partial class FormularioAlumno : Form
    {
     

        private string fecha_nacimiento;
        private ArrayList Parametros;
        public FormularioAlumno()
        {         
           InitializeComponent();
           Parametros = new ArrayList();
        }

        
        

        private void FormularioAlumno_Load(object sender, EventArgs e)
        {
            
        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombres.Text) || string.IsNullOrEmpty(tbApellidoMaterno.Text) || string.IsNullOrEmpty(tbApellidoPaterno.Text)
                || string.IsNullOrEmpty(tbCURP.Text))
            {
                MessageBox.Show("Información incompleta." +
                    "\nPor favor revisa que se escribieron los datos importantes del alumno.","Nuevo alumno",
                    MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                string IDAlumno = Configuraciones.GenerateID.AlumnoID();
                string Direccion = tbCalleNumero.Text + ", " + tbColonia.Text + ", " + tbMunicipio.Text + ", " + tbEntidadFederativa.Text + " "+tbCP.Text;
                string FechaRegistro = DateTime.Now.ToString("yyyy/MM/dd");
                Parametros.Add(IDAlumno);
                Parametros.Add(txtGrado.Text);
                Parametros.Add(txtGrupo.Text);
                Parametros.Add(tbNombres.Text);
                Parametros.Add(tbApellidoPaterno.Text);
                Parametros.Add(tbApellidoMaterno.Text);
                Parametros.Add(Direccion);
                Parametros.Add(tbTelefono.Text);
                Parametros.Add(fecha_nacimiento);
                Parametros.Add(tbCURP.Text);
                Parametros.Add(tbTipoSangre.Text);
                Parametros.Add(tbNacionalidad.Text);
                Parametros.Add(tbObs.Text);
                Parametros.Add(FechaRegistro);
                ScriptSQL.NuevoAlumno(Parametros);
                if (MessageBox.Show("Alumno registrado correctamente.\n" +
                    "¿Desea registrar el estudio socioeconomico ahora?","Nuevo alumno",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Configuraciones.ClearControls.LimpiarCampos(this);
                }
                else
                {
                    MessageBox.Show("Alumno registrado CORRECTAMENTE.","Alumno",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Configuraciones.ClearControls.LimpiarCampos(this);
                }
                
            }

            
           
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fecha_nacimiento = dateTimePicker.Value.Date.ToString("yyyy/MM/dd");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Configuraciones.GenerateID.AlumnoID());
            Configuraciones.ClearControls.LimpiarCampos(this);
        }

      
    }
}
