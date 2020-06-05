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
            NombreCalif.Add("Educación Fisíca I");
            NombreCalif.Add("Artes I");

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
            

            if (ScriptSQL.Validacion(NombreEstudiante, NombreCalif) != "")
            {
                if (MessageBox.Show("Este Alumno ya tiene calificaciones del primer parcial ¿Desea actualizar calificaciones?", "Advertencia", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ScriptSQL.ActualizaBoleta(CalifP1, NombreEstudiante, NombreCalif);
                    MessageBox.Show("Calificaciones actualizadas correctamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnGuardar1.Enabled = false;
                }
            }
            else
            {
                ScriptSQL.InsertarBoleta(CalifP1, NombreEstudiante, NombreCalif);
                MessageBox.Show("Calificaciones agregadas correctamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //btnGuardar1.Enabled = false;
            }

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
            NombreCalif.Add("Educación Fisíca I");
            NombreCalif.Add("Artes I");

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

            if (ScriptSQL.Validacion2(NombreEstudiante, NombreCalif) != "")
            {
                if (MessageBox.Show("Este Alumno ya tiene calificaciones del segundo parcial ¿Desea actualizar calificaciones?", "Advertencia", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ScriptSQL.ActualizaBoleta2(CalifP2, NombreEstudiante, NombreCalif);
                    MessageBox.Show("Calificaciones actualizadas correctamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnGuardar2.Enabled = false;
                }
            }
            else
            {
                ScriptSQL.InsertarBoletaP2(CalifP2, NombreEstudiante, NombreCalif);
                MessageBox.Show("Calificaciones agregadas correctamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //btnGuardar2.Enabled = false;
            }
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
            NombreCalif.Add("Educación Fisíca I");
            NombreCalif.Add("Artes I");

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

            if (ScriptSQL.Validacion3(NombreEstudiante, NombreCalif) != "")
            {
                if (MessageBox.Show("Este Alumno ya tiene calificaciones del tercer parcial ¿Desea actualizar calificaciones?", "Advertencia", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ScriptSQL.ActualizaBoleta3(CalifP3, NombreEstudiante, NombreCalif);
                    MessageBox.Show("Calificaciones actualizadas correctamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnGuardar3.Enabled = false;
                }
            }
            else
            {
                ScriptSQL.InsertarBoletaP3(CalifP3, NombreEstudiante, NombreCalif);
                MessageBox.Show("Calificaciones agregadas correctamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //btnGuardar3.Enabled = false;
            }
        }


        private void tbLM1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            OnlyDoubles.validarNumeros(sender, e, '.');
        }

        private void FormularioBoleta1_Load(object sender, EventArgs e)
        {
            string Nombre = lbNombre.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Lengua Materna (Español)");
            NombreCalif.Add("Matemáticas");
            NombreCalif.Add("Lengua Extranjera (Inglés)");
            NombreCalif.Add("Ciencias Naturales y Tecnología (Biología)");
            NombreCalif.Add("Historia");
            NombreCalif.Add("Geografía");
            NombreCalif.Add("Formación Cívica y Ética");
            NombreCalif.Add("Educación Fisíca I");
            NombreCalif.Add("Artes I");

            ScriptSQL.SelectBoleta1(Nombre, NombreCalif, tbLM1, tbMat1, tbLE1, tbCNyT1, tbHis1, tbGeo1, tbFCyE1, tbEF1, tbArtes1);
            ScriptSQL.SelectBoleta2(Nombre, NombreCalif, tbLM2, tbMat2, tbLE2, tbCNyT2, tbHis2, tbGeo2, tbFCyE2, tbEF2, tbArtes2);
            ScriptSQL.SelectBoleta3(Nombre, NombreCalif, tbLM3, tbMat3, tbLE3, tbCNyT3, tbHis3, tbGeo3, tbFCyE3, tbEF3, tbArtes3);
        }
    }
}

