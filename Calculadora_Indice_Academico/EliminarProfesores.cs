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
    public partial class EliminarProfesores : UserControl
    {
        Aseguramiento_dbEntities db = new Aseguramiento_dbEntities();
        public EliminarProfesores()
        {
            InitializeComponent();
            btn_actualizar.Visible = false;
            txt_id.Enabled = false;
            txt_AreaAcademica.Enabled = false;
            txt_apellidoP.Enabled = false;
            txt_ApellidoS.Enabled = false;
            txt_cedula.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_correo.Enabled = false;
            txt_telefono.Enabled = false;
            
        }

        private void EliminarProfesores_Load(object sender, EventArgs e)
        {

        }

        private void pnlDatosGenerales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            btn_actualizar.Visible = true;
            txt_apellidoP.Enabled = true;
            txt_ApellidoS.Enabled = true;
            txt_cedula.Enabled = true;
            txt_Nombre.Enabled = true;
            txt_correo.Enabled = true;
            txt_telefono.Enabled = true;

        }

        private void btn_buscarEstudiante_Click(object sender, EventArgs e)
        {
            dgv_docentes.DataSource= db.search_docen(txt_buscardocente.Text);
            var id = dgv_docentes.Rows[0].Cells[0].Value.ToString();
            var cedula = dgv_docentes.Rows[0].Cells[1].Value.ToString();
            var Nombre = dgv_docentes.Rows[0].Cells[2].Value.ToString();
            var apellidoP = dgv_docentes.Rows[0].Cells[3].Value.ToString();
            var apellidoS = dgv_docentes.Rows[0].Cells[4].Value.ToString();
            var telefono = dgv_docentes.Rows[0].Cells[5].Value.ToString();
            var correo = dgv_docentes.Rows[0].Cells[6].Value.ToString();
            var Area = dgv_docentes.Rows[0].Cells[7].Value.ToString();

            txt_id.Text = id;
            txt_cedula.Text = cedula;
            txt_Nombre.Text = Nombre;
            txt_apellidoP.Text = apellidoP;
            txt_ApellidoS.Text = apellidoS;
            txt_telefono.Text = telefono;
            txt_correo.Text = correo;
            txt_AreaAcademica.Text = Area;


        }

        private void txt_buscarEstudiante_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            db.upt_docente(txt_id.Text,txt_cedula.Text,txt_Nombre.Text,txt_apellidoP.Text,txt_ApellidoS.Text,txt_telefono.Text,txt_correo.Text);
        }
    }
}
