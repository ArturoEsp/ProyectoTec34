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
                cmd.CommandText = "INSERT INTO Alumno VALUES(@ID, @Grado, @Grupo,@Turno, @Nombre, @Direccion," +
                    "@Tel,@FechaN,@CURP,@TipoSangre,@Nacionalidad,@Obs,@FechaRegistro)";
                cmd.Parameters.Add(new SQLiteParameter("@ID", Parametros[0]));
                cmd.Parameters.Add(new SQLiteParameter("@Grado", Parametros[1]));
                cmd.Parameters.Add(new SQLiteParameter("@Grupo", Parametros[2]));
                cmd.Parameters.Add(new SQLiteParameter("@Turno", Parametros[3]));
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", Parametros[4]));
                cmd.Parameters.Add(new SQLiteParameter("@Direccion", Parametros[5]));
                cmd.Parameters.Add(new SQLiteParameter("@Tel", Parametros[6]));
                cmd.Parameters.Add(new SQLiteParameter("@FechaN", Parametros[7]));
                cmd.Parameters.Add(new SQLiteParameter("@CURP", Parametros[8]));
                cmd.Parameters.Add(new SQLiteParameter("@TipoSangre", Parametros[9]));
                cmd.Parameters.Add(new SQLiteParameter("@Nacionalidad", Parametros[10]));
                cmd.Parameters.Add(new SQLiteParameter("@Obs", Parametros[11]));
                cmd.Parameters.Add(new SQLiteParameter("@FechaRegistro", Parametros[12]));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void AltaEstudioSocioE(string IDAlumno)
        {

        }


        public static string getIDAlumno(string NombreCompleto)
        {
            string ID;
            string query = "SELECT ID_Alumno FROM Alumno WHERE Nombre = @Nombre";
            // string query = "SELECT ID_Alumno FROM Alumno WHERE Nombre LIKE '" + NombreCompleto + "%' AND" +
            //    " ApellidoPaterno LIKE '" + NombreCompleto + "%'; ";
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", NombreCompleto);
                ID = cmd.ExecuteScalar().ToString();
            }
            return ID;
        }



        private static DataTable DatosAutoCompleteBuscar()
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                //string query = "SELECT Nombre || ' ' || ApellidoPaterno || ' ' || ApellidoMaterno as FullName FROM Alumno ORDER BY Nombre";
                string query = "SELECT Nombre FROM Alumno Order By Nombre";
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
                sc.Add(Convert.ToString(row["Nombre"]));
            }
            return sc;
        }


        private static DataTable DatosAutoCompleteMunicipios()
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                //string query = "SELECT Nombre || ' ' || ApellidoPaterno || ' ' || ApellidoMaterno as FullName FROM Alumno ORDER BY Nombre";
                string query = "SELECT Descripcion FROM Municipios Order By Descripcion";
                SQLiteCommand com = new SQLiteCommand(query, conn);

                SQLiteDataAdapter ad = new SQLiteDataAdapter(com);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                return dt;
            }
        }

        public static AutoCompleteStringCollection AutoCompletarBuscarMunicipio()
        {
            DataTable dt = DatosAutoCompleteMunicipios();

            AutoCompleteStringCollection sc = new System.Windows.Forms.AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                sc.Add(Convert.ToString(row["Descripcion"]));
            }
            return sc;
        }


        public static void MostrarBoletaPrimer(string ID, TextBox Nombre, TextBox CURP, TextBox Grupo,TextBox Turno)
        {

            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                string sql = "SELECT Nombre,CURP,Grupo,Turno FROM Alumno WHERE ID_Alumno = @ID";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", ID);

                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Nombre.Text = reader[0].ToString();
                    CURP.Text = reader[1].ToString();
                    Grupo.Text = reader[2].ToString();
                    Turno.Text = reader[3].ToString();

                }

            }
        }
    }
}
