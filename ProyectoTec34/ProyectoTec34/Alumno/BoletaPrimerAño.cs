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
    public partial class BoletaPrimerAño : Form
    {
        public BoletaPrimerAño(string IDAlumno)
        {
            InitializeComponent();
            ScriptSQL.MostrarBoletaPrimer(IDAlumno,tbNombreAlumno,tbCURP,tbGrupo,tbTurno);
        }

        private void BoletaPrimerAño_Load(object sender, EventArgs e)
        {
            string id = tbNombreAlumno.Text;

            List<String> NombreCalif = new List<String>();
            NombreCalif.Add("Lengua Materna (Español)");
            NombreCalif.Add("Matemáticas");
            NombreCalif.Add("Lengua Extranjera (Inglés)");
            NombreCalif.Add("Ciencias Naturales y Tecnología (Biología)");
            NombreCalif.Add("Historia");
            NombreCalif.Add("Geografía");
            NombreCalif.Add("Formación Cívica y Ética");
            NombreCalif.Add("Educación Fisíca I");
            NombreCalif.Add("Artes I");

            ScriptSQL.MostrarBoleta1(id, NombreCalif, lbLM1, lbMat1, lbLE1, lbCNyT1, lbHis1, lbGeo1, lbFCyE1, lbEF1, lbArtes1);

            ScriptSQL.MostrarBoleta2(id, NombreCalif, lbLM2, lbMat2, lbLE2, lbCNyT2, lbHis2, lbGeo2, lbFCyE2, lbEF2, lbArtes2);

            ScriptSQL.MostrarBoleta3(id, NombreCalif, lbLM3, lbMat3, lbLE3, lbCNyT3, lbHis3, lbGeo3, lbFCyE3, lbEF3, lbArtes3);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string ID_Alumno = ScriptSQL.getIDAlumno(tbNombreAlumno.Text);
            BoletaSegundoAño frm = new BoletaSegundoAño(ID_Alumno);
            frm.Show();
            this.Close();
        }
    }
}
