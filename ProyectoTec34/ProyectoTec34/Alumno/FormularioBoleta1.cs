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
    public partial class FormularioBoleta1 : Form
    {
        public FormularioBoleta1(string Estudiante)
        {
            InitializeComponent();
            lbNombre.Text = Estudiante;
        }

        private void tbLM1_TextChanged(object sender, EventArgs e)
        {
            double prom = double.Parse(tbLM1.Text);
            lbLM.Text = prom.ToString("0.#");
        }

        private void tbLM2_TextChanged(object sender, EventArgs e)
        {
            double prom = ((double.Parse(tbLM1.Text)) + (double.Parse(tbLM2.Text))) / 2;
            lbLM.Text = prom.ToString("0.#");
        }

        private void tbLM3_TextChanged(object sender, EventArgs e)
        {
            double prom = ((double.Parse(tbLM1.Text)) + (double.Parse(tbLM2.Text)) + (double.Parse(tbLM3.Text))) / 3;
            lbLM.Text = prom.ToString("0.#");
        }
    }
}
