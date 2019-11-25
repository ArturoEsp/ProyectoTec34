using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTec34
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Database.DatabaseRepository.CheckPathDatabase() == false)
            {
                MessageBox.Show("No se ha encontrado la ruta de la base de datos. \n" +
                    @"C:\Database Tec34\DatabaseEscTec.db", "Sistema Administrativo para la Gestión de Alumnos");
            }
            else { Application.Run(new Login.Login()); }
          
        }
    }
}
