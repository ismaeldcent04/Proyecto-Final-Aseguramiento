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
        AseguramientoDbEntities Db = new AseguramientoDbEntities();
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string year = boxYear.Text;
            string trimestre = boxTrimestre.Text;
            string result = trimestre + " " + year;
            dataFinales.DataSource = Db.show_final(UserLoginCache.idUser.ToString(), result);
            dataFinales.Columns[0].HeaderText = "Sección";
            dataFinales.Columns[0].Width = 65;
            dataFinales.Columns[1].HeaderText = "Codigo";
            dataFinales.Columns[1].Width = 65;
            dataFinales.Columns[2].HeaderText = "Asignatura";
            dataFinales.Columns[2].Width = 300;
            dataFinales.Columns[3].HeaderText = "Cr.";
            dataFinales.Columns[3].Width = 50;
            dataFinales.Columns[4].HeaderText = "Profesor";
            dataFinales.Columns[4].Width = 300;
            dataFinales.Columns[5].HeaderText = "Nota";
            dataFinales.Columns[5].Width = 50;
            dataFinales.Columns[5].Visible = false;
            var Notas = new DataGridViewTextBoxColumn();
            Notas.HeaderText = "Nota";
            dataFinales.Columns.AddRange(new DataGridViewColumn[] { Notas });
            notaloop();
            dataFinales.Columns[5].Width = 50;
        }

        public void notaloop() {
            int i = 0;
            foreach(DataGridViewRow row in dataFinales.Rows)
            {
                string nota = Convert.ToString(dataFinales.Rows[i].Cells[5].Value);
                dataFinales.Rows[i].Cells[6].Value = Nota(decimal.Parse(nota), "");
                i++;
            }
        }

        public string Nota(decimal nota, string calif)
        {
            if(nota >= 95)
            {
                calif = "A+";
            }
            else if(nota >= 90)
            {
                calif = "A";
            }else if(nota >= 85)
            {
                calif = "B+";
            }else if(nota >= 80)
            {
                calif = "B";
            }else if(nota >= 75)
            {
                calif = "C+";
            }else if(nota >= 70)
            {
                calif = "C";
            }else if(nota >= 60)
            {
                calif = "D";
            }
            else
            {
                calif = "F";
            }
            return calif;
        }
    }
}
