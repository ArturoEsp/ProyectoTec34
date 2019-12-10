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

            AltaEstudioSocioE(Parametros[0].ToString());
            AltaSomaticos(Parametros[0].ToString());
        }

        #region Estudio SocioEconomico

        private static void AltaEstudioSocioE(string IDAlumno)
        {
            for (int i = 1; i < 6; i++)
            {
                using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
                {

                    SQLiteCommand cmd;
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO EstudioSocio" + i + "(ID_Alumno) VALUES(@ID)";
                    cmd.Parameters.Add(new SQLiteParameter("@ID", IDAlumno));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

     

        private static void AltaSomaticos(string IDAlumno)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {

                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Somaticos(ID_Alumno) VALUES(@ID)";
                cmd.Parameters.Add(new SQLiteParameter("@ID", IDAlumno));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static ArrayList ConsultaEstudioS()
        {
            ArrayList Datos = new ArrayList();
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM EstudioSocio1";
                conn.Open();

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Datos.Add(reader[0].ToString());
                    }
                }
            }
            return Datos;
        }

        public static DataTable ConsultaSomaticos(string IDAlumno)
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Grado AS 'GRADO',Edad AS 'EDAD',Peso AS 'PESO (KG)'," +
                    "Estatura AS 'ESTATURA',Ciclos_Escolares AS 'CICLOS ESCOLARES' FROM Somaticos WHERE ID_Alumno = @ID";
                cmd.Parameters.Add(new SQLiteParameter("@ID", IDAlumno));
                using (SQLiteDataAdapter a = new SQLiteDataAdapter(cmd))
                {
                    a.Fill(dt);
                }

            }
            return dt;
        }


        public static void ActualizarEstudioSocioE(string IDAlumno, List<string> Parametros)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE EstudioSocio1 SET LugarNacimiento = @0, Sexo = @1, Edad = @2," +
                    "Idioma = @3, ConQuienVive = @4, NumHermanos = @5, NumIntegrantesFam = @6," +
                    "ApoyoGob = @7, PagoxTrabajo = @8, NombreTrabajo = @9, LugarTrabajo = @10," +
                    "HorarioTrabajo = @11, TiempoLibre = @12, PracDisciplina = @13, Discapacidad = @14," +
                    "Enfermedad = @15, Alergia = @16, Accidentes = @17, CaracEnfermedad = @18, Medicamento = @19," +
                    "MedPrescrito = @20, MedIndicacion = @21, NomTutor = @22, Parentesco = @23, PreparacionPadres = @24," +
                    "EdadPadre = @25, EdadMadre = @26, EstadoCivilPadres = @27, NumHijos = @28, NumEdadEsc = @29," +
                    "TelDom = @30, TelTrabajo = @31, NomTelMadre = @32, NomTelPadre = @33, NomTelHerm = @34," +
                    "NomTel = @35 WHERE ID_Alumno = @ID";
                cmd.Parameters.Add(new SQLiteParameter("@ID", IDAlumno));
                for (int i = 0; i < Parametros.Count; i++)
                {
                    cmd.Parameters.Add(new SQLiteParameter("@"+i.ToString(), Parametros[i]));
                }
                cmd.ExecuteNonQuery();
                
            }
        }

        public static void MostrarEstudioS1(string IDAlumno, List<string> Parametros)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = "";
                cmd.Parameters.Add(new SQLiteParameter("@ID", IDAlumno));
                for (int i = 0; i < Parametros.Count; i++)
                {
                    cmd.Parameters.Add(new SQLiteParameter("@" + i.ToString(), Parametros[i]));
                }
                cmd.ExecuteNonQuery();

            }
        }

        #endregion



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

        public static string getIDMateria(string NombreMateria)
        {
            string ID = "";
            string query = "SELECT ID_Materia FROM Materias WHERE Nombre = @Nombre";
            // string query = "SELECT ID_Alumno FROM Alumno WHERE Nombre LIKE '" + NombreCompleto + "%' AND" +
            //    " ApellidoPaterno LIKE '" + NombreCompleto + "%'; ";
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", NombreMateria);
                ID = cmd.ExecuteScalar().ToString();
            }
            return ID;
        }

        public static string Validacion(string NombreEstudiante, List<String> NombreCalif)
        {
            string Califi = "";
            string query = "SELECT Calificacion FROM Parcial1 WHERE ID_Alumno = @ID_Alumno and ID_Materia = @ID_Materia";
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                for (int i = 0; i < NombreCalif.Count; i++)
                {
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID_Alumno", getIDAlumno(NombreEstudiante));
                    cmd.Parameters.AddWithValue("@ID_Materia", getIDMateria(NombreCalif[i]));
                    Califi = (Convert.ToString(cmd.ExecuteScalar()));
                }
                
            }
            return Califi;
        }
        public static void ActualizaBoleta(List<Double> CalifP1, string NombreEstudiante, List<String> NombreCalif)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                for (int i = 0; i < CalifP1.Count; i++)
                {
                    cmd.CommandText = "UPDATE Parcial1 SET Calificacion = @Calificacion WHERE ID_Alumno = @ID_Alumno AND ID_Materia = @ID_Materia";
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Alumno", getIDAlumno(NombreEstudiante)));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Materia", getIDMateria(NombreCalif[i])));
                    cmd.Parameters.Add(new SQLiteParameter("@Calificacion", CalifP1[i]));
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void ActualizaBoleta2(List<Double> CalifP2, string NombreEstudiante, List<String> NombreCalif)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                for (int i = 0; i < CalifP2.Count; i++)
                {
                    cmd.CommandText = "UPDATE Parcial2 SET Calificacion = @Calificacion WHERE ID_Alumno = @ID_Alumno AND ID_Materia = @ID_Materia";
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Alumno", getIDAlumno(NombreEstudiante)));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Materia", getIDMateria(NombreCalif[i])));
                    cmd.Parameters.Add(new SQLiteParameter("@Calificacion", CalifP2[i]));
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void ActualizaBoleta3(List<Double> CalifP3, string NombreEstudiante, List<String> NombreCalif)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                for (int i = 0; i < CalifP3.Count; i++)
                {
                    cmd.CommandText = "UPDATE Parcial3 SET Calificacion = @Calificacion WHERE ID_Alumno = @ID_Alumno AND ID_Materia = @ID_Materia";
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Alumno", getIDAlumno(NombreEstudiante)));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Materia", getIDMateria(NombreCalif[i])));
                    cmd.Parameters.Add(new SQLiteParameter("@Calificacion", CalifP3[i]));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void InsertarBoleta(List<Double> CalifP1, string NombreEstudiante, List<String> NombreCalif)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                for (int i = 0; i < CalifP1.Count; i++)
                {
                    cmd.CommandText = "INSERT INTO Parcial1 (ID_Alumno, ID_Materia, Calificacion) VALUES(@ID_Alumno, @ID_Materia, @Calificacion)";
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Alumno", getIDAlumno(NombreEstudiante)));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Materia", getIDMateria(NombreCalif[i])));
                    cmd.Parameters.Add(new SQLiteParameter("@Calificacion", CalifP1[i]));
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void InsertarBoletaP2(List<Double> CalifP2, string NombreEstudiante, List<String> NombreCalif)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                for (int i = 0; i < CalifP2.Count; i++)
                {
                    cmd.CommandText = "INSERT INTO Parcial2 (ID_Alumno, ID_Materia, Calificacion) VALUES(@ID_Alumno, @ID_Materia, @Calificacion)";
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Alumno", getIDAlumno(NombreEstudiante)));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Materia", getIDMateria(NombreCalif[i])));
                    cmd.Parameters.Add(new SQLiteParameter("@Calificacion", CalifP2[i]));
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void InsertarBoletaP3(List<Double> CalifP3, string NombreEstudiante, List<String> NombreCalif)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                conn.Open();
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                for (int i = 0; i < CalifP3.Count; i++)
                {
                    cmd.CommandText = "INSERT INTO Parcial3 (ID_Alumno, ID_Materia, Calificacion) VALUES(@ID_Alumno, @ID_Materia, @Calificacion)";
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Alumno", getIDAlumno(NombreEstudiante)));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Materia", getIDMateria(NombreCalif[i])));
                    cmd.Parameters.Add(new SQLiteParameter("@Calificacion", CalifP3[i]));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void MostrarBoletaPrimer(string ID, TextBox Nombre, TextBox CURP, TextBox Grupo, TextBox Turno)
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
        public static void MostrarBoleta1(string ID_Alumno, List<String> NombreCalif, Label lbLM, Label lbMat, Label lbLE, Label lbCN, Label lbHis, Label lbGeo, Label lbFC, Label lbEF, Label lbArt)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                List<string> calif = new List<string>();
                conn.Open();
                for (int i = 0; i < NombreCalif.Count; i++)
                {
                    string sql = "SELECT Calificacion FROM Parcial1 WHERE ID_Alumno = @ID_Alumno and ID_Materia = @ID_Materia";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ID_Alumno", getIDAlumno(ID_Alumno));
                    cmd.Parameters.AddWithValue("@ID_Materia", getIDMateria(NombreCalif[i]));

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        calif.Add((reader[0]).ToString());

                    }
                }
                if (calif == null || calif.Count == 0)
                {
                    for (int i = 0; i < NombreCalif.Count; i++)
                    {
                        calif.Add("0.0");
                    }
                }

                lbLM.Text = calif[0].ToString();
                lbMat.Text = calif[1].ToString();
                lbLE.Text = calif[2].ToString();
                lbCN.Text = calif[3].ToString();
                lbHis.Text = calif[4].ToString();
                lbGeo.Text = calif[5].ToString();
                lbFC.Text = calif[6].ToString();
                lbEF.Text = calif[7].ToString();
                lbArt.Text = calif[8].ToString();
            }
        }
        public static void MostrarBoleta2(string ID_Alumno, List<String> NombreCalif2, Label lbLM, Label lbMat, Label lbLE, Label lbCN, Label lbHis, Label lbGeo, Label lbFC, Label lbEF, Label lbArt)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                List<string> calif = new List<string>();
                conn.Open();
                for (int i = 0; i < NombreCalif2.Count; i++)
                {
                    string sql = "SELECT Calificacion FROM Parcial2 WHERE ID_Alumno = @ID_Alumno and ID_Materia = @ID_Materia";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ID_Alumno", getIDAlumno(ID_Alumno));
                    cmd.Parameters.AddWithValue("@ID_Materia", getIDMateria(NombreCalif2[i]));

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        calif.Add((reader[0]).ToString());

                    }
                }
                if (calif == null || calif.Count == 0)
                {
                    for (int i = 0; i < NombreCalif2.Count; i++)
                    {
                        calif.Add("0.0");
                    }
                }

                lbLM.Text = calif[0].ToString();
                lbMat.Text = calif[1].ToString();
                lbLE.Text = calif[2].ToString();
                lbCN.Text = calif[3].ToString();
                lbHis.Text = calif[4].ToString();
                lbGeo.Text = calif[5].ToString();
                lbFC.Text = calif[6].ToString();
                lbEF.Text = calif[7].ToString();
                lbArt.Text = calif[8].ToString();
            }
        }
        public static void MostrarBoleta3(string ID_Alumno, List<String> NombreCalif3, Label lbLM, Label lbMat, Label lbLE, Label lbCN, Label lbHis, Label lbGeo, Label lbFC, Label lbEF, Label lbArt)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                List<string> calif = new List<string>();
                conn.Open();
                for (int i = 0; i < NombreCalif3.Count; i++)
                {
                    string sql = "SELECT Calificacion FROM Parcial3 WHERE ID_Alumno = @ID_Alumno and ID_Materia = @ID_Materia";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ID_Alumno", getIDAlumno(ID_Alumno));
                    cmd.Parameters.AddWithValue("@ID_Materia", getIDMateria(NombreCalif3[i]));

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        calif.Add((reader[0]).ToString());

                    }
                }
                if (calif == null || calif.Count == 0)
                {
                    for (int i = 0; i < NombreCalif3.Count; i++)
                    {
                        calif.Add("0.0");
                    }
                }

                lbLM.Text = calif[0].ToString();
                lbMat.Text = calif[1].ToString();
                lbLE.Text = calif[2].ToString();
                lbCN.Text = calif[3].ToString();
                lbHis.Text = calif[4].ToString();
                lbGeo.Text = calif[5].ToString();
                lbFC.Text = calif[6].ToString();
                lbEF.Text = calif[7].ToString();
                lbArt.Text = calif[8].ToString();
            }
        }

        public static void MostrarBoletaP1(string ID_Alumno, List<String> NombreCalif, Label lbLM, Label lbMat, Label lbLE, Label lbCN, Label lbHis, Label lbFC, Label lbEF, Label lbArt)
        {
            //lbEsp1, lbMat1, lbSL1, lbCie1, lbHis1, lbFCyE1, lbEF1, lbArtes1
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                List<string> calif = new List<string>();
                conn.Open();
                for (int i = 0; i < NombreCalif.Count; i++)
                {
                    string sql = "SELECT Calificacion FROM Parcial1 WHERE ID_Alumno = @ID_Alumno and ID_Materia = @ID_Materia";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ID_Alumno", getIDAlumno(ID_Alumno));
                    cmd.Parameters.AddWithValue("@ID_Materia", getIDMateria(NombreCalif[i]));

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        calif.Add((reader[0]).ToString());

                    }
                }
                if (calif == null || calif.Count == 0)
                {
                    for (int i = 0; i < NombreCalif.Count; i++)
                    {
                        calif.Add("0.0");
                    }
                }

                lbLM.Text = calif[0].ToString();
                lbMat.Text = calif[1].ToString();
                lbLE.Text = calif[2].ToString();
                lbCN.Text = calif[3].ToString();
                lbHis.Text = calif[4].ToString();
                lbFC.Text = calif[5].ToString();
                lbEF.Text = calif[6].ToString();
                lbArt.Text = calif[7].ToString();
            }
        }

        public static void MostrarBoletaP2(string ID_Alumno, List<String> NombreCalif2, Label lbLM, Label lbMat, Label lbLE, Label lbCN, Label lbHis, Label lbFC, Label lbEF, Label lbArt)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                List<string> calif = new List<string>();
                conn.Open();
                for (int i = 0; i < NombreCalif2.Count; i++)
                {
                    string sql = "SELECT Calificacion FROM Parcial2 WHERE ID_Alumno = @ID_Alumno and ID_Materia = @ID_Materia";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ID_Alumno", getIDAlumno(ID_Alumno));
                    cmd.Parameters.AddWithValue("@ID_Materia", getIDMateria(NombreCalif2[i]));

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        calif.Add((reader[0]).ToString());

                    }
                }
                if (calif == null || calif.Count == 0)
                {
                    for (int i = 0; i < NombreCalif2.Count; i++)
                    {
                        calif.Add("0.0");
                    }
                }

                lbLM.Text = calif[0].ToString();
                lbMat.Text = calif[1].ToString();
                lbLE.Text = calif[2].ToString();
                lbCN.Text = calif[3].ToString();
                lbHis.Text = calif[4].ToString();
                lbFC.Text = calif[5].ToString();
                lbEF.Text = calif[6].ToString();
                lbArt.Text = calif[7].ToString();
            }
        }
        public static void MostrarBoletaP3(string ID_Alumno, List<String> NombreCalif3, Label lbLM, Label lbMat, Label lbLE, Label lbCN, Label lbHis, Label lbFC, Label lbEF, Label lbArt)
        {
            using (SQLiteConnection conn = new SQLiteConnection(Database.DatabaseRepository.Init()))
            {
                List<string> calif = new List<string>();
                conn.Open();
                for (int i = 0; i < NombreCalif3.Count; i++)
                {
                    string sql = "SELECT Calificacion FROM Parcial3 WHERE ID_Alumno = @ID_Alumno and ID_Materia = @ID_Materia";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ID_Alumno", getIDAlumno(ID_Alumno));
                    cmd.Parameters.AddWithValue("@ID_Materia", getIDMateria(NombreCalif3[i]));

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        calif.Add((reader[0]).ToString());

                    }
                }
                if (calif == null || calif.Count == 0)
                {
                    for (int i = 0; i < NombreCalif3.Count; i++)
                    {
                        calif.Add("0.0");
                    }
                }

                lbLM.Text = calif[0].ToString();
                lbMat.Text = calif[1].ToString();
                lbLE.Text = calif[2].ToString();
                lbCN.Text = calif[3].ToString();
                lbHis.Text = calif[4].ToString();
                lbFC.Text = calif[5].ToString();
                lbEF.Text = calif[6].ToString();
                lbArt.Text = calif[7].ToString();
            }
        }
    }
}
