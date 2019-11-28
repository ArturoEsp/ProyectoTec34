using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ProyectoTec34.Alumno
{
    public partial class FormularioBoleta1 : Form
    {
        
        public FormularioBoleta1(string Estudiante)
        {
            InitializeComponent();
            lbNombre.Text = Estudiante;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string NombreEstudiante = lbNombre.Text;

            List<String> NombreCalif = new List<String>();

            List<Double> CalifP1 = new List<Double>();
            CalifP1.Add(Convert.ToDouble(tbLM1.Text));
            CalifP1.Add(Convert.ToDouble(tbMat1.Text));
            CalifP1.Add(Convert.ToDouble(tbLE1.Text));
            CalifP1.Add(Convert.ToDouble(tbCNyT1.Text));
            CalifP1.Add(Convert.ToDouble(tbHis1.Text));
            CalifP1.Add(Convert.ToDouble(tbGeo1.Text));
            CalifP1.Add(Convert.ToDouble(tbFCyE1.Text));
            CalifP1.Add(Convert.ToDouble(tbEF1.Text));
            CalifP1.Add(Convert.ToDouble(tbArtes1.Text));

            List<Double> CalifP2 = new List<Double>();
            CalifP2.Add(Convert.ToDouble(tbLM2.Text));
            CalifP2.Add(Convert.ToDouble(tbMat2.Text));
            CalifP2.Add(Convert.ToDouble(tbLE2.Text));
            CalifP2.Add(Convert.ToDouble(tbCNyT2.Text));
            CalifP2.Add(Convert.ToDouble(tbHis2.Text));
            CalifP2.Add(Convert.ToDouble(tbGeo2.Text));
            CalifP2.Add(Convert.ToDouble(tbFCyE2.Text));
            CalifP2.Add(Convert.ToDouble(tbEF2.Text));
            CalifP2.Add(Convert.ToDouble(tbArtes2.Text));

            List<Double> CalifP3 = new List<Double>();
            CalifP3.Add(Convert.ToDouble(tbLM3.Text));
            CalifP3.Add(Convert.ToDouble(tbMat3.Text));
            CalifP3.Add(Convert.ToDouble(tbLE3.Text));
            CalifP3.Add(Convert.ToDouble(tbCNyT3.Text));
            CalifP3.Add(Convert.ToDouble(tbHis3.Text));
            CalifP3.Add(Convert.ToDouble(tbGeo3.Text));
            CalifP3.Add(Convert.ToDouble(tbFCyE3.Text));
            CalifP3.Add(Convert.ToDouble(tbEF3.Text));
            CalifP3.Add(Convert.ToDouble(tbArtes3.Text));

            ScriptSQL.InsertarBoleta(CalifP1, CalifP2, CalifP3, NombreEstudiante, NombreCalif);

            Configuraciones.ClearControls.LimpiarCampos(this);
        }
        
    }
}
