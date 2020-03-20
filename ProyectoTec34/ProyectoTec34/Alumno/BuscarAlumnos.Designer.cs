namespace ProyectoTec34.Alumno
{
    partial class BuscarAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarAlumnos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnPrimerBoleta = new System.Windows.Forms.Button();
            this.btnSegBoleta = new System.Windows.Forms.Button();
            this.btnTercerBoleta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.tbBuscar);
            this.panel2.Location = new System.Drawing.Point(16, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 44);
            this.panel2.TabIndex = 3;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiguiente.Location = new System.Drawing.Point(486, 2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(90, 39);
            this.btnSiguiente.TabIndex = 37;
            this.btnSiguiente.Text = "Buscar";
            this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.tbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscar.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.ForeColor = System.Drawing.Color.Black;
            this.tbBuscar.Location = new System.Drawing.Point(6, 9);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(461, 26);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscar_KeyPress);
            // 
            // btnPrimerBoleta
            // 
            this.btnPrimerBoleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnPrimerBoleta.Enabled = false;
            this.btnPrimerBoleta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrimerBoleta.FlatAppearance.BorderSize = 0;
            this.btnPrimerBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimerBoleta.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerBoleta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrimerBoleta.Location = new System.Drawing.Point(16, 141);
            this.btnPrimerBoleta.Name = "btnPrimerBoleta";
            this.btnPrimerBoleta.Size = new System.Drawing.Size(161, 41);
            this.btnPrimerBoleta.TabIndex = 5;
            this.btnPrimerBoleta.Text = "1°";
            this.btnPrimerBoleta.UseVisualStyleBackColor = false;
            this.btnPrimerBoleta.Click += new System.EventHandler(this.btnPrimerBoleta_Click);
            // 
            // btnSegBoleta
            // 
            this.btnSegBoleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSegBoleta.Enabled = false;
            this.btnSegBoleta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSegBoleta.FlatAppearance.BorderSize = 0;
            this.btnSegBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegBoleta.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegBoleta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSegBoleta.Location = new System.Drawing.Point(226, 141);
            this.btnSegBoleta.Name = "btnSegBoleta";
            this.btnSegBoleta.Size = new System.Drawing.Size(161, 41);
            this.btnSegBoleta.TabIndex = 6;
            this.btnSegBoleta.Text = "2°";
            this.btnSegBoleta.UseVisualStyleBackColor = false;
            this.btnSegBoleta.Click += new System.EventHandler(this.btnSegBoleta_Click);
            // 
            // btnTercerBoleta
            // 
            this.btnTercerBoleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnTercerBoleta.Enabled = false;
            this.btnTercerBoleta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTercerBoleta.FlatAppearance.BorderSize = 0;
            this.btnTercerBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTercerBoleta.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTercerBoleta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTercerBoleta.Location = new System.Drawing.Point(434, 141);
            this.btnTercerBoleta.Name = "btnTercerBoleta";
            this.btnTercerBoleta.Size = new System.Drawing.Size(161, 41);
            this.btnTercerBoleta.TabIndex = 7;
            this.btnTercerBoleta.Text = "3°";
            this.btnTercerBoleta.UseVisualStyleBackColor = false;
            this.btnTercerBoleta.Click += new System.EventHandler(this.btnTercerBoleta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selecciona la boleta a llenar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar alumno: ";
            // 
            // BuscarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 196);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTercerBoleta);
            this.Controls.Add(this.btnSegBoleta);
            this.Controls.Add(this.btnPrimerBoleta);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscarAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarAlumnos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnPrimerBoleta;
        private System.Windows.Forms.Button btnSegBoleta;
        private System.Windows.Forms.Button btnTercerBoleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}