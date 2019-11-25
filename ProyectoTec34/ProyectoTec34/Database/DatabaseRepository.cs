using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace ProyectoTec34.Database
{
    class DatabaseRepository
    {
        private static string NameDatabase = @"DatabaseEscTec.db";
        private static string Path = @"C:\Database Tec34\";
        private static string PathComplete = Path + NameDatabase;

        public static bool CheckPathDatabase()
        {

            if (Directory.Exists(Path))
            {
                return true;
            }
            else
                return false;
        }

        public static bool CheckFileDatabase()
        {
            if (System.IO.File.Exists(PathComplete))
                return true;
            else
                return false;

        }



        private SQLiteConnection con;

        private static DatabaseRepository instancia;

        public static DatabaseRepository Instancia
        {
            get
            {
                if (instancia == null)
                    throw new Exception("Metodo Init no iniciado correctamente.");
                return instancia;

            }
        }

        private DatabaseRepository(string dbPath)
        {
            con = new SQLiteConnection("Data Source=" + PathComplete + "");
        }

        public static SQLiteConnection Init()
        {
            if (PathComplete == null)
                throw new ArgumentNullException();

            if (instancia != null)
                instancia.con.Close();

            instancia = new DatabaseRepository(PathComplete);
            return instancia.con;
        }
    }
}
