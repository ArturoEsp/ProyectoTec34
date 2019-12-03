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

            List<double> labels = new List<double>();
            labels.Add(Convert.ToDouble(lbEsp1.Text));
            labels.Add(Convert.ToDouble(lbEsp2.Text));
            labels.Add(Convert.ToDouble(lbEsp3.Text));
            labels.Add(Convert.ToDouble(lbMat1.Text));
            labels.Add(Convert.ToDouble(lbMat2.Text));
            labels.Add(Convert.ToDouble(lbMat3.Text));
            labels.Add(Convert.ToDouble(lbSL1.Text));
            labels.Add(Convert.ToDouble(lbSL2.Text));
            labels.Add(Convert.ToDouble(lbSL3.Text));
            labels.Add(Convert.ToDouble(lbCie1.Text));
            labels.Add(Convert.ToDouble(lbCie2.Text));
            labels.Add(Convert.ToDouble(lbCie3.Text));
            labels.Add(Convert.ToDouble(lbHis1.Text));
            labels.Add(Convert.ToDouble(lbHis2.Text));
            labels.Add(Convert.ToDouble(lbHis3.Text));
            labels.Add(Convert.ToDouble(lbFCyE1.Text));
            labels.Add(Convert.ToDouble(lbFCyE2.Text));
            labels.Add(Convert.ToDouble(lbFCyE3.Text));
            labels.Add(Convert.ToDouble(lbEF1.Text));
            labels.Add(Convert.ToDouble(lbEF2.Text));
            labels.Add(Convert.ToDouble(lbEF3.Text));
            labels.Add(Convert.ToDouble(lbArtes1.Text));
            labels.Add(Convert.ToDouble(lbArtes2.Text));
            labels.Add(Convert.ToDouble(lbArtes3.Text));

            lbEspProm.Text = ((labels[0] + labels[1] + labels[2]) / 3).ToString("#.0");
            lbMatProm.Text = ((labels[3] + labels[4] + labels[5]) / 3).ToString("#.0");
            lbSLProm.Text = ((labels[6] + labels[7] + labels[8]) / 3).ToString("#.0");
            lbCienProm.Text = ((labels[9] + labels[10] + labels[11]) / 3).ToString("#.0");
            lbHisProm.Text = ((labels[12] + labels[13] + labels[14]) / 3).ToString("#.0");
            lbFCyEProm.Text = ((labels[15] + labels[16] + labels[17]) / 3).ToString("#.0");
            lbEFProm.Text = ((labels[18] + labels[19] + labels[20]) / 3).ToString("#.0");
            lbArtProm.Text = ((labels[21] + labels[22] + labels[23]) / 3).ToString("#.0");

            double prom = labels.Sum();

            lbPromF.Text = (prom / 24).ToString("#.0");
        }
    }
}
