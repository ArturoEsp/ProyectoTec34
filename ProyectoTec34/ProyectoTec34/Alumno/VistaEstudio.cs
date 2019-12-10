using System;
using System.Collections;
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
    public partial class VistaEstudio : Form
    {
        private List<string> Parametros;
        private string ID_Alumno;


        public VistaEstudio(string IDAlumno,string Nombre)
        {
            InitializeComponent();
            tbNombre.Text = Nombre;
            dgvSomaticos.DataSource = ScriptSQL.ConsultaSomaticos(IDAlumno);
            Parametros = new List<string>();
            ID_Alumno = IDAlumno;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Parametros.Add(tbLugarNaci.Text);
            //Parametros.Add(tbSexo.Text);
            //Parametros.Add(tbEdad.Text);
            //Parametros.Add(tbDominaIdioma.Text);
            //Parametros.Add(tbConQuienVive.Text);
            //Parametros.Add(tbNoHermanos.Text);
            //Parametros.Add(tbNoIntegrantFam.Text);
            //Parametros.Add(tbApoyoGob.Text);
            //Parametros.Add(tbPagoxTrabajo.Text);
            //Parametros.Add(tbNombreTrabajo.Text);
            //Parametros.Add(tbLugarTrabajo.Text);
            //Parametros.Add(tbHorarioTrabajo.Text);
            //Parametros.Add(tbTiempoLibre.Text);
            //Parametros.Add(tbPractDisciplina.Text);
            //Parametros.Add(tbDiscapacidad.Text);
            //Parametros.Add(tbEnfermedad.Text);
            //Parametros.Add(tbAlergia.Text);
            //Parametros.Add(tbAccidentes.Text);
            //Parametros.Add(tbCaracEnfermdad.Text);
            //Parametros.Add(tbMedicamento.Text);
            //Parametros.Add(tbMedicamentoPres.Text);
            //Parametros.Add(tbIndMedicamento.Text);
            //Parametros.Add(tbPadreTutor.Text);
            //Parametros.Add(tbParentesco.Text);
            //Parametros.Add(tbProfesionPadres.Text);
            //Parametros.Add(tbEdadPadre.Text);
            //Parametros.Add(tbEdadMadre.Text);
            //Parametros.Add(tbEstadoCivil.Text);
            //Parametros.Add(tbNoHijos.Text);
            //Parametros.Add(tbNumEdadEsc.Text);
            //Parametros.Add(tbTelDom.Text);
            //Parametros.Add(tbTelTrabajo.Text);
            //Parametros.Add(tbTelMadre.Text);
            //Parametros.Add(tbTelPadre.Text);
            //Parametros.Add(tbTelHermanos.Text);
            //Parametros.Add(tbTelNombre.Text);
            //ScriptSQL.ActualizarEstudioSocioE(ID_Alumno,Parametros);
            //MessageBox.Show("Información guardada correctamente.");
        }
    }
}
