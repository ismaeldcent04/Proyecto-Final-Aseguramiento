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
    public partial class Menu_Admnistrador : Form
    {
        public Menu_Admnistrador()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            StudentsPanel.Visible = false;
            Profesores_Panel.Visible = false;
        }

        private void hideSubmenu()
        {
            if (StudentsPanel.Visible == true)
            {
                StudentsPanel.Visible = false;
            }
            if(Profesores_Panel.Visible == true)
            {
                Profesores_Panel.Visible = false;
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
            showSubmenu(StudentsPanel);
        }

        private void btn_profesores_Click(object sender, EventArgs e)
        {
           showSubmenu(Profesores_Panel);
        }

        private void btn_agregarEstudiantes_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btn_eliminarEstudiantes_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btn_agregarProfesores_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btn_eliminarProfesores_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
