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
        Aseguramiento_dbEntities Db = new Aseguramiento_dbEntities();
        public DashboardEstudiante()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            customizeDesign();
            historialUc.Hide();
            medioTerminoUc.Hide();
            finalesUc.Hide();
            seleccionUc.Hide();
            dashboardEstudianteUc.Show();
            dashboardEstudianteUc.BringToFront();

            var fullEntries = (from e in Db.estudiantes
                               join eh in Db.estudiante_historico on e.estudiante_id equals eh.estudiante_id
                               join c in Db.carreras on eh.carrera_id equals c.carrera_id
                               where e.estudiante_id == 100000
                               select new
                               {
                                   Nombre = e.estudiante_nombres,
                                   ApellidoP = e.estudiante_apellidoP,
                                   ApellidoM = e.estudiante_apellidoM
                               }).Take(1).ToList();

            foreach(var a in fullEntries)
            {
                lblUser.Text = $"{a.Nombre} {a.ApellidoP} {a.ApellidoM}";
            }
        }

        private void customizeDesign()
        {
            subMenuRpts.Visible = false;
        }

        private void hideSubMenu()
        {
            if (subMenuRpts.Visible == true)
                subMenuRpts.Visible = false;
        }

        private void showSubMenu()
        {
            if(subMenuRpts.Visible == false)
            {
                hideSubMenu();
                subMenuRpts.Visible = true;
            }
            else
            {
                subMenuRpts.Visible = false;
            }
        }

        private void btnSeleccionado(Button button)
        {
            button.BackColor = Color.FromArgb(221, 133, 133);
            button.ForeColor = Color.White;
        }

        private void btnNoSeleccionado(Button button)
        {
            button.BackColor = Color.FromArgb(245, 166, 166);
            button.ForeColor = Color.Black;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            historialUc.Hide();
            medioTerminoUc.Hide();
            finalesUc.Hide();
            seleccionUc.Hide();
            dashboardEstudianteUc.Show();
            dashboardEstudianteUc.BringToFront();
            btnSeleccionado(btnDashboard);
            btnNoSeleccionado(btnHistorial);
            btnNoSeleccionado(btnMedio);
            btnNoSeleccionado(btnFinales);
            btnNoSeleccionado(btnSeleccion);
            hideSubMenu();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            dashboardEstudianteUc.Hide();
            medioTerminoUc.Hide();
            finalesUc.Hide();
            seleccionUc.Hide();
            historialUc.Show();
            historialUc.BringToFront();
            btnSeleccionado(btnHistorial);
            btnNoSeleccionado(btnDashboard);
            btnNoSeleccionado(btnMedio);
            btnNoSeleccionado(btnFinales);
            btnNoSeleccionado(btnSeleccion);
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {
            dashboardEstudianteUc.Hide();
            historialUc.Hide();
            finalesUc.Hide();
            seleccionUc.Hide();
            medioTerminoUc.Show();
            medioTerminoUc.BringToFront();
            btnSeleccionado(btnMedio);
            btnNoSeleccionado(btnDashboard);
            btnNoSeleccionado(btnHistorial);
            btnNoSeleccionado(btnFinales);
            btnNoSeleccionado(btnSeleccion);
        }

        private void btnFinales_Click(object sender, EventArgs e)
        {
            dashboardEstudianteUc.Hide();
            historialUc.Hide();
            medioTerminoUc.Hide();
            seleccionUc.Hide();
            finalesUc.Show();
            finalesUc.BringToFront();
            btnSeleccionado(btnFinales);
            btnNoSeleccionado(btnDashboard);
            btnNoSeleccionado(btnHistorial);
            btnNoSeleccionado(btnMedio);
            btnNoSeleccionado(btnSeleccion);
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            dashboardEstudianteUc.Hide();
            historialUc.Hide();
            medioTerminoUc.Hide();
            finalesUc.Hide();
            seleccionUc.Show();
            seleccionUc.BringToFront();
            btnSeleccionado(btnSeleccion);
            btnNoSeleccionado(btnFinales);
            btnNoSeleccionado(btnDashboard);
            btnNoSeleccionado(btnHistorial);
            btnNoSeleccionado(btnMedio);
            hideSubMenu();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recuperar_ContraseñaHome cambiarClave = new Recuperar_ContraseñaHome();
            cambiarClave.Show();
        }
    }
}
