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
                               where e.estudiante_id == 100000
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

            var z = (from es in Db.estudiantes
                               from ad in Db.administradors
                               join u in Db.user_login on es.estudiante_id equals u.user_id
                               join v in Db.user_login on ad.administrador_id equals v.user_id
                               where es.estudiante_id == 123 && ad.administrador_id == 123
                               select new
                               {
                                   ID = es.estudiante_id,
                                   Clave = u.user_password,
                                   type = u.acc_type,
                                   IDad = v.user_id,
                                   Clavead = v.user_password,
                                   typead = v.acc_type
                               }).Take(100).ToList();

            dataAsignatura.DataSource = z;

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
       }
    }
}
