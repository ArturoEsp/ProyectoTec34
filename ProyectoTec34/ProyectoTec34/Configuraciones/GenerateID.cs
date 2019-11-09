using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTec34.Configuraciones
{
    public class GenerateID
    {
       private static Random rnd = new Random();

        public static string MaestroID(string NombreMaestro)
        {
            string ID;
            int randomNum = rnd.Next(1000);
            string sub = NombreMaestro.Substring(0, 3);
            return ID = sub + randomNum.ToString();
        }

        public static string AlumnoID(string Nombre,string ApellidoP,string ApellidoM)
        {
            string ID;
            int randomNum = rnd.Next(10000);
            string subNombre = Nombre.Substring(0,3);
            string subAp = ApellidoP.Substring(0,1);
            string subAm = ApellidoM.Substring(0, 1);
            return ID = subNombre.ToUpper() + subAp + subAm + randomNum.ToString();

        }

        public static string UsuarioID(string Username)
        {
            string ID;
            int randNum = rnd.Next(100);
            string subUsername = Username.Substring(0,4);
            return ID = subUsername.ToUpper() + randNum.ToString();
        }
    }
}
