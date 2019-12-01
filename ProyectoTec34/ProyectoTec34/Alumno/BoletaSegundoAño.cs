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
    public partial class BoletaSegundoAño : Form
    {
        public BoletaSegundoAño(string IDAlumno)
        {
            InitializeComponent();
            ScriptSQL.MostrarBoletaPrimer(IDAlumno, tbNombreAlumno, tbCURP, tbGrupo, tbTurno);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string ID_Alumno = ScriptSQL.getIDAlumno(tbNombreAlumno.Text);
            BoletaTercerAño frm = new BoletaTercerAño(ID_Alumno);
            frm.Show();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            string ID_Alumno = ScriptSQL.getIDAlumno(tbNombreAlumno.Text);
            BoletaPrimerAño frm = new BoletaPrimerAño(ID_Alumno);
            frm.Show();
            this.Close();
        }

        private void BoletaSegundoAño_Load(object sender, EventArgs e)
        {
            string id = tbNombreAlumno.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Español II");
            NombreCalif.Add("Matemáticas II");
            NombreCalif.Add("Segunda Lengua: Inglés II");
            NombreCalif.Add("Ciencias II (Énfasis en Física)");
            NombreCalif.Add("Historia I");
            NombreCalif.Add("Formación Cívica y Ética I");
            NombreCalif.Add("Educación Fisíca II");
            NombreCalif.Add("Artes II");

            ScriptSQL.MostrarBoletaP1(id, NombreCalif, lbEsp1, lbMat1, lbSL1, lbCie1, lbHis1, lbFCyE1, lbEF1, lbArtes1);

            ScriptSQL.MostrarBoletaP2(id, NombreCalif, lbEsp2, lbMat2, lbSL2, lbCie2, lbHis2, lbFCyE2, lbEF2, lbArtes2);

            ScriptSQL.MostrarBoletaP3(id, NombreCalif, lbEsp3, lbMat3, lbSL3, lbCie3, lbHis3, lbFCyE3, lbEF3, lbArtes3);
        }
    }
}
