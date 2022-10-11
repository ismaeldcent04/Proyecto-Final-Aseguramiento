namespace Calculadora_Indice_Academico
{
    partial class DashboardEstudiante
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.subMenuRpts = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnFinales = new System.Windows.Forms.Button();
            this.btnMedio = new System.Windows.Forms.Button();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlCreditos = new System.Windows.Forms.Panel();
            this.proCreditos = new CircularProgressBar.CircularProgressBar();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlTrimestres = new System.Windows.Forms.Panel();
            this.proTrimestres = new CircularProgressBar.CircularProgressBar();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlIndice = new System.Windows.Forms.Panel();
            this.proIndice = new CircularProgressBar.CircularProgressBar();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlAprobadas = new System.Windows.Forms.Panel();
            this.proAprobadas = new CircularProgressBar.CircularProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.historialUc = new Calculadora_Indice_Academico.HistorialUc();
            this.medioTerminoUc = new Calculadora_Indice_Academico.MedioTerminoUc();
            this.finalesUc = new Calculadora_Indice_Academico.FinalesUc();
            this.dashboardEstudianteUc = new Calculadora_Indice_Academico.DashboardEstudianteUc();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.seleccionUc = new Calculadora_Indice_Academico.SeleccionUc();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.subMenuRpts.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pnlMenu.Controls.Add(this.btnSeleccion);
            this.pnlMenu.Controls.Add(this.subMenuRpts);
            this.pnlMenu.Controls.Add(this.btnReportes);
            this.pnlMenu.Controls.Add(this.pnlUsuario);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 850);
            this.pnlMenu.TabIndex = 14;
            // 
            // subMenuRpts
            // 
            this.subMenuRpts.Controls.Add(this.btnHistorial);
            this.subMenuRpts.Controls.Add(this.btnFinales);
            this.subMenuRpts.Controls.Add(this.btnMedio);
            this.subMenuRpts.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuRpts.Location = new System.Drawing.Point(0, 120);
            this.subMenuRpts.Name = "subMenuRpts";
            this.subMenuRpts.Size = new System.Drawing.Size(250, 180);
            this.subMenuRpts.TabIndex = 15;
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(0, 120);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btnHistorial.Size = new System.Drawing.Size(250, 60);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnFinales
            // 
            this.btnFinales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnFinales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinales.FlatAppearance.BorderSize = 0;
            this.btnFinales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinales.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFinales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinales.Location = new System.Drawing.Point(0, 60);
            this.btnFinales.Name = "btnFinales";
            this.btnFinales.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btnFinales.Size = new System.Drawing.Size(250, 60);
            this.btnFinales.TabIndex = 2;
            this.btnFinales.Text = "Calificaciones Finales";
            this.btnFinales.UseVisualStyleBackColor = false;
            this.btnFinales.Click += new System.EventHandler(this.btnFinales_Click);
            // 
            // btnMedio
            // 
            this.btnMedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnMedio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedio.FlatAppearance.BorderSize = 0;
            this.btnMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedio.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMedio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedio.Location = new System.Drawing.Point(0, 0);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btnMedio.Size = new System.Drawing.Size(250, 60);
            this.btnMedio.TabIndex = 2;
            this.btnMedio.Text = "Medio Término";
            this.btnMedio.UseVisualStyleBackColor = false;
            this.btnMedio.Click += new System.EventHandler(this.btnMedio_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.btnConfig);
            this.pnlUsuario.Controls.Add(this.lblUser);
            this.pnlUsuario.Controls.Add(this.pictureBox1);
            this.pnlUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUsuario.Location = new System.Drawing.Point(0, 690);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(250, 100);
            this.pnlUsuario.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser.Location = new System.Drawing.Point(80, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(115, 44);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User Name";
            // 
            // pnlCreditos
            // 
            this.pnlCreditos.Location = new System.Drawing.Point(0, 0);
            this.pnlCreditos.Name = "pnlCreditos";
            this.pnlCreditos.Size = new System.Drawing.Size(200, 100);
            this.pnlCreditos.TabIndex = 0;
            // 
            // proCreditos
            // 
            this.proCreditos.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.proCreditos.AnimationSpeed = 500;
            this.proCreditos.BackColor = System.Drawing.Color.Transparent;
            this.proCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.proCreditos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.proCreditos.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.proCreditos.InnerMargin = 2;
            this.proCreditos.InnerWidth = -1;
            this.proCreditos.Location = new System.Drawing.Point(0, 0);
            this.proCreditos.MarqueeAnimationSpeed = 2000;
            this.proCreditos.Name = "proCreditos";
            this.proCreditos.OuterColor = System.Drawing.Color.Gray;
            this.proCreditos.OuterMargin = -25;
            this.proCreditos.OuterWidth = 26;
            this.proCreditos.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.proCreditos.ProgressWidth = 25;
            this.proCreditos.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.proCreditos.Size = new System.Drawing.Size(320, 320);
            this.proCreditos.StartAngle = 270;
            this.proCreditos.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.proCreditos.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.proCreditos.SubscriptText = ".23";
            this.proCreditos.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.proCreditos.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.proCreditos.SuperscriptText = "°C";
            this.proCreditos.TabIndex = 0;
            this.proCreditos.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.proCreditos.Value = 68;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 0;
            // 
            // pnlTrimestres
            // 
            this.pnlTrimestres.Location = new System.Drawing.Point(0, 0);
            this.pnlTrimestres.Name = "pnlTrimestres";
            this.pnlTrimestres.Size = new System.Drawing.Size(200, 100);
            this.pnlTrimestres.TabIndex = 0;
            // 
            // proTrimestres
            // 
            this.proTrimestres.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.proTrimestres.AnimationSpeed = 500;
            this.proTrimestres.BackColor = System.Drawing.Color.Transparent;
            this.proTrimestres.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.proTrimestres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.proTrimestres.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.proTrimestres.InnerMargin = 2;
            this.proTrimestres.InnerWidth = -1;
            this.proTrimestres.Location = new System.Drawing.Point(0, 0);
            this.proTrimestres.MarqueeAnimationSpeed = 2000;
            this.proTrimestres.Name = "proTrimestres";
            this.proTrimestres.OuterColor = System.Drawing.Color.Gray;
            this.proTrimestres.OuterMargin = -25;
            this.proTrimestres.OuterWidth = 26;
            this.proTrimestres.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.proTrimestres.ProgressWidth = 25;
            this.proTrimestres.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.proTrimestres.Size = new System.Drawing.Size(320, 320);
            this.proTrimestres.StartAngle = 270;
            this.proTrimestres.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.proTrimestres.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.proTrimestres.SubscriptText = ".23";
            this.proTrimestres.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.proTrimestres.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.proTrimestres.SuperscriptText = "°C";
            this.proTrimestres.TabIndex = 0;
            this.proTrimestres.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.proTrimestres.Value = 68;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 0;
            // 
            // pnlIndice
            // 
            this.pnlIndice.Location = new System.Drawing.Point(0, 0);
            this.pnlIndice.Name = "pnlIndice";
            this.pnlIndice.Size = new System.Drawing.Size(200, 100);
            this.pnlIndice.TabIndex = 0;
            // 
            // proIndice
            // 
            this.proIndice.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.proIndice.AnimationSpeed = 500;
            this.proIndice.BackColor = System.Drawing.Color.Transparent;
            this.proIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.proIndice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.proIndice.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.proIndice.InnerMargin = 2;
            this.proIndice.InnerWidth = -1;
            this.proIndice.Location = new System.Drawing.Point(0, 0);
            this.proIndice.MarqueeAnimationSpeed = 2000;
            this.proIndice.Name = "proIndice";
            this.proIndice.OuterColor = System.Drawing.Color.Gray;
            this.proIndice.OuterMargin = -25;
            this.proIndice.OuterWidth = 26;
            this.proIndice.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.proIndice.ProgressWidth = 25;
            this.proIndice.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.proIndice.Size = new System.Drawing.Size(320, 320);
            this.proIndice.StartAngle = 270;
            this.proIndice.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.proIndice.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.proIndice.SubscriptText = ".23";
            this.proIndice.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.proIndice.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.proIndice.SuperscriptText = "°C";
            this.proIndice.TabIndex = 0;
            this.proIndice.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.proIndice.Value = 68;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 0;
            // 
            // pnlAprobadas
            // 
            this.pnlAprobadas.Location = new System.Drawing.Point(0, 0);
            this.pnlAprobadas.Name = "pnlAprobadas";
            this.pnlAprobadas.Size = new System.Drawing.Size(200, 100);
            this.pnlAprobadas.TabIndex = 0;
            // 
            // proAprobadas
            // 
            this.proAprobadas.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.proAprobadas.AnimationSpeed = 500;
            this.proAprobadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.proAprobadas.Font = new System.Drawing.Font("Arial", 45F, System.Drawing.FontStyle.Bold);
            this.proAprobadas.ForeColor = System.Drawing.Color.White;
            this.proAprobadas.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.proAprobadas.InnerMargin = 0;
            this.proAprobadas.InnerWidth = -1;
            this.proAprobadas.Location = new System.Drawing.Point(35, 15);
            this.proAprobadas.MarqueeAnimationSpeed = 2000;
            this.proAprobadas.Name = "proAprobadas";
            this.proAprobadas.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.proAprobadas.OuterMargin = -25;
            this.proAprobadas.OuterWidth = 26;
            this.proAprobadas.ProgressColor = System.Drawing.Color.White;
            this.proAprobadas.ProgressWidth = 7;
            this.proAprobadas.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.proAprobadas.Size = new System.Drawing.Size(128, 128);
            this.proAprobadas.StartAngle = 270;
            this.proAprobadas.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.proAprobadas.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.proAprobadas.SubscriptText = "";
            this.proAprobadas.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.proAprobadas.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.proAprobadas.SuperscriptText = "";
            this.proAprobadas.TabIndex = 4;
            this.proAprobadas.Text = "10";
            this.proAprobadas.TextMargin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.proAprobadas.Value = 13;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 0;
            // 
            // historialUc
            // 
            this.historialUc.AutoScroll = true;
            this.historialUc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historialUc.Location = new System.Drawing.Point(0, 0);
            this.historialUc.Name = "historialUc";
            this.historialUc.Size = new System.Drawing.Size(1350, 850);
            this.historialUc.TabIndex = 22;
            // 
            // medioTerminoUc
            // 
            this.medioTerminoUc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medioTerminoUc.Location = new System.Drawing.Point(0, 0);
            this.medioTerminoUc.Name = "medioTerminoUc";
            this.medioTerminoUc.Size = new System.Drawing.Size(1350, 850);
            this.medioTerminoUc.TabIndex = 17;
            // 
            // finalesUc
            // 
            this.finalesUc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalesUc.Location = new System.Drawing.Point(0, 0);
            this.finalesUc.Name = "finalesUc";
            this.finalesUc.Size = new System.Drawing.Size(1350, 850);
            this.finalesUc.TabIndex = 18;
            // 
            // dashboardEstudianteUc
            // 
            this.dashboardEstudianteUc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardEstudianteUc.Location = new System.Drawing.Point(250, 0);
            this.dashboardEstudianteUc.Name = "dashboardEstudianteUc";
            this.dashboardEstudianteUc.Size = new System.Drawing.Size(1100, 850);
            this.dashboardEstudianteUc.TabIndex = 21;
           
            // 
            // seleccionUc
            // 
            this.seleccionUc.AutoScroll = true;
            this.seleccionUc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seleccionUc.Location = new System.Drawing.Point(0, 0);
            this.seleccionUc.Name = "seleccionUc";
            this.seleccionUc.Size = new System.Drawing.Size(1350, 850);
            this.seleccionUc.TabIndex = 23;
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnSeleccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeleccion.FlatAppearance.BorderSize = 0;
            this.btnSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccion.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSeleccion.Image = global::Calculadora_Indice_Academico.Properties.Resources.seleccione_32x32;
            this.btnSeleccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccion.Location = new System.Drawing.Point(0, 300);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btnSeleccion.Size = new System.Drawing.Size(250, 60);
            this.btnSeleccion.TabIndex = 16;
            this.btnSeleccion.Text = "Seleccion";
            this.btnSeleccion.UseVisualStyleBackColor = false;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReportes.Image = global::Calculadora_Indice_Academico.Properties.Resources.reportes;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 60);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btnReportes.Size = new System.Drawing.Size(250, 60);
            this.btnReportes.TabIndex = 1;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfig.Image = global::Calculadora_Indice_Academico.Properties.Resources.settings_32x32;
            this.btnConfig.Location = new System.Drawing.Point(195, 25);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btnConfig.Size = new System.Drawing.Size(45, 44);
            this.btnConfig.TabIndex = 17;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
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
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Image = global::Calculadora_Indice_Academico.Properties.Resources.log_out_32x32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 790);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.btnLogout.Size = new System.Drawing.Size(250, 60);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
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
            this.btnDashboard.Size = new System.Drawing.Size(250, 60);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // DashboardEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 850);
            this.Controls.Add(this.dashboardEstudianteUc);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.historialUc);
            this.Controls.Add(this.medioTerminoUc);
            this.Controls.Add(this.finalesUc);
            this.Controls.Add(this.seleccionUc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardEstudiante";
            this.pnlMenu.ResumeLayout(false);
            this.subMenuRpts.ResumeLayout(false);
            this.pnlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMedio;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Panel pnlCreditos;
        private CircularProgressBar.CircularProgressBar proCreditos;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnlTrimestres;
        private CircularProgressBar.CircularProgressBar proTrimestres;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel pnlIndice;
        private CircularProgressBar.CircularProgressBar proIndice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlAprobadas;
        private CircularProgressBar.CircularProgressBar proAprobadas;
        private System.Windows.Forms.Label label15;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel subMenuRpts;
        private System.Windows.Forms.Button btnFinales;
        private MedioTerminoUc medioTerminoUc;
        private FinalesUc finalesUc;
        private System.Windows.Forms.Button btnSeleccion;
        private DashboardEstudianteUc dashboardEstudianteUc;
        private HistorialUc historialUc;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private SeleccionUc seleccionUc;
        private System.Windows.Forms.Button btnConfig;
    }
}