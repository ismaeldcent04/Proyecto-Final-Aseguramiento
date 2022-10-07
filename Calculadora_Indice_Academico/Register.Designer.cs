namespace Calculadora_Indice_Academico
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_registrarUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CorreoUsuario = new System.Windows.Forms.TextBox();
            this.txt_idUsuario = new System.Windows.Forms.TextBox();
            this.txt_contraseñaUsuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_nombreUsuario.Location = new System.Drawing.Point(449, 158);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(246, 20);
            this.txt_nombreUsuario.TabIndex = 0;
            this.txt_nombreUsuario.TextChanged += new System.EventHandler(this.txt_nombreUsuario_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_registrarUsuario
            // 
            this.lbl_registrarUsuario.AutoSize = true;
            this.lbl_registrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registrarUsuario.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_registrarUsuario.Location = new System.Drawing.Point(442, 62);
            this.lbl_registrarUsuario.Name = "lbl_registrarUsuario";
            this.lbl_registrarUsuario.Size = new System.Drawing.Size(266, 37);
            this.lbl_registrarUsuario.TabIndex = 2;
            this.lbl_registrarUsuario.Text = "Registrar Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Correo Institucional";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contraseña";
            // 
            // txt_CorreoUsuario
            // 
            this.txt_CorreoUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_CorreoUsuario.Location = new System.Drawing.Point(449, 200);
            this.txt_CorreoUsuario.Name = "txt_CorreoUsuario";
            this.txt_CorreoUsuario.Size = new System.Drawing.Size(246, 20);
            this.txt_CorreoUsuario.TabIndex = 10;
            // 
            // txt_idUsuario
            // 
            this.txt_idUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_idUsuario.Location = new System.Drawing.Point(449, 239);
            this.txt_idUsuario.Name = "txt_idUsuario";
            this.txt_idUsuario.Size = new System.Drawing.Size(246, 20);
            this.txt_idUsuario.TabIndex = 11;
            // 
            // txt_contraseñaUsuario
            // 
            this.txt_contraseñaUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_contraseñaUsuario.Location = new System.Drawing.Point(449, 278);
            this.txt_contraseñaUsuario.Name = "txt_contraseñaUsuario";
            this.txt_contraseñaUsuario.Size = new System.Drawing.Size(246, 20);
            this.txt_contraseñaUsuario.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(479, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Registrar Usuario";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_contraseñaUsuario);
            this.Controls.Add(this.txt_idUsuario);
            this.Controls.Add(this.txt_CorreoUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_registrarUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_nombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_registrarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CorreoUsuario;
        private System.Windows.Forms.TextBox txt_idUsuario;
        private System.Windows.Forms.TextBox txt_contraseñaUsuario;
        private System.Windows.Forms.Button button1;
    }
}