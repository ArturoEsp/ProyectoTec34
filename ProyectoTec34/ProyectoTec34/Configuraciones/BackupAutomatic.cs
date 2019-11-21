using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTec34.Configuraciones
{
    class BackupAutomatic
    {
        private static DateTime Fecha;

        public static void Backup(bool Acept)
        {
            Fecha = DateTime.Now;
            int Dia = Convert.ToInt32(Fecha.ToString("dd"));

            if (Dia == 7 || Dia == 18 || Dia == 21)
            {
                MessageBox.Show("bACKUP!!!");
            }
        }

    }
}
