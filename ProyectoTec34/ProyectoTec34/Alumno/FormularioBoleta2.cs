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
    public partial class FormularioBoleta2 : Form
    {
        public FormularioBoleta2(string Estudiante)
        {
            InitializeComponent();
            lbNombre.Text = Estudiante;
        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            string NombreEstudiante = lbNombre.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Español II");
            NombreCalif.Add("Matemáticas II");
            NombreCalif.Add("Segunda Lengua: Inglés II");
            NombreCalif.Add("Ciencias II (Énfasis en Física)");
            NombreCalif.Add("Historia I");
            NombreCalif.Add("Formación Cívica y Ética I");
            NombreCalif.Add("Educación Fisíca II");
            NombreCalif.Add("Artes II");

            List<Double> CalifP1 = new List<Double>();
            CalifP1.Add(Convert.ToDouble(tbEsp1.Text));
            CalifP1.Add(Convert.ToDouble(tbMat1.Text));
            CalifP1.Add(Convert.ToDouble(tbSLI1.Text));
            CalifP1.Add(Convert.ToDouble(tbCien1.Text));
            CalifP1.Add(Convert.ToDouble(tbHis1.Text));
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

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            string NombreEstudiante = lbNombre.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Español II");
            NombreCalif.Add("Matemáticas II");
            NombreCalif.Add("Segunda Lengua: Inglés II");
            NombreCalif.Add("Ciencias II (Énfasis en Física)");
            NombreCalif.Add("Historia I");
            NombreCalif.Add("Formación Cívica y Ética I");
            NombreCalif.Add("Educación Fisíca II");
            NombreCalif.Add("Artes II");

            List<Double> CalifP2 = new List<Double>();
            CalifP2.Add(Convert.ToDouble(tbEsp2.Text));
            CalifP2.Add(Convert.ToDouble(tbMat2.Text));
            CalifP2.Add(Convert.ToDouble(tbSLI2.Text));
            CalifP2.Add(Convert.ToDouble(tbCien2.Text));
            CalifP2.Add(Convert.ToDouble(tbHis2.Text));
            CalifP2.Add(Convert.ToDouble(tbFCyE2.Text));
            CalifP2.Add(Convert.ToDouble(tbEF2.Text));
            CalifP2.Add(Convert.ToDouble(tbArtes2.Text));

            if (ScriptSQL.Validacion2(NombreEstudiante, NombreCalif) != "")
            {
                if (MessageBox.Show("Este Alumno ya tiene calificaciones del primer parcial ¿Desea actualizar calificaciones?", "Advertencia", MessageBoxButtons.YesNo,
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


            /*
             * 
             * if (ScriptSQL.Validacion2(NombreEstudiante, NombreCalif) != "")
            {
                if (MessageBox.Show("Este Alumno ya tiene calificaciones del segundo parcial ¿Desea actualizar calificaciones?", "Advertencia", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ScriptSQL.ActualizaBoleta2(CalifP2, NombreEstudiante, NombreCalif);
                    MessageBox.Show("Calificaciones actualizadas correctamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuardar2.Enabled = false;
                }
            }
            else
            {
                ScriptSQL.InsertarBoletaP2(CalifP2, NombreEstudiante, NombreCalif);
                MessageBox.Show("Calificaciones agregadas correctamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar2.Enabled = false;
            }
             * 
             */
        }

        private void btnGuardar3_Click(object sender, EventArgs e)
        {
            string NombreEstudiante = lbNombre.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Español II");
            NombreCalif.Add("Matemáticas II");
            NombreCalif.Add("Segunda Lengua: Inglés II");
            NombreCalif.Add("Ciencias II (Énfasis en Física)");
            NombreCalif.Add("Historia I");
            NombreCalif.Add("Formación Cívica y Ética I");
            NombreCalif.Add("Educación Fisíca II");
            NombreCalif.Add("Artes II");

            List<Double> CalifP3 = new List<Double>();
            CalifP3.Add(Convert.ToDouble(tbEsp3.Text));
            CalifP3.Add(Convert.ToDouble(tbMat3.Text));
            CalifP3.Add(Convert.ToDouble(tbSLI3.Text));
            CalifP3.Add(Convert.ToDouble(tbCien3.Text));
            CalifP3.Add(Convert.ToDouble(tbHis3.Text));
            CalifP3.Add(Convert.ToDouble(tbFCyE3.Text));
            CalifP3.Add(Convert.ToDouble(tbEF3.Text));
            CalifP3.Add(Convert.ToDouble(tbArtes3.Text));

            if (ScriptSQL.Validacion3(NombreEstudiante, NombreCalif) != "")
            {
                if (MessageBox.Show("Este Alumno ya tiene calificaciones del primer parcial ¿Desea actualizar calificaciones?", "Advertencia", MessageBoxButtons.YesNo,
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

        private void tbHis3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDoubles.validarNumeros(sender, e, '.');
        }

        private void FormularioBoleta2_Load(object sender, EventArgs e)
        {
            string Nombre = lbNombre.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Español II");
            NombreCalif.Add("Matemáticas II");
            NombreCalif.Add("Segunda Lengua: Inglés II");
            NombreCalif.Add("Ciencias II (Énfasis en Física)");
            NombreCalif.Add("Historia I");
            NombreCalif.Add("Formación Cívica y Ética I");
            NombreCalif.Add("Educación Fisíca II");
            NombreCalif.Add("Artes II");
            
            ScriptSQL.SelectBoleta1(Nombre, NombreCalif, tbEsp1, tbMat1, tbSLI1, tbCien1, tbHis1, tbFCyE1, tbEF1, tbArtes1);
            ScriptSQL.SelectBoleta2(Nombre, NombreCalif, tbEsp2, tbMat2, tbSLI2, tbCien2, tbHis2, tbFCyE2, tbEF2, tbArtes2);
            ScriptSQL.SelectBoleta3(Nombre, NombreCalif, tbEsp3, tbMat3, tbSLI3, tbCien3, tbHis3, tbFCyE3, tbEF3, tbArtes3);
        }
    }
}
