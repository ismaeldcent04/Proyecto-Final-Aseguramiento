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
    public partial class AgregarProfesores : UserControl
    {
        AseguramientoDbEntities db = new AseguramientoDbEntities();   
        public AgregarProfesores()
        {
            InitializeComponent();
            pnlDatosGenerales.Hide();
        }

        private void pnlDatosGenerales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            docente docente = new docente
            {
                docente_cedula = txt_cedula.Text,
                docente_nombres = txt_nombre.Text,
                docente_apellidoP = txt_Apellido.Text,
                //docente_contrasena = txt_Contrasena.Text,
                docente_telefono = txt_telefono.Text,
                docente_correo = txt_Correo.Text,
                area_id = 1
            };
            db.docentes.Add(docente);
            db.SaveChanges();
            dgw_profesores.DataSource = db.docentes.ToList();
            dgw_profesores.Columns["areas"].Visible = false;
            dgw_profesores.Columns["area"].Visible = false;
            dgw_profesores.Columns["carreras"].Visible = false;
            dgw_profesores.Columns["trimestre_materia"].Visible = false;


            txt_d_nombre.Text = txt_nombre.Text;
            txt_d_ID.Text = txt_ID.Text;
            txt_d_carrera.Text = txt_Area.Text;
            txt_d_apellido.Text = txt_Apellido.Text;
            txt_d_correo.Text = txt_Correo.Text;
            txt_d_contraseña.Text = txt_Contrasena.Text;
            txt_d_cedula.Text = txt_cedula.Text;
            txt_d_telefono.Text = txt_telefono.Text;
            pnlDatosGenerales.Show();
        }

        private void AgregarProfesores_Load(object sender, EventArgs e)
        {

        }
    }
}
