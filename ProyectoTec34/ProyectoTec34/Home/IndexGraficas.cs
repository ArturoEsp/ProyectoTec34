using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoTec34.Home
{
    public partial class IndexGraficas : Form
    {
        public IndexGraficas()
        {
            InitializeComponent();

            lblTotalAlumnos.Text = Convert.ToString(Alumno.ScriptSQL.ConteoAlumnos());
            lblTotalAlumnos1.Text = Convert.ToString(Alumno.ScriptSQL.ConteoAlumnosPorGrado(1));
            lblTotalAlumnos2.Text = Convert.ToString(Alumno.ScriptSQL.ConteoAlumnosPorGrado(2));
            lblTotalAlumnos3.Text = Convert.ToString(Alumno.ScriptSQL.ConteoAlumnosPorGrado(3));
            lblDocentes.Text = Convert.ToString(Alumno.ScriptSQL.ConteoDocentes());
        }
        /*
         * using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                SQLiteDataAdapter da;
                DataTable dt = new DataTable();
                da = new SQLiteDataAdapter("SELECT P.ID_Alumno, A.Nombre,SUM(P.Calificacion) FROM Parcial1 P INNER JOIN Alumno A ON A.ID_Alumno = P.ID_Alumno GROUP BY A.Nombre ", conn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);
                DataRow dr;
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dr = dt.Rows[i];
                        Series series = this.chart1.Series.Add(dr.ItemArray[1].ToString());
                        series.Points.Add(Convert.ToDouble(dr.ItemArray[2]));
                    }


                }
                /*
                 *  SELECT P.ID_Alumno, A.Nombre,SUM(P.Calificacion) 
                    FROM Parcial1 P 
                    INNER JOIN Alumno A ON A.ID_Alumno = P.ID_Alumno
                    GROUP BY A.Nombre 
                 */
    }
}
