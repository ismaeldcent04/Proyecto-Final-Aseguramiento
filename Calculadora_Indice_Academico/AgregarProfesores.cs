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
        AseguramientoDbEntities5 db = new AseguramientoDbEntities5();   
        public AgregarProfesores()
        {
            InitializeComponent();
            pnlDatosGenerales.Hide();
        }

        private void pnlDatosGenerales_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadData()
        {
            dgw_profesores.DataSource = db.show_docente();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            db.insert_docente(txt_cedula.Text, txt_nombre.Text, txt_ApellidoP.Text, txt_ApellidoS.Text, txt_telefono.Text, txt_Correo.Text, int.Parse(cbx_Area.SelectedValue.ToString()),txt_Contrasena.Text);
            loadData();
            txt_d_nombre.Text = txt_nombre.Text;
            txt_d_carrera.Text = cbx_Area.Text;
            txt_d_apellido.Text = txt_ApellidoP.Text;
            txt_d_correo.Text = txt_Correo.Text;
            txt_d_contraseña.Text = txt_Contrasena.Text;
            txt_d_cedula.Text = txt_cedula.Text;
            txt_d_telefono.Text = txt_telefono.Text;
            pnlDatosGenerales.Show();
        }

        private void AgregarProfesores_Load(object sender, EventArgs e)
        {
            cbx_Area.DataSource = db.areas.ToList();
            cbx_Area.DisplayMember = "area_nombre";
            cbx_Area.ValueMember = "area_id";
            loadData();
        }
    }
}
