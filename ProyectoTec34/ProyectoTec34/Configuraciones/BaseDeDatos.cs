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
            if (MessageBox.Show("¿Desea realizar el respaldo de la BASE DE DATOS?","Respaldo",
                MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Respaldo frm = new Respaldo();
                frm.ShowDialog();
            }
            
        }

        private void eliminarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminacion frm = new Eliminacion();
            frm.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = ScriptSQL.SeleccionDataBaseGrado("1","A");
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = ScriptSQL.SeleccionDataBaseGrado("1", "B");
        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = ScriptSQL.SeleccionDataBaseGrado("2", "A");
        }

        private void bToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = ScriptSQL.SeleccionDataBaseGrado("2", "B");
        }

        private void estudioSocioEconomicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = ScriptSQL.SeleccionDataBaseEstudioE();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = ScriptSQL.MostrarBD();
        }

        private void aToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = ScriptSQL.SeleccionDataBaseGrado("3", "A");
        }

        private void bToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = ScriptSQL.SeleccionDataBaseGrado("3", "B");
        }

        private void tbBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            dgvDatos.DataSource = ScriptSQL.MostrarBD(tbBuscar.Text);
        }
    }
}
