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
        Aseguramiento_dbEntities1 db = new Aseguramiento_dbEntities1();
        public EliminarProfesores()
        {
            InitializeComponent();
        }

        private void EliminarProfesores_Load(object sender, EventArgs e)
        {
            btn_actualizar.Visible = false;
            txt_id.Enabled = false;
            txt_AreaAcademica.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_apellidoP.Enabled = false;
            txt_apellidoS.Enabled = false;
            txt_cedula.Enabled = false;
            txt_telefono.Enabled = false;
            txt_correo.Enabled = false;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            btn_actualizar.Visible = true;
            txt_Nombre.Enabled = true;
            txt_apellidoP.Enabled = true;
            txt_apellidoS.Enabled = true;
            txt_cedula.Enabled = true;
            txt_telefono.Enabled = true;
            txt_correo.Enabled = true;
        }

        private void btn_buscarEstudiante_Click(object sender, EventArgs e)
        {
            dgv_docentes.DataSource = db.search_docen(txt_buscarDocente.Text);
            var id = dgv_docentes.Rows[0].Cells[0].Value.ToString();
            var cedula = dgv_docentes.Rows[0].Cells[1].Value.ToString();
            var nombre = dgv_docentes.Rows[0].Cells[2].Value.ToString();
            var apellidoP = dgv_docentes.Rows[0].Cells[3].Value.ToString();
            var apellidoS = dgv_docentes.Rows[0].Cells[4].Value.ToString();
            var telefono = dgv_docentes.Rows[0].Cells[5].Value.ToString();
            var correo = dgv_docentes.Rows[0].Cells[6].Value.ToString();
            var area = dgv_docentes.Rows[0].Cells[7].Value.ToString();

            txt_id.Text = id;
            txt_cedula.Text = cedula;
            txt_Nombre.Text = nombre;
            txt_apellidoP.Text = apellidoP;
            txt_apellidoS.Text = apellidoS;
            txt_telefono.Text = telefono;
            txt_correo.Text = correo;
            txt_AreaAcademica.Text = area;

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            db.upt_docente(txt_id.Text,txt_cedula.Text,txt_Nombre.Text, txt_apellidoP.Text,txt_apellidoS.Text,txt_telefono.Text,txt_correo.Text);
            dgv_docentes.DataSource = db.search_docen(txt_buscarDocente.Text);
        }
    }
}
