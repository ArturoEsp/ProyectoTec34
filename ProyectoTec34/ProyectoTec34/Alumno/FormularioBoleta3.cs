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
    public partial class FormularioBoleta3 : Form
    {
        public FormularioBoleta3(string Estudiante)
        {
            InitializeComponent();
            lbNombre.Text = Estudiante;
        }

        private void tbEsp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDoubles.validarNumeros(sender, e, '.');
        }

        private void tbArtes1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbArtes1.Text))
                btnGuardar1.Enabled = true;
            else
                btnGuardar1.Enabled = false;
        }

        private void tbArtes2_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbArtes2.Text))
                btnGuardar2.Enabled = true;
            else
                btnGuardar2.Enabled = false;
        }

        private void tbArtes3_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbArtes3.Text))
                btnGuardar3.Enabled = true;
            else
                btnGuardar3.Enabled = false;
        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            string NombreEstudiante = lbNombre.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Español III");
            NombreCalif.Add("Matemáticas III");
            NombreCalif.Add("Segunda Lengua: Inglés III");
            NombreCalif.Add("Ciencias III (Énfasis en Química)");
            NombreCalif.Add("Historia II");
            NombreCalif.Add("Formación Cívica y Ética II");
            NombreCalif.Add("Educación Fisíca III");
            NombreCalif.Add("Artes III");

            List<Double> CalifP1 = new List<Double>();
            CalifP1.Add(Convert.ToDouble(tbEsp1.Text));
            CalifP1.Add(Convert.ToDouble(tbMat1.Text));
            CalifP1.Add(Convert.ToDouble(tbSL1.Text));
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
                    btnGuardar1.Enabled = false;
                }
            }
            else
            {
                ScriptSQL.InsertarBoleta(CalifP1, NombreEstudiante, NombreCalif);
                MessageBox.Show("Calificaciones agregadas correctamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar1.Enabled = false;
            }
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            string NombreEstudiante = lbNombre.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Español III");
            NombreCalif.Add("Matemáticas III");
            NombreCalif.Add("Segunda Lengua: Inglés III");
            NombreCalif.Add("Ciencias III (Énfasis en Química)");
            NombreCalif.Add("Historia II");
            NombreCalif.Add("Formación Cívica y Ética II");
            NombreCalif.Add("Educación Fisíca III");
            NombreCalif.Add("Artes III");

            List<Double> CalifP2 = new List<Double>();
            CalifP2.Add(Convert.ToDouble(tbEsp2.Text));
            CalifP2.Add(Convert.ToDouble(tbMat2.Text));
            CalifP2.Add(Convert.ToDouble(tbSL2.Text));
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
                    btnGuardar2.Enabled = false;
                }
            }
            else
            {
                ScriptSQL.InsertarBoletaP2(CalifP2, NombreEstudiante, NombreCalif);
                MessageBox.Show("Calificaciones agregadas correctamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar2.Enabled = false;
            }
        }

        private void btnGuardar3_Click(object sender, EventArgs e)
        {
            string NombreEstudiante = lbNombre.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Español III");
            NombreCalif.Add("Matemáticas III");
            NombreCalif.Add("Segunda Lengua: Inglés III");
            NombreCalif.Add("Ciencias III (Énfasis en Química)");
            NombreCalif.Add("Historia II");
            NombreCalif.Add("Formación Cívica y Ética II");
            NombreCalif.Add("Educación Fisíca III");
            NombreCalif.Add("Artes III");

            List<Double> CalifP3 = new List<Double>();
            CalifP3.Add(Convert.ToDouble(tbEsp3.Text));
            CalifP3.Add(Convert.ToDouble(tbMat3.Text));
            CalifP3.Add(Convert.ToDouble(tbSL3.Text));
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
                    ScriptSQL.ActualizaBoleta2(CalifP3, NombreEstudiante, NombreCalif);
                    MessageBox.Show("Calificaciones actualizadas correctamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuardar3.Enabled = false;
                }
            }
            else
            {
                ScriptSQL.InsertarBoletaP3(CalifP3, NombreEstudiante, NombreCalif);
                MessageBox.Show("Calificaciones agregadas correctamente!", "Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar3.Enabled = false;
            }
        }

        private void tbEsp1_TextChanged(object sender, EventArgs e)
        {
            lbEspProm.Text = tbEsp1.Text;
        }

        private void tbEsp2_TextChanged(object sender, EventArgs e)
        {
            Double prom = 0;
            Double prom2 = 0;
            Double.TryParse(tbEsp1.Text, out prom);
            Double.TryParse(tbEsp1.Text, out prom2);

            lbEspProm.Text = (prom+prom2).ToString("N2");
        }

        private void FormularioBoleta3_Load(object sender, EventArgs e)
        {
            string Nombre = lbNombre.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Español III");
            NombreCalif.Add("Matemáticas III");
            NombreCalif.Add("Segunda Lengua: Inglés III");
            NombreCalif.Add("Ciencias III (Énfasis en Química)");
            NombreCalif.Add("Historia II");
            NombreCalif.Add("Formación Cívica y Ética II");
            NombreCalif.Add("Educación Fisíca III");
            NombreCalif.Add("Artes III");

            ScriptSQL.SelectBoleta1(Nombre, NombreCalif, tbEsp1, tbMat1, tbSL1, tbCien1, tbHis1, tbFCyE1, tbEF1, tbArtes1);
            ScriptSQL.SelectBoleta1(Nombre, NombreCalif, tbEsp2, tbMat2, tbSL2, tbCien2, tbHis2, tbFCyE2, tbEF2, tbArtes2);
            ScriptSQL.SelectBoleta1(Nombre, NombreCalif, tbEsp3, tbMat3, tbSL3, tbCien3, tbHis3, tbFCyE3, tbEF3, tbArtes3);
        }
    }
}
