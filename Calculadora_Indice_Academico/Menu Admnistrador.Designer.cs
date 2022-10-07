namespace Calculadora_Indice_Academico
{
    partial class Menu_Admnistrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Admnistrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_estudiantes = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.StudentsPanel = new System.Windows.Forms.Panel();
            this.btn_agregarEstudiantes = new System.Windows.Forms.Button();
            this.btn_eliminarEstudiantes = new System.Windows.Forms.Button();
            this.btn_profesores = new System.Windows.Forms.Button();
            this.Profesores_Panel = new System.Windows.Forms.Panel();
            this.btn_agregarProfesores = new System.Windows.Forms.Button();
            this.btn_eliminarProfesores = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StudentsPanel.SuspendLayout();
            this.Profesores_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.Profesores_Panel);
            this.panel1.Controls.Add(this.btn_profesores);
            this.panel1.Controls.Add(this.StudentsPanel);
            this.panel1.Controls.Add(this.btn_estudiantes);
            this.panel1.Controls.Add(this.pnlUsuario);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 815);
            this.panel1.TabIndex = 0;
            // 
            // btn_estudiantes
            // 
            this.btn_estudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btn_estudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_estudiantes.FlatAppearance.BorderSize = 0;
            this.btn_estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estudiantes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estudiantes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_estudiantes.Image = ((System.Drawing.Image)(resources.GetObject("btn_estudiantes.Image")));
            this.btn_estudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estudiantes.Location = new System.Drawing.Point(0, 60);
            this.btn_estudiantes.Name = "btn_estudiantes";
            this.btn_estudiantes.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btn_estudiantes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_estudiantes.Size = new System.Drawing.Size(246, 60);
            this.btn_estudiantes.TabIndex = 5;
            this.btn_estudiantes.Text = "Estudiantes";
            this.btn_estudiantes.UseVisualStyleBackColor = false;
            this.btn_estudiantes.Click += new System.EventHandler(this.btn_estudiantes_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.btnSetting);
            this.pnlUsuario.Controls.Add(this.label2);
            this.pnlUsuario.Controls.Add(this.label1);
            this.pnlUsuario.Controls.Add(this.pictureBox1);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 655);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(246, 100);
            this.pnlUsuario.TabIndex = 4;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Image = global::Calculadora_Indice_Academico.Properties.Resources.settings_32x32;
            this.btnSetting.Location = new System.Drawing.Point(190, 25);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(48, 48);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "View profile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(80, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora_Indice_Academico.Properties.Resources.perfil;
            this.pictureBox1.Location = new System.Drawing.Point(10, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Image = global::Calculadora_Indice_Academico.Properties.Resources.log_out_32x32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 755);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btnLogout.Size = new System.Drawing.Size(246, 60);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDashboard.Image = global::Calculadora_Indice_Academico.Properties.Resources.home;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btnDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDashboard.Size = new System.Drawing.Size(246, 60);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // StudentsPanel
            // 
            this.StudentsPanel.Controls.Add(this.btn_eliminarEstudiantes);
            this.StudentsPanel.Controls.Add(this.btn_agregarEstudiantes);
            this.StudentsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentsPanel.Location = new System.Drawing.Point(0, 120);
            this.StudentsPanel.Name = "StudentsPanel";
            this.StudentsPanel.Size = new System.Drawing.Size(246, 123);
            this.StudentsPanel.TabIndex = 6;
            // 
            // btn_agregarEstudiantes
            // 
            this.btn_agregarEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_agregarEstudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_agregarEstudiantes.FlatAppearance.BorderSize = 0;
            this.btn_agregarEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarEstudiantes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarEstudiantes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_agregarEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregarEstudiantes.Location = new System.Drawing.Point(0, 0);
            this.btn_agregarEstudiantes.Name = "btn_agregarEstudiantes";
            this.btn_agregarEstudiantes.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btn_agregarEstudiantes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_agregarEstudiantes.Size = new System.Drawing.Size(246, 60);
            this.btn_agregarEstudiantes.TabIndex = 6;
            this.btn_agregarEstudiantes.Text = "Agregar Estudiantes";
            this.btn_agregarEstudiantes.UseVisualStyleBackColor = false;
            this.btn_agregarEstudiantes.Click += new System.EventHandler(this.btn_agregarEstudiantes_Click);
            // 
            // btn_eliminarEstudiantes
            // 
            this.btn_eliminarEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_eliminarEstudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_eliminarEstudiantes.FlatAppearance.BorderSize = 0;
            this.btn_eliminarEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarEstudiantes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarEstudiantes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_eliminarEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminarEstudiantes.Location = new System.Drawing.Point(0, 60);
            this.btn_eliminarEstudiantes.Name = "btn_eliminarEstudiantes";
            this.btn_eliminarEstudiantes.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btn_eliminarEstudiantes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_eliminarEstudiantes.Size = new System.Drawing.Size(246, 60);
            this.btn_eliminarEstudiantes.TabIndex = 7;
            this.btn_eliminarEstudiantes.Text = "Eliminar Estudiantes";
            this.btn_eliminarEstudiantes.UseVisualStyleBackColor = false;
            this.btn_eliminarEstudiantes.Click += new System.EventHandler(this.btn_eliminarEstudiantes_Click);
            // 
            // btn_profesores
            // 
            this.btn_profesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btn_profesores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_profesores.FlatAppearance.BorderSize = 0;
            this.btn_profesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profesores.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profesores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_profesores.Image = ((System.Drawing.Image)(resources.GetObject("btn_profesores.Image")));
            this.btn_profesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profesores.Location = new System.Drawing.Point(0, 243);
            this.btn_profesores.Name = "btn_profesores";
            this.btn_profesores.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btn_profesores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_profesores.Size = new System.Drawing.Size(246, 60);
            this.btn_profesores.TabIndex = 7;
            this.btn_profesores.Text = "Profesores";
            this.btn_profesores.UseVisualStyleBackColor = false;
            this.btn_profesores.Click += new System.EventHandler(this.btn_profesores_Click);
            // 
            // Profesores_Panel
            // 
            this.Profesores_Panel.Controls.Add(this.btn_eliminarProfesores);
            this.Profesores_Panel.Controls.Add(this.btn_agregarProfesores);
            this.Profesores_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Profesores_Panel.Location = new System.Drawing.Point(0, 303);
            this.Profesores_Panel.Name = "Profesores_Panel";
            this.Profesores_Panel.Size = new System.Drawing.Size(246, 129);
            this.Profesores_Panel.TabIndex = 8;
            // 
            // btn_agregarProfesores
            // 
            this.btn_agregarProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_agregarProfesores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_agregarProfesores.FlatAppearance.BorderSize = 0;
            this.btn_agregarProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProfesores.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarProfesores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_agregarProfesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregarProfesores.Location = new System.Drawing.Point(0, 0);
            this.btn_agregarProfesores.Name = "btn_agregarProfesores";
            this.btn_agregarProfesores.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btn_agregarProfesores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_agregarProfesores.Size = new System.Drawing.Size(246, 60);
            this.btn_agregarProfesores.TabIndex = 7;
            this.btn_agregarProfesores.Text = "Agregar Profesores";
            this.btn_agregarProfesores.UseVisualStyleBackColor = false;
            this.btn_agregarProfesores.Click += new System.EventHandler(this.btn_agregarProfesores_Click);
            // 
            // btn_eliminarProfesores
            // 
            this.btn_eliminarProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_eliminarProfesores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_eliminarProfesores.FlatAppearance.BorderSize = 0;
            this.btn_eliminarProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarProfesores.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarProfesores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_eliminarProfesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminarProfesores.Location = new System.Drawing.Point(0, 60);
            this.btn_eliminarProfesores.Name = "btn_eliminarProfesores";
            this.btn_eliminarProfesores.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btn_eliminarProfesores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_eliminarProfesores.Size = new System.Drawing.Size(246, 69);
            this.btn_eliminarProfesores.TabIndex = 8;
            this.btn_eliminarProfesores.Text = "Eliminar Profesores";
            this.btn_eliminarProfesores.UseVisualStyleBackColor = false;
            this.btn_eliminarProfesores.Click += new System.EventHandler(this.btn_eliminarProfesores_Click);
            // 
            // Menu_Admnistrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 815);
            this.Controls.Add(this.panel1);
            this.Name = "Menu_Admnistrador";
            this.Text = "Menu_Admnistrador";
            this.panel1.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StudentsPanel.ResumeLayout(false);
            this.Profesores_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_estudiantes;
        private System.Windows.Forms.Panel StudentsPanel;
        private System.Windows.Forms.Button btn_eliminarEstudiantes;
        private System.Windows.Forms.Button btn_agregarEstudiantes;
        private System.Windows.Forms.Panel Profesores_Panel;
        private System.Windows.Forms.Button btn_eliminarProfesores;
        private System.Windows.Forms.Button btn_agregarProfesores;
        private System.Windows.Forms.Button btn_profesores;
    }
}