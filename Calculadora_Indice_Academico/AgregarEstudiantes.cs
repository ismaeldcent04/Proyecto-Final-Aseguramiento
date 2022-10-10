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
    public partial class AgregarEstudiantes : UserControl
    {
        Aseguramiento_bdEntities db  = new Aseguramiento_bdEntities();
        public AgregarEstudiantes()
        {
            InitializeComponent();
            pnlDatosGenerales.Hide();
        }
        //CDatos datos = new CDatos();
        //estudiante estudiante = new estudiante();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            estudiante estudiante = new estudiante
            {
                estudiante_nombres = txt_nombre.Text,
                estudiante_apellidoP = txt_apellido.Text,
                estudiante_cedula = txt_cedula.Text,
                estudiante_contrasena = txt_contrasena.Text,
                estudiante_correo = txt_correo.Text,
                estudiante_telefono = txt_telefono.Text
            };
            db.estudiantes.Add(estudiante);
            db.SaveChanges();
            dgw_estudiantes.DataSource = db.estudiantes.ToList();
            dgw_estudiantes.Columns["calificacions"].Visible = false;
            dgw_estudiantes.Columns["estudianteHistoricoes"].Visible = false;
            dgw_estudiantes.Columns["trimestre"].Visible = false;


            txt_d_nombre.Text = txt_nombre.Text;
            txt_d_ID.Text = txt_ID.Text;
            txt_d_carrera.Text = txt_carrera.Text;
            txt_d_apellido.Text = txt_apellido.Text;
            txt_d_correo.Text = txt_correo.Text;
            txt_d_contrasena.Text = txt_contrasena.Text;
            txt_d_telefono.Text = txt_telefono.Text;
            pnlDatosGenerales.Show();
        }

        private void AgregarEstudiantes_Load(object sender, EventArgs e)
        {
            dgw_estudiantes.DataSource = db.estudiantes.ToList();
            dgw_estudiantes.Columns["estudiante_id"].HeaderText = "ID";
            dgw_estudiantes.Columns["calificacions"].Visible = false;
            dgw_estudiantes.Columns["estudianteHistoricoes"].Visible = false;
            dgw_estudiantes.Columns["trimestre"].Visible = false;
           

        }
    }
}
