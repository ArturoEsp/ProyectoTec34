using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTec34.Configuraciones
{
    public partial class AdministrarUsuarios : Form
    {
        DateTime Fecha;

        public AdministrarUsuarios()
        {
            InitializeComponent();
            cbPrivilegios.Items.Add("Administrador");
            cbPrivilegios.Items.Add("Normal");
            Fecha = DateTime.Now;
            lblFechaRegistro.Text = Fecha.ToString("dd MMMM yyyy HH:mm");
            dgvDatos.DataSource = ScriptSQL.MostrarUsuarios();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUsername.Text) && tbUsername.Text.Length > 4)
            {
                tbIDUser.Text = GenerateID.UsuarioID(tbUsername.Text);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Los datos del usuario son correctos?","Nuevo usuario",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Username = tbUsername.Text;
                string Password = tbPassword.Text;
                string PasswordEncryp = Login.Encryp.EncodePassword(string.Concat(Username, Password));
                ScriptSQL.NuevoUsuario(tbIDUser.Text,Username,PasswordEncryp,cbPrivilegios.Text);
                MessageBox.Show("¡Usuario registrado con exito!","Nuevo usuario",MessageBoxButtons.OK,MessageBoxIcon.Information);
                tbIDUser.Text = "";
                tbUsername.Text = "";
                tbPassword.Text = "";
                dgvDatos.DataSource = ScriptSQL.MostrarUsuarios();
            }
        }
    }
}
