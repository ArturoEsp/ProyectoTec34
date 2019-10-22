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
            sqlconn = new SQLiteConnection(@"Data Source = C:\Users\bmth_\source\repos\ArturoEsp\ProyectoTec34\ProyectoTec34\ProyectoTec34\bin\Debug\TecnicaDB.db");
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
            loadData();
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    txtGrado.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        //    txtGrupo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        //    txtApePat.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        //    txtApeMat.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        //    txtNombre.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        //    txtDomicilio.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        //    txtColonia.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        //    txtTel.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        //    txtMunicipio.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        //    txtEntidad.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        //    txtCP.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
        //    txtCurp.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
        //    txtTipoSangre.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
        //    txtNacionalidad.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();

        //}

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //string StudentID = "Insert into Estudiante values ('" + 
            //    txtGrado.Text + "','" + 
            //    txtGrupo.Text + "','" + 
            //    txtApePat.Text + "','" + 
            //    txtApeMat.Text + "','" + 
            //    txtNombre.Text + "','" + 
            //    txtDomicilio.Text + "','" + 
            //    txtColonia.Text + "','" + 
            //    txtTel.Text + "','" + 
            //    txtMunicipio.Text + "','" + 
            //    txtEntidad.Text + "','" + 
            //    txtCP.Text + "','" +
            //    txtCurp.Text+ "','" +
            //    txtTipoSangre.Text + "','" +
            //    txtNacionalidad.Text + "')";

            //ExecuteQuery(StudentID);
            //loadData();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fecha_nacimiento = dateTimePicker.Value.Date.ToString("yyyy/MM/dd");
        }
    }
}
