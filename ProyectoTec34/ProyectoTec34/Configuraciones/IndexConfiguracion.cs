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
    public partial class IndexConfiguracion : Form
    {
        public IndexConfiguracion()
        {
            InitializeComponent();
        }

        private void btnInsertarMateria_Click(object sender, EventArgs e)
        {
            Materias frm = new Materias();
            frm.Show();
        }

        private void btnIngresarMaestro_Click(object sender, EventArgs e)
        {
            Maestros frm = new Maestros();
            frm.Show();
        }

        private void btnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            AdministrarUsuarios frm = new AdministrarUsuarios();
            frm.Show();
        }
    }
}
