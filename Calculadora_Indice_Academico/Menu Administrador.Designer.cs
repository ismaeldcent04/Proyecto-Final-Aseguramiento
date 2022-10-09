namespace Calculadora_Indice_Academico
{
    partial class Menu_Administrador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.PanelTeachers = new System.Windows.Forms.Panel();
            this.btn_EliminarProfesores = new System.Windows.Forms.Button();
            this.btn_AgregarProfesores = new System.Windows.Forms.Button();
            this.btn_Profesores = new System.Windows.Forms.Button();
            this.panelStudents = new System.Windows.Forms.Panel();
            this.btn_EliminarEstudiantes = new System.Windows.Forms.Button();
            this.btn_AgregarEstudiantes = new System.Windows.Forms.Button();
            this.btn_estudiantes = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.agregarEstudiantes1 = new Calculadora_Indice_Academico.AgregarEstudiantes();
            this.eliminarEstudiantes1 = new Calculadora_Indice_Academico.btn_eliminar();
            this.agregarProfesores1 = new Calculadora_Indice_Academico.AgregarProfesores();
            this.eliminarProfesores1 = new Calculadora_Indice_Academico.EliminarProfesores();
            this.panel1.SuspendLayout();
            this.PanelTeachers.SuspendLayout();
            this.panelStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.PanelTeachers);
            this.panel1.Controls.Add(this.btn_Profesores);
            this.panel1.Controls.Add(this.panelStudents);
            this.panel1.Controls.Add(this.btn_estudiantes);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 811);
            this.panel1.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Logout.Image = global::Calculadora_Indice_Academico.Properties.Resources.log_out_32x32;
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Location = new System.Drawing.Point(0, 751);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btn_Logout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Logout.Size = new System.Drawing.Size(253, 60);
            this.btn_Logout.TabIndex = 8;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // PanelTeachers
            // 
            this.PanelTeachers.BackColor = System.Drawing.Color.White;
            this.PanelTeachers.Controls.Add(this.btn_EliminarProfesores);
            this.PanelTeachers.Controls.Add(this.btn_AgregarProfesores);
            this.PanelTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTeachers.Location = new System.Drawing.Point(0, 299);
            this.PanelTeachers.Name = "PanelTeachers";
            this.PanelTeachers.Size = new System.Drawing.Size(253, 119);
            this.PanelTeachers.TabIndex = 7;
            // 
            // btn_EliminarProfesores
            // 
            this.btn_EliminarProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_EliminarProfesores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_EliminarProfesores.FlatAppearance.BorderSize = 0;
            this.btn_EliminarProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarProfesores.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarProfesores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_EliminarProfesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EliminarProfesores.Location = new System.Drawing.Point(0, 60);
            this.btn_EliminarProfesores.Name = "btn_EliminarProfesores";
            this.btn_EliminarProfesores.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btn_EliminarProfesores.Size = new System.Drawing.Size(253, 59);
            this.btn_EliminarProfesores.TabIndex = 6;
            this.btn_EliminarProfesores.Text = "Editar Profesores";
            this.btn_EliminarProfesores.UseVisualStyleBackColor = false;
            this.btn_EliminarProfesores.Click += new System.EventHandler(this.btn_EliminarProfesores_Click);
            // 
            // btn_AgregarProfesores
            // 
            this.btn_AgregarProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_AgregarProfesores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AgregarProfesores.FlatAppearance.BorderSize = 0;
            this.btn_AgregarProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarProfesores.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarProfesores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_AgregarProfesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AgregarProfesores.Location = new System.Drawing.Point(0, 0);
            this.btn_AgregarProfesores.Name = "btn_AgregarProfesores";
            this.btn_AgregarProfesores.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btn_AgregarProfesores.Size = new System.Drawing.Size(253, 60);
            this.btn_AgregarProfesores.TabIndex = 5;
            this.btn_AgregarProfesores.Text = "Agregar Profesores";
            this.btn_AgregarProfesores.UseVisualStyleBackColor = false;
            this.btn_AgregarProfesores.Click += new System.EventHandler(this.btn_AgregarProfesores_Click);
            // 
            // btn_Profesores
            // 
            this.btn_Profesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btn_Profesores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Profesores.FlatAppearance.BorderSize = 0;
            this.btn_Profesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profesores.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profesores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Profesores.Image = global::Calculadora_Indice_Academico.Properties.Resources._class;
            this.btn_Profesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profesores.Location = new System.Drawing.Point(0, 239);
            this.btn_Profesores.Name = "btn_Profesores";
            this.btn_Profesores.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btn_Profesores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Profesores.Size = new System.Drawing.Size(253, 60);
            this.btn_Profesores.TabIndex = 6;
            this.btn_Profesores.Text = "Profesores";
            this.btn_Profesores.UseVisualStyleBackColor = false;
            this.btn_Profesores.Click += new System.EventHandler(this.btn_Profesores_Click);
            // 
            // panelStudents
            // 
            this.panelStudents.BackColor = System.Drawing.Color.White;
            this.panelStudents.Controls.Add(this.btn_EliminarEstudiantes);
            this.panelStudents.Controls.Add(this.btn_AgregarEstudiantes);
            this.panelStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudents.Location = new System.Drawing.Point(0, 120);
            this.panelStudents.Name = "panelStudents";
            this.panelStudents.Size = new System.Drawing.Size(253, 119);
            this.panelStudents.TabIndex = 5;
            // 
            // btn_EliminarEstudiantes
            // 
            this.btn_EliminarEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_EliminarEstudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_EliminarEstudiantes.FlatAppearance.BorderSize = 0;
            this.btn_EliminarEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarEstudiantes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarEstudiantes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_EliminarEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EliminarEstudiantes.Location = new System.Drawing.Point(0, 60);
            this.btn_EliminarEstudiantes.Name = "btn_EliminarEstudiantes";
            this.btn_EliminarEstudiantes.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btn_EliminarEstudiantes.Size = new System.Drawing.Size(253, 59);
            this.btn_EliminarEstudiantes.TabIndex = 6;
            this.btn_EliminarEstudiantes.Text = "Editar Estudiantes";
            this.btn_EliminarEstudiantes.UseVisualStyleBackColor = false;
            this.btn_EliminarEstudiantes.Click += new System.EventHandler(this.btn_EliminarEstudiantes_Click);
            // 
            // btn_AgregarEstudiantes
            // 
            this.btn_AgregarEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_AgregarEstudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AgregarEstudiantes.FlatAppearance.BorderSize = 0;
            this.btn_AgregarEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarEstudiantes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarEstudiantes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_AgregarEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AgregarEstudiantes.Location = new System.Drawing.Point(0, 0);
            this.btn_AgregarEstudiantes.Name = "btn_AgregarEstudiantes";
            this.btn_AgregarEstudiantes.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btn_AgregarEstudiantes.Size = new System.Drawing.Size(253, 60);
            this.btn_AgregarEstudiantes.TabIndex = 5;
            this.btn_AgregarEstudiantes.Text = "Agregar Estudiantes";
            this.btn_AgregarEstudiantes.UseVisualStyleBackColor = false;
            this.btn_AgregarEstudiantes.Click += new System.EventHandler(this.btn_AgregarEstudiantes_Click);
            // 
            // btn_estudiantes
            // 
            this.btn_estudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btn_estudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_estudiantes.FlatAppearance.BorderSize = 0;
            this.btn_estudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estudiantes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estudiantes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_estudiantes.Image = global::Calculadora_Indice_Academico.Properties.Resources.Students;
            this.btn_estudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_estudiantes.Location = new System.Drawing.Point(0, 60);
            this.btn_estudiantes.Name = "btn_estudiantes";
            this.btn_estudiantes.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btn_estudiantes.Size = new System.Drawing.Size(253, 60);
            this.btn_estudiantes.TabIndex = 4;
            this.btn_estudiantes.Text = "Estudiantes";
            this.btn_estudiantes.UseVisualStyleBackColor = false;
            this.btn_estudiantes.Click += new System.EventHandler(this.btn_estudiantes_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDashboard.Image = global::Calculadora_Indice_Academico.Properties.Resources.home;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btnDashboard.Size = new System.Drawing.Size(253, 60);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // agregarEstudiantes1
            // 
            this.agregarEstudiantes1.Location = new System.Drawing.Point(251, 0);
            this.agregarEstudiantes1.Name = "agregarEstudiantes1";
            this.agregarEstudiantes1.Size = new System.Drawing.Size(1091, 799);
            this.agregarEstudiantes1.TabIndex = 1;
            // 
            // eliminarEstudiantes1
            // 
            this.eliminarEstudiantes1.Location = new System.Drawing.Point(251, 0);
            this.eliminarEstudiantes1.Name = "eliminarEstudiantes1";
            this.eliminarEstudiantes1.Size = new System.Drawing.Size(1080, 799);
            this.eliminarEstudiantes1.TabIndex = 2;
            // 
            // agregarProfesores1
            // 
            this.agregarProfesores1.Location = new System.Drawing.Point(251, 0);
            this.agregarProfesores1.Name = "agregarProfesores1";
            this.agregarProfesores1.Size = new System.Drawing.Size(1080, 799);
            this.agregarProfesores1.TabIndex = 3;
            // 
            // eliminarProfesores1
            // 
            this.eliminarProfesores1.Location = new System.Drawing.Point(251, 0);
            this.eliminarProfesores1.Name = "eliminarProfesores1";
            this.eliminarProfesores1.Size = new System.Drawing.Size(1080, 799);
            this.eliminarProfesores1.TabIndex = 4;
            // 
            // Menu_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 811);
            this.Controls.Add(this.eliminarProfesores1);
            this.Controls.Add(this.agregarProfesores1);
            this.Controls.Add(this.eliminarEstudiantes1);
            this.Controls.Add(this.agregarEstudiantes1);
            this.Controls.Add(this.panel1);
            this.Name = "Menu_Administrador";
            this.Text = "Menu_Administrador";
            this.panel1.ResumeLayout(false);
            this.PanelTeachers.ResumeLayout(false);
            this.panelStudents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelStudents;
        private System.Windows.Forms.Button btn_EliminarEstudiantes;
        private System.Windows.Forms.Button btn_AgregarEstudiantes;
        private System.Windows.Forms.Button btn_estudiantes;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btn_Profesores;
        private System.Windows.Forms.Panel PanelTeachers;
        private System.Windows.Forms.Button btn_EliminarProfesores;
        private System.Windows.Forms.Button btn_AgregarProfesores;
        private System.Windows.Forms.Button btn_Logout;
        private AgregarEstudiantes agregarEstudiantes1;
        private btn_eliminar eliminarEstudiantes1;
        private AgregarProfesores agregarProfesores1;
        private EliminarProfesores eliminarProfesores1;
    }
}