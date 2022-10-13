﻿using System;
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
    public partial class btn_eliminar : UserControl
    {
        AseguramientoDbEntities db = new AseguramientoDbEntities();
        public btn_eliminar()
        {
            InitializeComponent();
            btn_actualizar.Visible = false;
            txt_id.Enabled = false;
            txt_Nombre.Enabled = false;
            txt_Trimestres.Enabled = false;
            txt_apellidoP.Enabled = false;
            txt_apellidoS.Enabled = false;
            txt_Carrera.Enabled = false;
            txt_telefono.Enabled = false;
            txt_correo.Enabled = false;

        }

        private void pnlDatosGenerales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_eliminar_Load(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            btn_actualizar.Visible = true;
            txt_Nombre.Enabled = true;
            txt_apellidoP.Enabled=true;
            txt_apellidoS.Enabled=true;
            txt_Carrera.Enabled=true;
            txt_telefono.Enabled = true;
            txt_correo.Enabled = true;
        }

        private void btn_buscarEstudiante_Click(object sender, EventArgs e)
        {
            dgw_Estudiantes.DataSource = db.search_estudiante(txt_buscarEstudiante.Text);
            var id = dgw_Estudiantes.Rows[0].Cells[0].Value.ToString();
            var carrera = dgw_Estudiantes.Rows[0].Cells[1].Value.ToString();
            var Trimestre = dgw_Estudiantes.Rows[0].Cells[2].Value.ToString();
            var Nombre = dgw_Estudiantes.Rows[0].Cells[3].Value.ToString();
            var apellidoP = dgw_Estudiantes.Rows[0].Cells[4].Value.ToString();
            var apellidoS = dgw_Estudiantes.Rows[0].Cells[5].Value.ToString();
            var telefono = dgw_Estudiantes.Rows[0].Cells[6].Value.ToString();
            var correo = dgw_Estudiantes.Rows[0].Cells[7].Value.ToString();
            var cedula = dgw_Estudiantes.Rows[0].Cells[8].Value.ToString();

            txt_id.Text = id;
            txt_Carrera.Text = carrera;
            txt_Trimestres.Text = Trimestre;
            txt_Nombre.Text = Nombre;
            txt_apellidoP.Text = apellidoP;
            txt_apellidoS.Text = apellidoS;
            txt_telefono.Text = telefono;
            txt_correo.Text = correo;
            txt_cedula.Text = cedula;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            db.upt_estudiante(txt_id.Text, txt_cedula.Text, txt_Nombre.Text, txt_apellidoP.Text, txt_apellidoS.Text, txt_telefono.Text, txt_correo.Text);
            dgw_Estudiantes.DataSource = db.search_estudiante(txt_buscarEstudiante.Text);
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Trimestres_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
