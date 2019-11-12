using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTec34.Configuraciones
{
    public partial class BaseDeDatos : Form
    {
        public BaseDeDatos()
        {
            InitializeComponent();
            dgvDatos.DataSource = ScriptSQL.MostrarBD();
        }

        private void respaldaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Respaldo frm = new Respaldo();
            frm.ShowDialog();
        }
    }
}
