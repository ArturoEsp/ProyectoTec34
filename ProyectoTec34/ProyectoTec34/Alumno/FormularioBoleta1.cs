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
            

            

           

            

            //List<Double> CalifP3 = new List<Double>();
            //CalifP3.Add(Convert.ToDouble(tbLM3.Text));
            //CalifP3.Add(Convert.ToDouble(tbMat3.Text));
            //CalifP3.Add(Convert.ToDouble(tbLE3.Text));
            //CalifP3.Add(Convert.ToDouble(tbCNyT3.Text));
            //CalifP3.Add(Convert.ToDouble(tbHis3.Text));
            //CalifP3.Add(Convert.ToDouble(tbGeo3.Text));
            //CalifP3.Add(Convert.ToDouble(tbFCyE3.Text));
            //CalifP3.Add(Convert.ToDouble(tbEF3.Text));
            //CalifP3.Add(Convert.ToDouble(tbArtes3.Text));

            //ScriptSQL.InsertarBoleta(CalifP3, NombreEstudiante, NombreCalif);
            //ScriptSQL.InsertarBoleta(CalifP1, CalifP2, CalifP3, NombreEstudiante, NombreCalif);
            
        }

        private void btnGuardar1_Click_1(object sender, EventArgs e)
        {
            string NombreEstudiante = lbNombre.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Lengua Materna (Español)");
            NombreCalif.Add("Matemáticas");
            NombreCalif.Add("Lengua Extranjera (Inglés)");
            NombreCalif.Add("Ciencias Naturales y Tecnología (Biología)");
            NombreCalif.Add("Historia");
            NombreCalif.Add("Geografía");
            NombreCalif.Add("Formación Cívica y Ética");
            NombreCalif.Add("Educación Fisíca");
            NombreCalif.Add("Artes");

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

            ScriptSQL.InsertarBoletaP2(CalifP1, NombreEstudiante, NombreCalif);
            MessageBox.Show("Calificaciones agregadas correctamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Configuraciones.ClearControls.LimpiarCampos(this);
        }

        private void btnGuardar2_Click_1(object sender, EventArgs e)
        {
            string NombreEstudiante = lbNombre.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Lengua Materna (Español)");
            NombreCalif.Add("Matemáticas");
            NombreCalif.Add("Lengua Extranjera (Inglés)");
            NombreCalif.Add("Ciencias Naturales y Tecnología (Biología)");
            NombreCalif.Add("Historia");
            NombreCalif.Add("Geografía");
            NombreCalif.Add("Formación Cívica y Ética");
            NombreCalif.Add("Educación Fisíca");
            NombreCalif.Add("Artes");

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

            ScriptSQL.InsertarBoletaP2(CalifP2, NombreEstudiante, NombreCalif);
            MessageBox.Show("Calificaciones agregadas correctamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Configuraciones.ClearControls.LimpiarCampos(this);
        }

        private void btnGuardar3_Click_1(object sender, EventArgs e)
        {
            string NombreEstudiante = lbNombre.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Lengua Materna (Español)");
            NombreCalif.Add("Matemáticas");
            NombreCalif.Add("Lengua Extranjera (Inglés)");
            NombreCalif.Add("Ciencias Naturales y Tecnología (Biología)");
            NombreCalif.Add("Historia");
            NombreCalif.Add("Geografía");
            NombreCalif.Add("Formación Cívica y Ética");
            NombreCalif.Add("Educación Fisíca");
            NombreCalif.Add("Artes");

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

            ScriptSQL.InsertarBoletaP2(CalifP3, NombreEstudiante, NombreCalif);
            MessageBox.Show("Calificaciones agregadas correctamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Configuraciones.ClearControls.LimpiarCampos(this);
        }

        private void tbArtes1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbArtes1.Text))
                btnGuardar1.Enabled = false;
            else
                btnGuardar1.Enabled = true;
        }

        private void btnGuardar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbArtes2.Text))
                btnGuardar2.Enabled = false;
            else
                btnGuardar2.Enabled = true;
        }

        private void btnGuardar3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbArtes3.Text))
                btnGuardar3.Enabled = false;
            else
                btnGuardar3.Enabled = true;
        }
    }
    
}
