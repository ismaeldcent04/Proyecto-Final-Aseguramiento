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
    public partial class AgregarEstudiantes : UserControl
    {
        public AgregarEstudiantes()
        {
            InitializeComponent();
            pnlDatosGenerales.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            pnlDatosGenerales.Show();
        }

        private void AgregarEstudiantes_Load(object sender, EventArgs e)
        {

        }
    }
}
