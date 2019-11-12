using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CG.Web.MegaApiClient;

namespace ProyectoTec34.Configuraciones
{
    public partial class Respaldo : Form
    {

        private Thread t;

        public Respaldo()
        {
            InitializeComponent();
            t = new Thread(subirArchivoAMega);
            t.Start();

        }

        private void subirArchivoAMega()
        {
            try
            {
               
                lblInfo.Invoke(new MethodInvoker(delegate { lblInfo.Text = "Conectando como 'bmth_harcore@hotmail.com'"; }));
                progressBar1.Invoke(new MethodInvoker(delegate { progressBar1.PerformStep(); }));           
                MegaApiClient cliente = new MegaApiClient();
                cliente.Login("bmth_harcore@hotmail.com", "corajitos12");           
                progressBar1.Invoke(new MethodInvoker(delegate { progressBar1.PerformStep(); }));    
                lblInfo.Invoke(new MethodInvoker(delegate { lblInfo.Text = "Obteniendo directorios..."; }));        
                var nodos = cliente.GetNodes();
                lblInfo.Invoke(new MethodInvoker(delegate { lblInfo.Text = "Buscando carpeta 'Backup'..."; }));         
                bool existe = cliente.GetNodes().Any(n => n.Name == "Backup");

                INode root;
                INode carpeta;

          
                if (existe == true)
                {
                    lblInfo.Invoke(new MethodInvoker(delegate { lblInfo.Text = "Obteniendo la carpeta 'Backup'...."; }));
                   
                    progressBar1.Invoke(new MethodInvoker(delegate { progressBar1.PerformStep(); }));               
                    carpeta = nodos.Single(n => n.Name == "Backup");
                }
                else
                {
                   
                    lblInfo.Invoke(new MethodInvoker(delegate { lblInfo.Text = "Creando carpeta 'Backup'..."; }));          
                    progressBar1.Invoke(new MethodInvoker(delegate { progressBar1.PerformStep(); }));
                    root = nodos.Single(n => n.Type == NodeType.Root);           
                    carpeta = cliente.CreateFolder("Backup", root);
                }

                
                progressBar1.Invoke(new MethodInvoker(delegate { progressBar1.PerformStep(); }));
            
                lblInfo.Invoke(new MethodInvoker(delegate { lblInfo.Text = "Subiendo archivo..."; }));
             
                progressBar1.Invoke(new MethodInvoker(delegate { progressBar1.PerformStep(); }));

                INode archivo = cliente.UploadFile(@"C:\EscTec\DatabaseEscTec.db", carpeta);

             
                Uri downloadUrl = cliente.GetDownloadLink(archivo);
            
                lblInfo.Invoke(new MethodInvoker(delegate { lblInfo.Text = "Archivo subido con éxito."; }));

            }
            catch (Exception error)
            {
                
                t.Abort();
                
                MessageBox.Show("Error al intentar subir el archivo. " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

         
            this.Invoke((MethodInvoker)delegate
            {
                this.Close();
            });


        }
    }
}
