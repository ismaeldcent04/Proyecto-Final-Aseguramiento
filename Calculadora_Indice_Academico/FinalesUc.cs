using Common.Cache;
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
    public partial class FinalesUc : UserControl
    {
        AseguramientoDbEntities5 Db = new AseguramientoDbEntities5();
        public FinalesUc()
        {
            InitializeComponent();

            var fullEntries = (from e in Db.estudiantes
                               join eh in Db.estudiante_historico on e.estudiante_id equals eh.estudiante_id
                               join c in Db.carreras on eh.carrera_id equals c.carrera_id
                               where e.estudiante_id == UserLoginCache.idUser
                               select new
                               {
                                   ID = e.estudiante_id,
                                   Carrera = c.carrera_nombre
                               }).Take(1).ToList();

            foreach (var a in fullEntries)
            {
                lblID.Text = a.ID.ToString();
                lblPrograma.Text = a.Carrera;
            }
        }

        private void FinalesUc_Load(object sender, EventArgs e)
        {

        }
    }
}
