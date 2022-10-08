using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculadora_Indice_Academico
{
    public partial class DashboardEstudiante : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
        );
        public DashboardEstudiante()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            historialUc.Hide();
            dashboardEstudianteUc.Show();
            dashboardEstudianteUc.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            historialUc.Hide();
            btnDashboard.BackColor = Color.FromArgb(221, 113, 113);
            btnDashboard.ForeColor = Color.White;
            btnHistorial.BackColor = Color.FromArgb(245, 166, 166);
            btnHistorial.ForeColor = Color.Black;
            dashboardEstudianteUc.Show();
            dashboardEstudianteUc.BringToFront();

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            dashboardEstudianteUc.Hide();
            btnDashboard.BackColor = Color.FromArgb(245, 166, 166);
            btnDashboard.ForeColor = Color.Black;
            btnHistorial.BackColor = Color.FromArgb(221, 113, 113);
            btnHistorial.ForeColor = Color.White;
            historialUc.Show();
            historialUc.BringToFront();
        }
    }
}
