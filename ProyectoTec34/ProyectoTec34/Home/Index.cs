using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTec34.Home
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Login.Login);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            frm = new Login.Login();
            frm.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Alumno.BoletaPrimerAño frm = new Alumno.BoletaPrimerAño();
            frm.Show();
        }
    }
}
