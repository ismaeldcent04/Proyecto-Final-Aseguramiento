using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Indice_Academico
{
    public partial class AgregarEstudiantes : UserControl
    {
        AseguramientoDbEntities5 db  = new AseguramientoDbEntities5();
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

        public void loaddata()
        {
            
            dgw_estudiantes.DataSource = db.show_students();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {


            db.insert_student(txt_cedula.Text, txt_nombre.Text, txt_apellidoP.Text, txt_apellidoS.Text, txt_telefono.Text, txt_correo.Text,int.Parse(cmb_carrera.SelectedValue.ToString()), txt_contrasena.Text);
            loaddata();



            txt_d_nombre.Text = txt_nombre.Text;
            txt_d_carrera.Text = cmb_carrera.Text;
            txt_d_apellido.Text = txt_apellidoP.Text;
            txt_d_correo.Text = txt_correo.Text;
            txt_d_contrasena.Text = txt_contrasena.Text;
            txt_d_telefono.Text = txt_telefono.Text;
           
            pnlDatosGenerales.Show();
        }

        private void AgregarEstudiantes_Load(object sender, EventArgs e)
        {
            cmb_carrera.DataSource = db.carreras.ToList();
            cmb_carrera.DisplayMember = "carrera_nombre";
            cmb_carrera.ValueMember = "carrera_id";
            loaddata();
            //var consulta =
            //dgw_estudiantes.DataSource = db.estudiantes.ToList();
            //dgw_estudiantes.Columns["estudiante_id"].HeaderText = "ID";
            //dgw_estudiantes.Columns["calificacions"].Visible = false;
            //dgw_estudiantes.Columns["estudianteHistoricoes"].Visible = false;
            //dgw_estudiantes.Columns["trimestre"].Visible = false;
        }
    }
}
