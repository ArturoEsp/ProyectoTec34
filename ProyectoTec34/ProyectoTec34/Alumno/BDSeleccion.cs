using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTec34.Alumno
{
    public partial class BDSeleccion : Form
    {
        public BDSeleccion()
        {
            InitializeComponent();
            dgvDatos.DataSource = ScriptSQL.MostrarBD(tbBuscar.Text);
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {

        }

        private void tbBuscar_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            //string _Persona = dgvDatos.CurrentRow.Cells[0].Value.ToString();
            //BuscarAlumnos oBuscar = new BuscarAlumnos(_Persona);
            //this.Close();
        }
    }
}
