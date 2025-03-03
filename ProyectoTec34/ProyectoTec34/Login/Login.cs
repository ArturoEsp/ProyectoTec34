﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logs;

namespace ProyectoTec34.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string Usuario = "admin";
        private string Password = "admin";

        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "Usuario...")
            {
                tbUsuario.Text = "";
                tbUsuario.ForeColor = Color.Black;
            }
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if(tbUsuario.Text == "")
            {
                tbUsuario.Text = "Usuario...";
                tbUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (LoginService.Autenticar(tbUsuario.Text,tbPassword.Text))
            {
                this.Hide();
                Home.Index frm = new Home.Index(tbUsuario.Text);
                timer.Enabled = false;
                frm.Show();
                Logs.Log.CrearLog("El usuario " + tbUsuario.Text + " inicio sesión.");
            }
            else if (tbUsuario.Text == Usuario && tbPassword.Text == Password)
            {
                this.Hide();
                Home.Index frm = new Home.Index(Usuario);
                timer.Enabled = false;
                frm.Show();
                Logs.Log.CrearLog("El usuario " + tbUsuario.Text + " inicio sesión.");
                
            }
            else
            {
                MessageBox.Show("Usuario / Costraseña incorrecta." +
                    "\nIntentalo de nuevo.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Contraseña...")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Black;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if(tbPassword.Text == "")
            {
                tbPassword.Text = "Contraseña...";
                tbPassword.ForeColor = Color.DarkGray;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPassword_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlPassword.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private void pnlUser_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlUser.ClientRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private int Segundos;
        private void timer_Tick(object sender, EventArgs e)
        {
            Segundos += 1;
            LoginService.AutoCloseLogin(Segundos);
            
        }
    }
}
