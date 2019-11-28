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
    public partial class BuscarAlumno : Form
    {
        public string ID_Alumno;

        public BuscarAlumno(char Option)
        {
            InitializeComponent();

            tbBuscar.AutoCompleteCustomSource = ScriptSQL.AutoCompletarBuscar();
            tbBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;

            switch (Option)
            {
                case 'B':
                    rbtnBoletas.Checked = true;
                    break;
                case 'E':
                    rbtnEstudioE.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void BuscarAlumno_Load(object sender, EventArgs e)
        {
            
        }

        private void tbBuscar_Enter(object sender, EventArgs e)
        {
            if(tbBuscar.Text == "Buscar...")
            {
                tbBuscar.Text = "";
                tbBuscar.ForeColor = Color.Black;
            }
        }

        private void tbBuscar_Leave(object sender, EventArgs e)
        {
            if(tbBuscar.Text == "")
            {
                tbBuscar.Text = "Buscar...";
                tbBuscar.ForeColor = Color.DarkGray;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ID_Alumno = ScriptSQL.getIDAlumno(tbBuscar.Text);
            if (rbtnBoletas.Checked == true)
            {
                BoletaPrimerAño frm = new BoletaPrimerAño(ID_Alumno);
                frm.Show();
            }

            if (rbtnEstudioE.Checked == true)
            {
                VistaEstudio frm = new VistaEstudio(ID_Alumno,tbBuscar.Text);
                frm.Show();
            }



        }
    }
}
