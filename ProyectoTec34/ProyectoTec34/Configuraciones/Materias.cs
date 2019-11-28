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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            cbMaestro.ValueMember = "Nombre";
            cbMaestro.DataSource = ScriptSQL.GetDocentes();
            dgvMaterias.DataSource = ScriptSQL.MostrarMaterias();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Maestros frm = new Maestros();
            frm.ShowDialog();
        }

        private void tbNombreMateria_TextChanged(object sender, EventArgs e)
        {
            if (tbNombreMateria.Text.Length > 3)
            {
                tbID.Text = Configuraciones.GenerateID.MateriaID(tbNombreMateria.Text);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombreMateria.Text))
                MessageBox.Show("Ingresa el nombre de la materia.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                string IdDocente = ScriptSQL.GetIdDocentes(cbMaestro.Text);
                ScriptSQL.NuevaMateria(tbID.Text, tbNombreMateria.Text, IdDocente);
                MessageBox.Show("Materia agregada correctamente!", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMaterias.DataSource = ScriptSQL.MostrarMaterias();

            }
        }
    }
}
