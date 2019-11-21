using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTec34.Login
{
    class LoginService
    {

        public static bool Autenticar(string usuario, string password)
        {
            string sql = @"SELECT COUNT(*)
                       FROM Usuario
                       WHERE Username = @usuario AND Password = @password";


            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.AddWithValue("@usuario", usuario);
                string hash = Encryp.EncodePassword(string.Concat(usuario, password));
                command.Parameters.AddWithValue("@password", hash);
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 0)
                    return false;
                else
                    return true;
            }
        }

        public static void AutoCloseLogin(int Segundos)
        {
            if (Segundos == 30)
            {
                Application.Exit();
            }
            
        }

        //public static DataTable prConsultaUsuario(string usuario, string password)
        //{
        //    string sql = @"SELECT UsuarioID
        //                    FROM Usuario
        //                    WHERE Username = @Username AND Contrasena = @password";


        //    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConex"].ToString()))
        //    {
        //        SqlCommand command = new SqlCommand(sql, conn);

        //        command.Parameters.AddWithValue("@Username", usuario);
        //        string hash = Helper.EncodePassword(string.Concat(usuario, password));
        //        command.Parameters.AddWithValue("@password", hash);

        //        conn.Open();
        //        SqlDataAdapter daAdaptador = new SqlDataAdapter(command);
        //        DataTable dtDatos = new DataTable();
        //        daAdaptador.Fill(dtDatos);
        //        return dtDatos;
        //    }
        //}

        //public static void Security(int userid, string usuario, DateTime ultimoacc, string ip)
        //{
        //    string sql = @"INSERT INTO UsuarioSecurity(
        //                    UsuarioID
        //                   ,Username
        //                   ,UltimoAcceso
        //                   ,IPAcceso)
        //                VALUES(
        //                    @UsuarioID,
        //                    @Username,
        //                    @UltimoAcceso,
        //                    @IPAcceso)
        //                    SELECT SCOPE_IDENTITY()";
        //    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConex"].ToString()))
        //    {
        //        SqlCommand command = new SqlCommand(sql, conn);
        //        command.Parameters.AddWithValue("@UsuarioID", userid);
        //        command.Parameters.AddWithValue("@Username", usuario);
        //        command.Parameters.AddWithValue("@UltimoAcceso", ultimoacc);
        //        command.Parameters.AddWithValue("@IPAcceso", ip);

        //        conn.Open();

        //        int resultado = Convert.ToInt32(command.ExecuteScalar());
        //    }
        //}
    }
}
