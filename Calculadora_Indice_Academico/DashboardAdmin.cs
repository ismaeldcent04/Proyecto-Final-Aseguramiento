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
    public partial class DashboardAdmin : UserControl
    {
        AseguramientoDbEntities db = new AseguramientoDbEntities();
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            dgv_estudiantes.DataSource = db.show_students();
            dgv_docentes.DataSource = db.show_docente();
        }
    }
}
