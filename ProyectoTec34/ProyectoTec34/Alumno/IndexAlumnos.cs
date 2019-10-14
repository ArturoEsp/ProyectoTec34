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
    public partial class IndexAlumnos : Form
    {
        public IndexAlumnos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrar.ForeColor = Color.DarkGray;
        }

        private void btnRegistrar_MouseHover(object sender, EventArgs e)
        {
            btnRegistrar.ForeColor = Color.DimGray;
        }
    }
}
