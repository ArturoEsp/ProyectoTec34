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
    public partial class Maestros : Form
    {
        public Maestros()
        {
            InitializeComponent();
            dgvMaestros.DataSource = ScriptSQL.MostrarMaestros();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNombre.Text) && tbNombre.Text.Length > 3)
            {
                tbIDMaestro.Text = GenerateID.MaestroID(tbNombre.Text);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombre.Text))
                MessageBox.Show("Escribe el nombre del maestro por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                ScriptSQL.NuevoMaestro(tbIDMaestro.Text,tbNombre.Text,tbObs.Text);
                
                tbIDMaestro.Text = "";
                tbNombre.Text = "";
                tbObs.Text = "";

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string IDMaestro = dgvMaestros.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("¿Desea eliminar el docente "+IDMaestro+"?","Control de docentes",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ScriptSQL.EliminarMaestro(IDMaestro);
                MessageBox.Show("!Eliminación correcta!","Control de docentes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dgvMaestros.DataSource = ScriptSQL.MostrarMaestros();
            }
        }
    }
}
