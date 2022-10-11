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
        public EliminarProfesores()
        {
            InitializeComponent();
            btn_actualizar.Visible = false; 
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
            txt_id.Enabled = false;

        }
    }
}
