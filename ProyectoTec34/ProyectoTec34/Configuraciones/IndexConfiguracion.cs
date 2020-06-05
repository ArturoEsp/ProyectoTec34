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

        private void btnBaseDatos_Click(object sender, EventArgs e)
        {
            BaseDeDatos frm = new BaseDeDatos();
            frm.Show();
        }

        private void btnCambioCiclo_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea cambiar el ciclo escolar a los alumnos?", "Advertencia", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (MessageBox.Show("Le recordamos que está accion solo debe realizarla una vez al año", "Advertencia", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ScriptSQL.CambiarGrado3a4();
                    ScriptSQL.CambiarGrado2a3();
                    ScriptSQL.CambiarGrado1a2();
                    MessageBox.Show("Cambio de ciclo escolar", "Ciclo Escolar", MessageBoxButtons.OK,MessageBoxIcon.None);
                }
            }
            
        }
    }
}
