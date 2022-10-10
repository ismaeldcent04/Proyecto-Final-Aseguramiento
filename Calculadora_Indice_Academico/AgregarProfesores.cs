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
    public partial class AgregarProfesores : UserControl
    {
        public AgregarProfesores()
        {
            InitializeComponent();
            pnlDatosGenerales.Hide();
        }

        private void pnlDatosGenerales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            pnlDatosGenerales.Show();
        }

        private void AgregarProfesores_Load(object sender, EventArgs e)
        {

        }
    }
}
