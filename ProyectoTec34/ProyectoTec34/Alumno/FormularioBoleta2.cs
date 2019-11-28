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

        private void btnGuardar_Click(object sender, EventArgs e)
        {/*
            string NombreEstudiante = lbNombre.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Español II");
            NombreCalif.Add("Matemáticas II");
            NombreCalif.Add("Segunda Lengua: Inglés II");
            NombreCalif.Add("Ciencias II (Énfasis en Física)");
            NombreCalif.Add("Historia I");
            NombreCalif.Add("Formación Cívica y Ética I");
            NombreCalif.Add("Educación Fisíca");
            NombreCalif.Add("Artes");

            List<Double> CalifP1 = new List<Double>();
            CalifP1.Add(Convert.ToDouble(tbEsp1.Text));
            CalifP1.Add(Convert.ToDouble(tbMat1.Text));
            CalifP1.Add(Convert.ToDouble(tbSLI1.Text));
            CalifP1.Add(Convert.ToDouble(tbCien1.Text));
            CalifP1.Add(Convert.ToDouble(tbHis1.Text));
            CalifP1.Add(Convert.ToDouble(tbFCyE1.Text));
            CalifP1.Add(Convert.ToDouble(tbEF1.Text));
            CalifP1.Add(Convert.ToDouble(tbArtes1.Text));

            List<Double> CalifP2 = new List<Double>();
            CalifP2.Add(Convert.ToDouble(tbEsp2.Text));
            CalifP2.Add(Convert.ToDouble(tbMat2.Text));
            CalifP2.Add(Convert.ToDouble(tbSLI2.Text));
            CalifP2.Add(Convert.ToDouble(tbCien2.Text));
            CalifP2.Add(Convert.ToDouble(tbHis2.Text));
            CalifP2.Add(Convert.ToDouble(tbFCyE2.Text));
            CalifP2.Add(Convert.ToDouble(tbEF2.Text));
            CalifP2.Add(Convert.ToDouble(tbArtes2.Text));

            List<Double> CalifP3 = new List<Double>();
            CalifP3.Add(Convert.ToDouble(tbEsp3.Text));
            CalifP3.Add(Convert.ToDouble(tbMat3.Text));
            CalifP3.Add(Convert.ToDouble(tbSLI3.Text));
            CalifP3.Add(Convert.ToDouble(tbCien3.Text));
            CalifP3.Add(Convert.ToDouble(tbHis3.Text));
            CalifP3.Add(Convert.ToDouble(tbFCyE3.Text));
            CalifP3.Add(Convert.ToDouble(tbEF3.Text));
            CalifP3.Add(Convert.ToDouble(tbArtes3.Text));

            ScriptSQL.InsertarBoleta(CalifP1, CalifP2, CalifP3, NombreEstudiante, NombreCalif);
            */
        }
    }
}
