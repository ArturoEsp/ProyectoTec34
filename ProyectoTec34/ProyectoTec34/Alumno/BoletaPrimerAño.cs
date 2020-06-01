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
            ScriptSQL.MostrarBoletaPrimer(IDAlumno, tbNombreAlumno, tbCURP, tbGrupo, tbTurno);
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

            List<double> labels = new List<double>();
            labels.Add(Convert.ToDouble(lbLM1.Text));
            labels.Add(Convert.ToDouble(lbLM2.Text));
            labels.Add(Convert.ToDouble(lbLM3.Text));
            labels.Add(Convert.ToDouble(lbMat1.Text));
            labels.Add(Convert.ToDouble(lbMat2.Text));
            labels.Add(Convert.ToDouble(lbMat3.Text));
            labels.Add(Convert.ToDouble(lbLE1.Text));
            labels.Add(Convert.ToDouble(lbLE2.Text));
            labels.Add(Convert.ToDouble(lbLE3.Text));
            labels.Add(Convert.ToDouble(lbCNyT1.Text));
            labels.Add(Convert.ToDouble(lbCNyT2.Text));
            labels.Add(Convert.ToDouble(lbCNyT3.Text));
            labels.Add(Convert.ToDouble(lbHis1.Text));
            labels.Add(Convert.ToDouble(lbHis2.Text));
            labels.Add(Convert.ToDouble(lbHis3.Text));
            labels.Add(Convert.ToDouble(lbGeo1.Text));
            labels.Add(Convert.ToDouble(lbGeo2.Text));
            labels.Add(Convert.ToDouble(lbGeo3.Text));
            labels.Add(Convert.ToDouble(lbFCyE1.Text));
            labels.Add(Convert.ToDouble(lbFCyE2.Text));
            labels.Add(Convert.ToDouble(lbFCyE3.Text));
            labels.Add(Convert.ToDouble(lbEF1.Text));
            labels.Add(Convert.ToDouble(lbEF2.Text));
            labels.Add(Convert.ToDouble(lbEF3.Text));
            labels.Add(Convert.ToDouble(lbArtes1.Text));
            labels.Add(Convert.ToDouble(lbArtes2.Text));
            labels.Add(Convert.ToDouble(lbArtes3.Text));
            

            if (labels[0] != 0.0) lbLMProm.Text = labels[0].ToString();
            if (labels[1] != 0.0) lbLMProm.Text = ((labels[0] + labels[1]) / 2).ToString();
            if (labels[2] != 0.0) lbLMProm.Text = ((labels[0] + labels[1] + labels[2]) / 3).ToString();

            if (labels[3] != 0.0) lbMatProm.Text = labels[3].ToString();
            if (labels[4] != 0.0) lbMatProm.Text = ((labels[3] + labels[4]) / 2).ToString();
            if (labels[5] != 0.0) lbMatProm.Text = ((labels[3] + labels[4] + labels[5]) / 3).ToString();

            if (labels[6] != 0.0) lbLEProm.Text = labels[6].ToString();
            if (labels[7] != 0.0) lbLEProm.Text = ((labels[6] + labels[7]) / 2).ToString();
            if (labels[8] != 0.0) lbLEProm.Text = ((labels[6] + labels[7] + labels[8]) / 3).ToString();

            if (labels[9] != 0.0) lbCNyTProm.Text = labels[9].ToString();
            if (labels[10] != 0.0) lbCNyTProm.Text = ((labels[9] + labels[10]) / 2).ToString();
            if (labels[11] != 0.0) lbCNyTProm.Text = ((labels[9] + labels[10] + labels[11]) / 3).ToString();

            if (labels[12] != 0.0) lbHisProm.Text = labels[12].ToString();
            if (labels[13] != 0.0) lbHisProm.Text = ((labels[12] + labels[13]) / 2).ToString();
            if (labels[14] != 0.0) lbHisProm.Text = ((labels[12] + labels[13] + labels[14]) / 3).ToString();

            if (labels[15] != 0.0) lbGeoProm.Text = labels[15].ToString();
            if (labels[16] != 0.0) lbGeoProm.Text = ((labels[15] + labels[16]) / 2).ToString();
            if (labels[17] != 0.0) lbGeoProm.Text = ((labels[15] + labels[16] + labels[17]) / 3).ToString();

            if (labels[18] != 0.0) lbFCyEProm.Text = labels[18].ToString();
            if (labels[19] != 0.0) lbFCyEProm.Text = ((labels[18] + labels[19]) / 2).ToString();
            if (labels[20] != 0.0) lbFCyEProm.Text = ((labels[18] + labels[19] + labels[20]) / 3).ToString();

            if (labels[21] != 0.0) lbEFProm.Text = labels[21].ToString();
            if (labels[22] != 0.0) lbEFProm.Text = ((labels[21] + labels[22]) / 2).ToString();
            if (labels[23] != 0.0) lbEFProm.Text = ((labels[21] + labels[22] + labels[23]) / 3).ToString();

            if (labels[24] != 0.0) lbArtProm.Text = labels[24].ToString();
            if (labels[25] != 0.0) lbArtProm.Text = ((labels[24] + labels[25]) / 2).ToString();
            if (labels[26] != 0.0) lbArtProm.Text = ((labels[24] + labels[25] + labels[26]) / 3).ToString();

            double prom = labels.Sum();

            lbPromF.Text = (prom / 27).ToString("N1");
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
