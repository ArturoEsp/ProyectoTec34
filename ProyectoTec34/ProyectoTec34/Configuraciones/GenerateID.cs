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
            return ID = sub.ToUpper() + randomNum.ToString();
        }

        public static string MateriaID(string NombreMateria)
        {
            string ID;
            int randomNum = rnd.Next(1000,2000);
            string sub = NombreMateria.Substring(0, 3);
            return ID = sub.ToUpper() + randomNum.ToString();
        }

        public static string AlumnoID()
        {
            string ID;
            string Anio = DateTime.Now.ToString("yyyy");
            Anio = Anio.Substring(1,3);
            int randomNum = rnd.Next(0,1000);

            return ID = Anio + "34" + randomNum;

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
