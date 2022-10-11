namespace Calculadora_Indice_Academico
{
    partial class Recuperar_ContraseñaHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recuperar_ContraseñaHome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdUsuario = new System.Windows.Forms.TextBox();
            this.txt_correoUsuario = new System.Windows.Forms.TextBox();
            this.btn_recuperarContraseña = new System.Windows.Forms.Button();
            this.lbl_idUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(433, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recuperar Contraseña";
            // 
            // txt_IdUsuario
            // 
            this.txt_IdUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_IdUsuario.Location = new System.Drawing.Point(440, 185);
            this.txt_IdUsuario.Name = "txt_IdUsuario";
            this.txt_IdUsuario.Size = new System.Drawing.Size(308, 20);
            this.txt_IdUsuario.TabIndex = 2;
            // 
            // txt_correoUsuario
            // 
            this.txt_correoUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_correoUsuario.Location = new System.Drawing.Point(440, 265);
            this.txt_correoUsuario.Name = "txt_correoUsuario";
            this.txt_correoUsuario.Size = new System.Drawing.Size(308, 20);
            this.txt_correoUsuario.TabIndex = 3;
            // 
            // btn_recuperarContraseña
            // 
            this.btn_recuperarContraseña.BackColor = System.Drawing.Color.IndianRed;
            this.btn_recuperarContraseña.ForeColor = System.Drawing.Color.White;
            this.btn_recuperarContraseña.Location = new System.Drawing.Point(590, 322);
            this.btn_recuperarContraseña.Name = "btn_recuperarContraseña";
            this.btn_recuperarContraseña.Size = new System.Drawing.Size(158, 23);
            this.btn_recuperarContraseña.TabIndex = 4;
            this.btn_recuperarContraseña.Text = "Recuperar Contraseña";
            this.btn_recuperarContraseña.UseVisualStyleBackColor = false;
            this.btn_recuperarContraseña.Click += new System.EventHandler(this.btn_recuperarContraseña_Click);
            // 
            // lbl_idUsuario
            // 
            this.lbl_idUsuario.AutoSize = true;
            this.lbl_idUsuario.Location = new System.Drawing.Point(440, 166);
            this.lbl_idUsuario.Name = "lbl_idUsuario";
            this.lbl_idUsuario.Size = new System.Drawing.Size(57, 13);
            this.lbl_idUsuario.TabIndex = 5;
            this.lbl_idUsuario.Text = "ID Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Correo Institucional";
            // 
            // btn_back
            // 
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(744, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(44, 39);
            this.btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_back.TabIndex = 7;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Recuperar_ContraseñaHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_idUsuario);
            this.Controls.Add(this.btn_recuperarContraseña);
            this.Controls.Add(this.txt_correoUsuario);
            this.Controls.Add(this.txt_IdUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recuperar_ContraseñaHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar_ContraseñaHome";
            this.Load += new System.EventHandler(this.Recuperar_ContraseñaHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IdUsuario;
        private System.Windows.Forms.TextBox txt_correoUsuario;
        private System.Windows.Forms.Button btn_recuperarContraseña;
        private System.Windows.Forms.Label lbl_idUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_back;
    }
}