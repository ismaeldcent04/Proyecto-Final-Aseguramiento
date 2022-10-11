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
        AseguramientoDbEntities Db = new AseguramientoDbEntities();
        public SeleccionUc()
        {
            InitializeComponent();
            hideAll();
            dataCB.DataSource = Db.show_seleccion();
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "Select";
            chkbox.Width = 25;
            chkbox.Name = "dgvchkbox";
            chkbox.DefaultCellStyle.BackColor = Color.Red;
            dataCB.Columns.Insert(0, chkbox);
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Seccion");
            dt.Columns.Add("Asignatura");
            dt.Columns.Add("Cr.");
            dt.Columns.Add("Lun");
            dt.Columns.Add("Ma");
            dt.Columns.Add("Mi");
            dt.Columns.Add("Ju");
            dt.Columns.Add("Vi");
            dt.Columns.Add("Sab");
            dt.Columns.Add("Profesor");

            foreach (DataGridViewRow drv in dataCB.Rows)
            {
                bool chckboxselect = Convert.ToBoolean(drv.Cells["dgvchkbox"].Value);
                if (chckboxselect)
                {
                    dt.Rows.Add(drv.Cells[1].Value, drv.Cells[2].Value, drv.Cells[3].Value, drv.Cells[4].Value, drv.Cells[5].Value, drv.Cells[6].Value, drv.Cells[7].Value, drv.Cells[8].Value, drv.Cells[9].Value, drv.Cells[10].Value);
                }
                dataSele.DataSource = dt;
            }
            
        }
    }
}
