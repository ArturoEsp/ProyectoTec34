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
                da = new SQLiteDataAdapter("SELECT ID_Docente, Nombre FROM Docentes",conn);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                return bSource;                        
            }
        }

        public static void NuevoUsuario(string ID, string Username, string Password,string Mode)
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
    }
}
