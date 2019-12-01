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
    public partial class BoletaTercerAño : Form
    {
        public BoletaTercerAño(string IDAlumno)
        {
            InitializeComponent();
            ScriptSQL.MostrarBoletaPrimer(IDAlumno, tbNombreAlumno, tbCURP, tbGrupo, tbTurno);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            string ID_Alumno = ScriptSQL.getIDAlumno(tbNombreAlumno.Text);
            BoletaSegundoAño frm = new BoletaSegundoAño(ID_Alumno);
            frm.Show();
            this.Close();
        }

        private void BoletaTercerAño_Load(object sender, EventArgs e)
        {
            string id = tbNombreAlumno.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Español III");
            NombreCalif.Add("Matemáticas III");
            NombreCalif.Add("Segunda Lengua: Inglés III");
            NombreCalif.Add("Ciencias III (Énfasis en Química)");
            NombreCalif.Add("Historia II");
            NombreCalif.Add("Formación Cívica y Ética II");
            NombreCalif.Add("Educación Fisíca III");
            NombreCalif.Add("Artes III");

            ScriptSQL.MostrarBoletaP1(id, NombreCalif, lbEsp1, lbMat1, lbSL1, lbCie1, lbHis1, lbFCyE1, lbEF1, lbArtes1);

            ScriptSQL.MostrarBoletaP2(id, NombreCalif, lbEsp2, lbMat2, lbSL2, lbCie2, lbHis2, lbFCyE2, lbEF2, lbArtes2);

            ScriptSQL.MostrarBoletaP3(id, NombreCalif, lbEsp3, lbMat3, lbSL3, lbCie3, lbHis3, lbFCyE3, lbEF3, lbArtes3);
        }
    }
}
