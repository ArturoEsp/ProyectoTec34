using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProyectoTec34.Alumno
{
    public partial class FormularioAlumno : Form
    {
        private SQLiteConnection sqlconn;
        private SQLiteCommand sqlcmd;
        private DataTable sqlDT = new DataTable();
        private DataSet DS = new DataSet();
        private SQLiteDataAdapter DB;

        private string fecha_nacimiento;
        public List<string> informacionPersonal;
        public FormularioAlumno()
        {
            if(informacionPersonal == null || informacionPersonal.Count == 0)
            {
                LimpiarCampos(this);
            }
            else
            {

            }

            InitializeComponent();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetConnection()
        {
            sqlconn = new SQLiteConnection(@"Data Source = C:\Users\daniel\source\repos\ArturoEsp\ProyectoTec34\ProyectoTec34\ProyectoTec34\bin\Debug\DatabaseEscTec.db");
        }

        private void ExecuteQuery(string StudentID)
        {
            SetConnection();
            sqlconn.Open();
            sqlcmd = sqlconn.CreateCommand();
            sqlcmd.CommandText = StudentID;
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Dispose();
            sqlconn.Close();
        }

        private void loadData()
        {
            SetConnection();
            sqlconn.Open();
            sqlcmd = sqlconn.CreateCommand();
            string CommandText = "Select * From Estudiante";
            DB = new SQLiteDataAdapter(CommandText, sqlconn);
            DS.Reset();
            DB.Fill(DS);
            sqlDT = DS.Tables[0];
            //dataGridView1.DataSource = sqlDT;
            sqlconn.Close();
        }

      

        void LimpiarCampos(Control con)
        {
            foreach(Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    LimpiarCampos(c);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos(this);
        }

        private void FormularioAlumno_Load(object sender, EventArgs e)
        {
            
        }

        

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Configuraciones.GenerateID.AlumnoID(tbNombres.Text,tbApellidoPaterno.Text,tbApellidoMaterno.Text));
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fecha_nacimiento = dateTimePicker.Value.Date.ToString("yyyy/MM/dd");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
