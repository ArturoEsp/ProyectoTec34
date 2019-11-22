using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace ProyectoTec34.Alumno
{
    class ScriptSQL
    {
        public static void NuevoAlumno(ArrayList Parametros)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Alumno VALUES(@ID, @Grado, @Grupo, @Nombre, @AP, @AM, @Direccion," +
                    "@Tel,@FechaN,@CURP,@TipoSangre,@Nacionalidad,@Obs,@FechaRegistro)";
                cmd.Parameters.Add(new SQLiteParameter("@ID", Parametros[0]));
                cmd.Parameters.Add(new SQLiteParameter("@Grado", Parametros[1]));
                cmd.Parameters.Add(new SQLiteParameter("@Grupo", Parametros[2]));
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", Parametros[3]));
                cmd.Parameters.Add(new SQLiteParameter("@AP", Parametros[4]));
                cmd.Parameters.Add(new SQLiteParameter("@AM", Parametros[5]));
                cmd.Parameters.Add(new SQLiteParameter("@Direccion", Parametros[6]));
                cmd.Parameters.Add(new SQLiteParameter("@Tel", Parametros[7]));
                cmd.Parameters.Add(new SQLiteParameter("@FechaN", Parametros[8]));
                cmd.Parameters.Add(new SQLiteParameter("@CURP", Parametros[9]));
                cmd.Parameters.Add(new SQLiteParameter("@TipoSangre", Parametros[10]));
                cmd.Parameters.Add(new SQLiteParameter("@Nacionalidad", Parametros[11]));
                cmd.Parameters.Add(new SQLiteParameter("@Obs", Parametros[12]));
                cmd.Parameters.Add(new SQLiteParameter("@FechaRegistro", Parametros[13]));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //public static string getIDAlumno(string NombreCompleto)
        //{
        //    string query = "SELECT ID_Alumno FROM Alumno WHERE ";

        //}



        public static DataTable DatosAutoCompleteBuscar()
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                string query = "SELECT Nombre || ' ' || ApellidoPaterno || ' ' || ApellidoMaterno || ' ' || ID_Alumno as FullName FROM Alumno ORDER BY Nombre";
                SQLiteCommand com = new SQLiteCommand(query, conn);

                SQLiteDataAdapter ad = new SQLiteDataAdapter(com);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                return dt;
            }
        }

        public static AutoCompleteStringCollection AutoCompletarBuscar()
        {
            DataTable dt = DatosAutoCompleteBuscar();

            AutoCompleteStringCollection sc = new System.Windows.Forms.AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                sc.Add(Convert.ToString(row["FullName"]));               
            }
            return sc;
        }

        public static void MostrarBoletaPrimer(string ID, TextBox Nombre, TextBox CURP, TextBox Grupo)
        {

            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                string sql = "SELECT Nombre || ' ' || ApellidoPaterno || ' ' || ApellidoMaterno as FullName," +
                    "CURP,Grupo FROM Alumno WHERE ID_Alumno = @ID";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", ID);

                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Nombre.Text = reader[0].ToString();
                    CURP.Text = reader[1].ToString();
                    Grupo.Text = reader[2].ToString();
                   
                }

            }
        }
    }
}
