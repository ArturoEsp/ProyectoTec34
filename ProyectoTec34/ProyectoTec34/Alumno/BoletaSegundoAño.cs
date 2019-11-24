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
    public partial class BoletaSegundoAño : Form
    {
        public BoletaSegundoAño()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            BoletaTercerAño frm = new BoletaTercerAño();
            frm.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //BoletaPrimerAño frm = new BoletaPrimerAño();
            //frm.Show();
            //this.Close();
        }
    }
}
