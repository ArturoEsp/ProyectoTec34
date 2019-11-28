using System;
using System.Windows.Forms;
using System.Collections;
using Logs;

namespace ProyectoTec34.Alumno
{
    public partial class FormularioAlumno : Form
    {
     

        private string fecha_nacimiento;
        private ArrayList Parametros;
        private string IDAlumno;
        public FormularioAlumno()
        {         
           InitializeComponent();
           Parametros = new ArrayList();
        }

        
        

        private void FormularioAlumno_Load(object sender, EventArgs e)
        {
            tbMunicipio.AutoCompleteCustomSource = ScriptSQL.AutoCompletarBuscarMunicipio();
            tbMunicipio.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbMunicipio.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            IDAlumno = Configuraciones.GenerateID.AlumnoID();
            if (string.IsNullOrEmpty(tbNombres.Text) || string.IsNullOrEmpty(tbApellidoMaterno.Text) || string.IsNullOrEmpty(tbApellidoPaterno.Text)
                || string.IsNullOrEmpty(tbCURP.Text))
            {
                MessageBox.Show("Información incompleta." +
                    "\nPor favor revisa que se escribieron los datos importantes del alumno.","Nuevo alumno",
                    MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                
                string Direccion = tbCalleNumero.Text + ", " + tbColonia.Text + ", " + tbMunicipio.Text + ", " + tbEntidadFederativa.Text + " "+tbCP.Text;
                string FechaRegistro = DateTime.Now.ToString("yyyy/MM/dd");
                string NombreCompleto = tbNombres.Text + " " + tbApellidoPaterno.Text + " " + tbApellidoMaterno.Text;
                Parametros.Add(IDAlumno);
                Parametros.Add(txtGrado.Text);
                Parametros.Add(txtGrupo.Text);
                Parametros.Add(cbTurno.Text);
                Parametros.Add(NombreCompleto);               
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
                    Logs.Log.CrearLog("Se registro el alumno: "+NombreCompleto);
                }
                else
                {
                    MessageBox.Show("Alumno registrado CORRECTAMENTE.","Alumno",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Configuraciones.ClearControls.LimpiarCampos(this);
                    Logs.Log.CrearLog("Se registro el alumno: " + NombreCompleto);
                }
                
            }

            Parametros = new ArrayList();
            IDAlumno = String.Empty;
            tbNacionalidad.Text = "MEXICANA";
            tbEntidadFederativa.Text = "MORELOS";
            
           
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fecha_nacimiento = dateTimePicker.Value.Date.ToString("yyyy/MM/dd");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Parametros = null;
            Configuraciones.ClearControls.LimpiarCampos(this);
        }

        private void tbCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Configuraciones.OnlyNumbers.Validate(e);
        }
    }
}
