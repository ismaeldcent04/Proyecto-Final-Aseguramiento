using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Indice_Academico
{
    public partial class DashboardEstudianteUc : UserControl
    {
        aseguramiento_grupo1Entities1 Db = new aseguramiento_grupo1Entities1();
        public DashboardEstudianteUc()
        {
            InitializeComponent();
            lblID.Text = Db.estudiantes.Where(u => u.estudiante_id == 2).Select(u => u.estudiante_id).SingleOrDefault().ToString();
            lblCorreo.Text = Db.estudiantes.Where(u => u.estudiante_id == 2).Select(u => u.estudiante_correo).SingleOrDefault().ToString();
            lblTel.Text = Db.estudiantes.Where(u => u.estudiante_id == 2).Select(u => u.estudiante_correo).SingleOrDefault().ToString();
        }
    }
}
