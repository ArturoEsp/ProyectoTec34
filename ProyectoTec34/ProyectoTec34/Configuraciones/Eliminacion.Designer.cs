namespace ProyectoTec34.Configuraciones
{
    partial class Eliminacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminacion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptarE = new System.Windows.Forms.Button();
            this.tbNombreAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminacionGrupal = new System.Windows.Forms.Button();
            this.cboxGrupo = new System.Windows.Forms.ComboBox();
            this.cboxGrado = new System.Windows.Forms.ComboBox();
            this.cbGrado = new System.Windows.Forms.CheckBox();
            this.cbGrupo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAceptarE);
            this.groupBox1.Controls.Add(this.tbNombreAlumno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar alumno";
            // 
            // btnAceptarE
            // 
            this.btnAceptarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAceptarE.Location = new System.Drawing.Point(484, 53);
            this.btnAceptarE.Name = "btnAceptarE";
            this.btnAceptarE.Size = new System.Drawing.Size(92, 27);
            this.btnAceptarE.TabIndex = 2;
            this.btnAceptarE.Text = "Aceptar";
            this.btnAceptarE.UseVisualStyleBackColor = true;
            this.btnAceptarE.Click += new System.EventHandler(this.btnAceptarE_Click);
            // 
            // tbNombreAlumno
            // 
            this.tbNombreAlumno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbNombreAlumno.Location = new System.Drawing.Point(18, 54);
            this.tbNombreAlumno.Name = "tbNombreAlumno";
            this.tbNombreAlumno.Size = new System.Drawing.Size(460, 25);
            this.tbNombreAlumno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del alumno:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminacionGrupal);
            this.groupBox2.Controls.Add(this.cboxGrupo);
            this.groupBox2.Controls.Add(this.cboxGrado);
            this.groupBox2.Controls.Add(this.cbGrado);
            this.groupBox2.Controls.Add(this.cbGrupo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(13, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminación grupal";
            // 
            // btnEliminacionGrupal
            // 
            this.btnEliminacionGrupal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminacionGrupal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminacionGrupal.Location = new System.Drawing.Point(484, 143);
            this.btnEliminacionGrupal.Name = "btnEliminacionGrupal";
            this.btnEliminacionGrupal.Size = new System.Drawing.Size(92, 27);
            this.btnEliminacionGrupal.TabIndex = 7;
            this.btnEliminacionGrupal.Text = "Aceptar";
            this.btnEliminacionGrupal.UseVisualStyleBackColor = true;
            this.btnEliminacionGrupal.Click += new System.EventHandler(this.btnEliminacionGrupal_Click);
            // 
            // cboxGrupo
            // 
            this.cboxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGrupo.FormattingEnabled = true;
            this.cboxGrupo.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cboxGrupo.Location = new System.Drawing.Point(114, 131);
            this.cboxGrupo.Name = "cboxGrupo";
            this.cboxGrupo.Size = new System.Drawing.Size(121, 26);
            this.cboxGrupo.TabIndex = 6;
            // 
            // cboxGrado
            // 
            this.cboxGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGrado.FormattingEnabled = true;
            this.cboxGrado.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboxGrado.Location = new System.Drawing.Point(113, 92);
            this.cboxGrado.Name = "cboxGrado";
            this.cboxGrado.Size = new System.Drawing.Size(121, 26);
            this.cboxGrado.TabIndex = 5;
            // 
            // cbGrado
            // 
            this.cbGrado.AutoSize = true;
            this.cbGrado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbGrado.Location = new System.Drawing.Point(21, 94);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(86, 22);
            this.cbGrado.TabIndex = 4;
            this.cbGrado.Text = "Por grado";
            this.cbGrado.UseVisualStyleBackColor = true;
            this.cbGrado.CheckedChanged += new System.EventHandler(this.cbGrado_CheckedChanged);
            // 
            // cbGrupo
            // 
            this.cbGrupo.AutoSize = true;
            this.cbGrupo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbGrupo.Location = new System.Drawing.Point(21, 133);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(87, 22);
            this.cbGrupo.TabIndex = 3;
            this.cbGrupo.Text = "Por grupo";
            this.cbGrupo.UseVisualStyleBackColor = true;
            this.cbGrupo.CheckedChanged += new System.EventHandler(this.cbGrupo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "La eliminación grupal eliminara de forma permanente el grupo dealumno seleccionad" +
    "os a partir \r\nde los siguientes parámetros.";
            // 
            // Eliminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 322);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Eliminacion";
            this.Text = "Eliminacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNombreAlumno;
        private System.Windows.Forms.Button btnAceptarE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboxGrado;
        private System.Windows.Forms.CheckBox cbGrado;
        private System.Windows.Forms.CheckBox cbGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminacionGrupal;
        private System.Windows.Forms.ComboBox cboxGrupo;
    }
}