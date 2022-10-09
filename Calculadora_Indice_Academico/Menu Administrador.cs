using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Indice_Academico
{
    public partial class Menu_Administrador : Form
    {
        public Menu_Administrador()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelStudents.Visible = false;
            PanelTeachers.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panelStudents.Visible == true)
            {
                panelStudents.Visible = false;
            }
            if (PanelTeachers.Visible == true)
            {
                PanelTeachers.Visible = false;
            }
        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void btn_estudiantes_Click(object sender, EventArgs e)
        {
            showSubmenu(panelStudents);
        }

        private void btn_Profesores_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelTeachers);
        }

        private void btn_AgregarEstudiantes_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            agregarEstudiantes1.Show();
            agregarEstudiantes1.BringToFront();
           
        }

        private void btn_EliminarEstudiantes_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            eliminarEstudiantes1.Show();
            eliminarEstudiantes1.BringToFront();
        }

        private void btn_AgregarProfesores_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            agregarProfesores1.Show();
            agregarProfesores1.BringToFront();
        }

        private void btn_EliminarProfesores_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            eliminarProfesores1.Show();
            eliminarProfesores1.BringToFront();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboardAdmin1.Show();
            dashboardAdmin1.BringToFront();
        }
    }
}
