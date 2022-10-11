namespace Calculadora_Indice_Academico
{
    partial class AgregarEstudiantes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgw_estudiantes = new System.Windows.Forms.DataGridView();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellidoP = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.pnlDatosGenerales = new System.Windows.Forms.Panel();
            this.txt_d_cedula = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_d_apellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_d_nombre = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_d_telefono = new System.Windows.Forms.TextBox();
            this.txt_d_contrasena = new System.Windows.Forms.TextBox();
            this.txt_d_correo = new System.Windows.Forms.TextBox();
            this.txt_d_carrera = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_d_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apellidoS = new System.Windows.Forms.TextBox();
            this.cmb_carrera = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_estudiantes)).BeginInit();
            this.pnlDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 44);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Estudiante";
            // 
            // dgw_estudiantes
            // 
            this.dgw_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_estudiantes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgw_estudiantes.Location = new System.Drawing.Point(0, 522);
            this.dgw_estudiantes.Name = "dgw_estudiantes";
            this.dgw_estudiantes.Size = new System.Drawing.Size(1080, 277);
            this.dgw_estudiantes.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(39, 162);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(171, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // txt_apellidoP
            // 
            this.txt_apellidoP.Location = new System.Drawing.Point(39, 217);
            this.txt_apellidoP.Name = "txt_apellidoP";
            this.txt_apellidoP.Size = new System.Drawing.Size(171, 20);
            this.txt_apellidoP.TabIndex = 3;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(97, 355);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(249, 23);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar ";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(36, 146);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 6;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(36, 201);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(76, 13);
            this.lbl_apellido.TabIndex = 7;
            this.lbl_apellido.Text = "Primer Apellido";
            this.lbl_apellido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Carrera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Correo";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(246, 217);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(192, 20);
            this.txt_correo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Contraseña";
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(246, 270);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(192, 20);
            this.txt_contrasena.TabIndex = 13;
            // 
            // pnlDatosGenerales
            // 
            this.pnlDatosGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.pnlDatosGenerales.Controls.Add(this.txt_d_cedula);
            this.pnlDatosGenerales.Controls.Add(this.label22);
            this.pnlDatosGenerales.Controls.Add(this.label23);
            this.pnlDatosGenerales.Controls.Add(this.txt_d_apellido);
            this.pnlDatosGenerales.Controls.Add(this.label7);
            this.pnlDatosGenerales.Controls.Add(this.label17);
            this.pnlDatosGenerales.Controls.Add(this.txt_d_nombre);
            this.pnlDatosGenerales.Controls.Add(this.label15);
            this.pnlDatosGenerales.Controls.Add(this.label16);
            this.pnlDatosGenerales.Controls.Add(this.label13);
            this.pnlDatosGenerales.Controls.Add(this.txt_d_telefono);
            this.pnlDatosGenerales.Controls.Add(this.txt_d_contrasena);
            this.pnlDatosGenerales.Controls.Add(this.txt_d_correo);
            this.pnlDatosGenerales.Controls.Add(this.txt_d_carrera);
            this.pnlDatosGenerales.Controls.Add(this.label10);
            this.pnlDatosGenerales.Controls.Add(this.label11);
            this.pnlDatosGenerales.Controls.Add(this.label8);
            this.pnlDatosGenerales.Controls.Add(this.label9);
            this.pnlDatosGenerales.Controls.Add(this.txt_d_ID);
            this.pnlDatosGenerales.Controls.Add(this.label6);
            this.pnlDatosGenerales.Controls.Add(this.label12);
            this.pnlDatosGenerales.Controls.Add(this.pictureBox2);
            this.pnlDatosGenerales.Controls.Add(this.label19);
            this.pnlDatosGenerales.Controls.Add(this.label20);
            this.pnlDatosGenerales.Controls.Add(this.label21);
            this.pnlDatosGenerales.Location = new System.Drawing.Point(504, 102);
            this.pnlDatosGenerales.Name = "pnlDatosGenerales";
            this.pnlDatosGenerales.Size = new System.Drawing.Size(513, 343);
            this.pnlDatosGenerales.TabIndex = 22;
            // 
            // txt_d_cedula
            // 
            this.txt_d_cedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txt_d_cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_d_cedula.Location = new System.Drawing.Point(365, 253);
            this.txt_d_cedula.Name = "txt_d_cedula";
            this.txt_d_cedula.Size = new System.Drawing.Size(112, 13);
            this.txt_d_cedula.TabIndex = 35;
            this.txt_d_cedula.Text = "8098754411";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(376, 253);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 16);
            this.label22.TabIndex = 34;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(287, 253);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 16);
            this.label23.TabIndex = 33;
            this.label23.Text = "Cedula:";
            // 
            // txt_d_apellido
            // 
            this.txt_d_apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txt_d_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_d_apellido.Location = new System.Drawing.Point(98, 253);
            this.txt_d_apellido.Name = "txt_d_apellido";
            this.txt_d_apellido.Size = new System.Drawing.Size(158, 13);
            this.txt_d_apellido.TabIndex = 32;
            this.txt_d_apellido.Text = "Dicent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(26, 250);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Apellido:";
            // 
            // txt_d_nombre
            // 
            this.txt_d_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txt_d_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_d_nombre.Location = new System.Drawing.Point(98, 213);
            this.txt_d_nombre.Name = "txt_d_nombre";
            this.txt_d_nombre.Size = new System.Drawing.Size(158, 13);
            this.txt_d_nombre.TabIndex = 28;
            this.txt_d_nombre.Text = "Ismael";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(115, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 16);
            this.label15.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 16);
            this.label16.TabIndex = 26;
            this.label16.Text = "Nombre:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(796, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 24;
            // 
            // txt_d_telefono
            // 
            this.txt_d_telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txt_d_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_d_telefono.Location = new System.Drawing.Point(365, 215);
            this.txt_d_telefono.Name = "txt_d_telefono";
            this.txt_d_telefono.Size = new System.Drawing.Size(112, 13);
            this.txt_d_telefono.TabIndex = 22;
            this.txt_d_telefono.Text = "8098754411";
            // 
            // txt_d_contrasena
            // 
            this.txt_d_contrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txt_d_contrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_d_contrasena.Location = new System.Drawing.Point(382, 176);
            this.txt_d_contrasena.Name = "txt_d_contrasena";
            this.txt_d_contrasena.Size = new System.Drawing.Size(115, 13);
            this.txt_d_contrasena.TabIndex = 21;
            this.txt_d_contrasena.Text = "12345intec";
            // 
            // txt_d_correo
            // 
            this.txt_d_correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txt_d_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_d_correo.Location = new System.Drawing.Point(353, 141);
            this.txt_d_correo.Name = "txt_d_correo";
            this.txt_d_correo.Size = new System.Drawing.Size(130, 13);
            this.txt_d_correo.TabIndex = 20;
            this.txt_d_correo.Text = "1100368@est.intec.edu";
            // 
            // txt_d_carrera
            // 
            this.txt_d_carrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txt_d_carrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_d_carrera.Location = new System.Drawing.Point(109, 177);
            this.txt_d_carrera.Name = "txt_d_carrera";
            this.txt_d_carrera.Size = new System.Drawing.Size(158, 13);
            this.txt_d_carrera.TabIndex = 17;
            this.txt_d_carrera.Text = "(IDS 2020) Ing. De Software";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(376, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(287, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Telefóno:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(376, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(287, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Contraseña:";
            // 
            // txt_d_ID
            // 
            this.txt_d_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.txt_d_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_d_ID.Location = new System.Drawing.Point(60, 143);
            this.txt_d_ID.Name = "txt_d_ID";
            this.txt_d_ID.Size = new System.Drawing.Size(158, 13);
            this.txt_d_ID.TabIndex = 6;
            this.txt_d_ID.Text = "1100368";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(379, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(287, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Correo:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Calculadora_Indice_Academico.Properties.Resources.user_in_a_square_150x150;
            this.pictureBox2.Location = new System.Drawing.Point(19, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(25, 175);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "Programa:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(29, 140);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 16);
            this.label20.TabIndex = 1;
            this.label20.Text = "ID:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label21.Location = new System.Drawing.Point(195, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(230, 32);
            this.label21.TabIndex = 0;
            this.label21.Text = "Datos Generales";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Telefono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(39, 317);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(171, 20);
            this.txt_telefono.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(243, 299);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Cedula";
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(246, 315);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(192, 20);
            this.txt_cedula.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Segundo Apellido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_apellidoS
            // 
            this.txt_apellidoS.Location = new System.Drawing.Point(39, 270);
            this.txt_apellidoS.Name = "txt_apellidoS";
            this.txt_apellidoS.Size = new System.Drawing.Size(171, 20);
            this.txt_apellidoS.TabIndex = 27;
            // 
            // cmb_carrera
            // 
            this.cmb_carrera.FormattingEnabled = true;
            this.cmb_carrera.Location = new System.Drawing.Point(246, 162);
            this.cmb_carrera.Name = "cmb_carrera";
            this.cmb_carrera.Size = new System.Drawing.Size(192, 21);
            this.cmb_carrera.TabIndex = 29;
            // 
            // AgregarEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_carrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_apellidoS);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.pnlDatosGenerales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_apellidoP);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.dgw_estudiantes);
            this.Controls.Add(this.label1);
            this.Name = "AgregarEstudiantes";
            this.Size = new System.Drawing.Size(1080, 799);
            this.Load += new System.EventHandler(this.AgregarEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_estudiantes)).EndInit();
            this.pnlDatosGenerales.ResumeLayout(false);
            this.pnlDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgw_estudiantes;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellidoP;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Panel pnlDatosGenerales;
        private System.Windows.Forms.TextBox txt_d_apellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_d_nombre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_d_telefono;
        private System.Windows.Forms.TextBox txt_d_contrasena;
        private System.Windows.Forms.TextBox txt_d_correo;
        private System.Windows.Forms.TextBox txt_d_carrera;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_d_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_d_cedula;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_apellidoS;
        private System.Windows.Forms.ComboBox cmb_carrera;
    }
}
