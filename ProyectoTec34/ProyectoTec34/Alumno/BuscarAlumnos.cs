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
    public partial class BuscarAlumnos : Form
    {
        public string nombre;

        public BuscarAlumnos()
        {
            InitializeComponent();
            tbBuscar.AutoCompleteCustomSource = ScriptSQL.AutoCompletarBuscar();
            tbBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;

            if (string.IsNullOrEmpty(tbBuscar.Text))
            {
                btnPrimerBoleta.Enabled = true;
                btnSegBoleta.Enabled = true;
                btnTercerBoleta.Enabled = true;
            }
        }
        private void btnPrimerBoleta_Click(object sender, EventArgs e)
        {
            if (!ScriptSQL.Existe(tbBuscar.Text))
            {
                string Estudiante = tbBuscar.Text;
                FormularioBoleta1 frm = new FormularioBoleta1(Estudiante);
                frm.Show();
            }
            else
            {
                MessageBox.Show("El Alumno " + tbBuscar.Text + " no esta registrado", "Buscar Alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnSegBoleta_Click(object sender, EventArgs e)
        {
            if (!ScriptSQL.Existe(tbBuscar.Text))
            {
                string Estudiante = tbBuscar.Text;
                FormularioBoleta2 frm = new FormularioBoleta2(Estudiante);
                frm.Show();
            }
            else
            {
                MessageBox.Show("El Alumno " + tbBuscar.Text + " no esta registrado", "Buscar Alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnTercerBoleta_Click(object sender, EventArgs e)
        {
            if (!ScriptSQL.Existe(tbBuscar.Text))
            {
                string Estudiante = tbBuscar.Text;
                FormularioBoleta3 frm = new FormularioBoleta3(Estudiante);
                frm.Show();
            }
            else
            {
                MessageBox.Show("El Alumno " + tbBuscar.Text + " no esta registrado", "Buscar Alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            BDSeleccion objBD = new BDSeleccion();
            objBD.Show();
            this.Close();
        }

        private void tbBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.None)
            {
                this.tbBuscar.SelectAll();
            }
        }
    }
}
