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
using Common.Cache;

namespace Calculadora_Indice_Academico
{
    public partial class Login : Form
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
        Aseguramiento_dbEntities1 Db = new Aseguramiento_dbEntities1();
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_nombreUsuario_TextChanged(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_olvidasteContraseña_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recuperar_ContraseñaHome rcHome = new Recuperar_ContraseñaHome();
            rcHome.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txt_nombreUsuario.Text == "" || txt_contraseñaUsuario.Text == "")
            {
                MessageBox.Show("No se permiten campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ID = int.Parse(txt_nombreUsuario.Text);
                string contrasena = (txt_contraseñaUsuario.Text);

                var fullEntries = (from es in Db.estudiantes
                                   from ad in Db.administradors
                                   join u in Db.user_login on es.estudiante_id equals u.user_id
                                   join v in Db.user_login on ad.administrador_id equals v.user_id
                                   where es.estudiante_id == ID || ad.administrador_id == ID
                                   select new
                                   {
                                       ID = es.estudiante_id,
                                       Clave = u.user_password,
                                       type = u.acc_type,
                                       IDad = v.user_id,
                                       Clavead = v.user_password,
                                       typead = v.acc_type
                                   }).Take(1).ToList();
                if (fullEntries.Count > 0)
                {
                    foreach (var a in fullEntries)
                    {
                        if (a.ID == ID && a.Clave == contrasena && a.type == 3)
                        {
                            userloginCache.id_user = a.ID;
                            DashboardEstudiante dashboardEstudiante = new DashboardEstudiante();
                            dashboardEstudiante.Show();
                            this.Hide();
                        }
                        else if (a.ID == ID && a.Clave == contrasena && a.type == 2)
                        {

                        }
                        else if (a.IDad == ID && a.Clavead == contrasena && a.typead == 1)
                        {
                            userloginCache.id_user = a.IDad;
                            Menu_Administrador menu_Administrador = new Menu_Administrador();
                            menu_Administrador.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Credenciales incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No existe la cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         

        }
    }
}
