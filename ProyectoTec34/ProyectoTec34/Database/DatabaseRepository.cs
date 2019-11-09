using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ProyectoTec34.Database
{
    class DatabaseRepository
    {
        private static string PathDatabase = "DatabaseEscTec.db";

        private SQLiteConnection con;

        private static DatabaseRepository instancia;

        public static DatabaseRepository Instancia
        {
            get
            {
                if (instancia == null) 
                    throw new Exception("No has iniciado el metodo init");
                return instancia;

            }
        }

        private DatabaseRepository(string dbPath)
        {
            con = new SQLiteConnection("Data Source="+dbPath+";Version=3;");
        }

        public static SQLiteConnection Init()
        {       
            if (PathDatabase == null)
                throw new ArgumentNullException();
          
            if (instancia != null)
                instancia.con.Close();
            
            instancia = new DatabaseRepository(PathDatabase);
            return instancia.con;
        }
    }
}
