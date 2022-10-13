using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Common.Cache;

namespace Calculadora_Indice_Academico
{
    public partial class DashboardEstudianteUc : UserControl
    {
        AseguramientoDbEntities Db = new AseguramientoDbEntities();

        public DashboardEstudianteUc()
        {
            InitializeComponent();
            var fullEntries = (from e in Db.estudiantes
                               join eh in Db.estudiante_historico on e.estudiante_id equals eh.estudiante_id
                               join c in Db.carreras on eh.carrera_id equals c.carrera_id
                               where e.estudiante_id == UserLoginCache.idUser
                               select new
                               {
                                   ID = e.estudiante_id, 
                                   Correo = e.estudiante_correo,
                                   ApellidoP = e.estudiante_apellidoP,
                                   ApellidoM = e.estudiante_apellidoM,
                                   Telefono = e.estudiante_telefono, 
                                   Carrera = c.carrera_nombre, 
                                   TrimestreMax = c.trimestres_max,
                                   TrimestreCursado = eh.trimestres_cursados
                               }).Take(1).ToList();

            foreach (var a in fullEntries)
            {
                lblID.Text = a.ID.ToString();
                lblCorreo.Text = a.Correo;
                lblTel.Text = a.Telefono;
                lblPrograma.Text = a.Carrera;
                lblTriCur.Text = a.TrimestreCursado.ToString();
                proTrimestres.Maximum = a.TrimestreMax;
                proTrimestres.Value = a.TrimestreCursado;
                proTrimestres.Text = a.TrimestreCursado.ToString();
                lblTriCur2.Text = "Trimestres cursado de " + a.TrimestreMax.ToString();
            }
            try
            {
                dataAsignatura.DataSource = Db.show_asig(UserLoginCache.idUser.ToString());
                dataAsignatura.Columns[0].HeaderText = "Sección";
                dataAsignatura.Columns[0].Width = 65;
                dataAsignatura.Columns[1].HeaderText = "Codigo";
                dataAsignatura.Columns[1].Width = 65;
                dataAsignatura.Columns[2].HeaderText = "Asignatura";
                dataAsignatura.Columns[2].Width = 295;
                dataAsignatura.Columns[3].HeaderText = "Cr.";
                dataAsignatura.Columns[3].Width = 50;
                dataAsignatura.Columns[4].HeaderText = "Aula";
                dataAsignatura.Columns[4].Width = 65;
                dataAsignatura.Columns[5].HeaderText = "Lu";
                dataAsignatura.Columns[5].Width = 50;
                dataAsignatura.Columns[6].HeaderText = "Ma";
                dataAsignatura.Columns[6].Width = 50;
                dataAsignatura.Columns[7].HeaderText = "Mi";
                dataAsignatura.Columns[7].Width = 50;
                dataAsignatura.Columns[8].HeaderText = "Ju";
                dataAsignatura.Columns[8].Width = 50;
                dataAsignatura.Columns[9].HeaderText = "Vi";
                dataAsignatura.Columns[9].Width = 50;
                dataAsignatura.Columns[10].HeaderText = "Sab";
                dataAsignatura.Columns[10].Width = 50;
                dataAsignatura.Columns[11].HeaderText = "Profesor";
                dataAsignatura.Columns[11].Width = 120;
            }
            catch
            {
                dataAsignatura.DataSource = null;
            }
        }
    }
}
