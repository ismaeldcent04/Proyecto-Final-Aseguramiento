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
    public partial class SeleccionUc : UserControl
    {
        public SeleccionUc()
        {
            InitializeComponent();
            hideAll();
        }

        private void hideAll()
        {
            pnlCB.Visible = false;
            pnlSH.Visible = false;
            pnlSA.Visible = false;
            pnlIN.Visible = false;
            pnlNG.Visible = false;
        }

        private void hideMenu(Panel panel)
        {
            if(panel.Visible == true)
                panel.Visible = false;
        }

        private void showMenu(Panel panel)
        {
            if(panel.Visible == false)
            {
                hideAll();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void btnCB_Click(object sender, EventArgs e)
        {
            showMenu(pnlCB);
        }

        private void btnSH_Click(object sender, EventArgs e)
        {
            showMenu(pnlSH);
        }

        private void btnSA_Click(object sender, EventArgs e)
        {
            showMenu(pnlSA);
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            showMenu(pnlIN);
        }

        private void btnNG_Click(object sender, EventArgs e)
        {
            showMenu(pnlNG);
        }
    }
}
