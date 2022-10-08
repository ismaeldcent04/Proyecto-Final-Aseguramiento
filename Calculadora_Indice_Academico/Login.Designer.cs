namespace Calculadora_Indice_Academico
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbl_olvidasteContraseña = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txt_contraseñaUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.llb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(709, 339);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Recordar usuario";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // lbl_olvidasteContraseña
            // 
            this.lbl_olvidasteContraseña.AutoSize = true;
            this.lbl_olvidasteContraseña.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_olvidasteContraseña.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_olvidasteContraseña.Location = new System.Drawing.Point(910, 340);
            this.lbl_olvidasteContraseña.Name = "lbl_olvidasteContraseña";
            this.lbl_olvidasteContraseña.Size = new System.Drawing.Size(125, 13);
            this.lbl_olvidasteContraseña.TabIndex = 4;
            this.lbl_olvidasteContraseña.Text = "Olvidaste tu contraseña?";
            this.lbl_olvidasteContraseña.Click += new System.EventHandler(this.lbl_olvidasteContraseña_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(811, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Log In";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(788, 371);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(172, 25);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txt_contraseñaUsuario
            // 
            this.txt_contraseñaUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_contraseñaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseñaUsuario.Location = new System.Drawing.Point(709, 313);
            this.txt_contraseñaUsuario.Name = "txt_contraseñaUsuario";
            this.txt_contraseñaUsuario.Size = new System.Drawing.Size(326, 13);
            this.txt_contraseñaUsuario.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(129, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(512, 40);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cálculo de Índice Académico";
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_nombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombreUsuario.Location = new System.Drawing.Point(709, 274);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(326, 13);
            this.txt_nombreUsuario.TabIndex = 14;
            this.txt_nombreUsuario.TextChanged += new System.EventHandler(this.txt_nombreUsuario_TextChanged);
            // 
            // llb
            // 
            this.llb.AutoSize = true;
            this.llb.BackColor = System.Drawing.Color.White;
            this.llb.ForeColor = System.Drawing.Color.IndianRed;
            this.llb.Location = new System.Drawing.Point(843, 419);
            this.llb.Name = "llb";
            this.llb.Size = new System.Drawing.Size(49, 13);
            this.llb.TabIndex = 6;
            this.llb.Text = "Registrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(706, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Contraseña";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(635, 386);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // close_button
            // 
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.close_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Image = ((System.Drawing.Image)(resources.GetObject("close_button.Image")));
            this.close_button.Location = new System.Drawing.Point(1062, 1);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(27, 23);
            this.close_button.TabIndex = 13;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1090, 620);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombreUsuario);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_contraseñaUsuario);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.llb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_olvidasteContraseña);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbl_olvidasteContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txt_contraseñaUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.Label llb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button close_button;
    }
}

