using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace ProyectoTec34.Configuraciones
{
    public class ScriptSQL
    {

        public static void NuevoMaestro(string ID, string Nombre, string Observaciones)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Docentes VALUES(@ID,@Nombre,@Obs)";
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@Obs", Observaciones));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarAlumno(string ID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                SQLiteCommand cmd;
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Alumno WHERE ID_Alumno = @ID";
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                cmd.ExecuteNonQuery();
            }
            EliminarAlumnoEstudioS(ID);
            EliminarAlumnoParciales(ID);
            EliminarAlumnoSomaticos(ID);
        }

        private static void EliminarAlumnoEstudioS(string ID)
        {

            for (int i = 1; i < 6; i++)
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
                {
                    SQLiteCommand cmd;
                    conn.Open();
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM EstudioSocio" + i + " WHERE ID_Alumno = @ID";
                    cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                    cmd.ExecuteNonQuery();
                }
            }

        }

        private static void EliminarAlumnoParciales(string ID)
        {

            for (int i = 1; i < 4; i++)
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
                {
                    SQLiteCommand cmd;
                    conn.Open();
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "DELETE FROM Parcial" + i + " WHERE ID_Alumno = @ID";
                    cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                    cmd.ExecuteNonQuery();
                }
            }

        }

        private static void EliminarAlumnoSomaticos(string ID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                SQLiteCommand cmd;
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Somaticos WHERE ID_Alumno = @ID";
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                cmd.ExecuteNonQuery();
            }


        }

        public static void EliminarMaestro(string ID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Docentes WHERE ID_Docente = @ID";
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static BindingSource MostrarMaestros()
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                SQLiteDataAdapter da;
                DataTable dt = new DataTable();
                da = new SQLiteDataAdapter("SELECT ID_Docente, Nombre FROM Docentes", conn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                return bSource;
            }
        }

        public static void NuevoUsuario(string ID, string Username, string Password, string Mode)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Usuarios VALUES(@ID,@Username,@Password,@Mode)";
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                cmd.Parameters.Add(new SQLiteParameter("@Username", Username));
                cmd.Parameters.Add(new SQLiteParameter("@Password", Password));
                cmd.Parameters.Add(new SQLiteParameter("@Mode", Mode));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static BindingSource MostrarUsuarios()
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                SQLiteDataAdapter da;
                DataTable dt = new DataTable();
                da = new SQLiteDataAdapter("SELECT ID_Usuario as 'ID', Username as 'Usuario',Mode as 'Privilegios'  FROM Usuarios", conn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                return bSource;
            }
        }

        public static BindingSource MostrarBD()
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                SQLiteDataAdapter da;
                DataTable dt = new DataTable();
                da = new SQLiteDataAdapter("SELECT * FROM Alumno", conn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                return bSource;
            }
        }

        public static BindingSource SeleccionDataBaseEstudioE()
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                SQLiteDataAdapter da;
                DataTable dt = new DataTable();
                da = new SQLiteDataAdapter("SELECT * FROM EstudioSocio1", conn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                return bSource;
            }
        }


        public static BindingSource SeleccionDataBaseGrado(string Grado,string Grupo)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                SQLiteDataAdapter da;
                DataTable dt = new DataTable();
                da = new SQLiteDataAdapter();
                da.SelectCommand = new SQLiteCommand("SELECT * FROM Alumno WHERE Grado = @Grado AND Grupo = @Grupo", conn);
                da.SelectCommand.Parameters.AddWithValue("@Grado",Grado);
                da.SelectCommand.Parameters.AddWithValue("@Grupo", Grupo);
                da.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                return bSource;
            }
        }


        public static void NuevaMateria(string ID, string Nombre, string IDDoncente)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Materias VALUES(@ID,@Nombre,@ID_Docente)";
                cmd.Parameters.Add(new SQLiteParameter("@ID", ID));
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@ID_Docente", IDDoncente));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable MostrarMaterias()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                string Query = "SELECT ID_Materia as 'ID', Nombre as 'NOMBRE', ID_Docente as 'ID Docente' FROM Materias Order By Nombre";
                SQLiteDataAdapter da = new SQLiteDataAdapter(Query, conn);
                da.Fill(dt);
            }
            return dt;
        }


        public static string GetIdDocentes(string Nombre)
        {
            string ID = "";
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                string Query = "SELECT ID_Docente FROM Docentes WHERE Nombre = @Nombre";
                SQLiteCommand cmd = new SQLiteCommand(Query, conn);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                ID = cmd.ExecuteScalar().ToString();
            }
            return ID;
        }

        public static DataTable GetDocentes()
        {
            DataTable dt;
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                dt = new DataTable();
                conn.Open();
                string Query = "SELECT Nombre FROM Docentes";
                SQLiteDataAdapter da = new SQLiteDataAdapter(Query, conn);
                da.Fill(dt);
            }

            return dt;
        }
        public static DataTable GetMaterias()
        {
            DataTable dt;
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                dt = new DataTable();
                conn.Open();
                string Query = "SELECT Nombre FROM Materias";
                SQLiteDataAdapter da = new SQLiteDataAdapter(Query, conn);
                da.Fill(dt);
            }

            return dt;
        }
    }
}
