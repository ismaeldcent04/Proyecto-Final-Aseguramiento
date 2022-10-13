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
    public partial class MedioTerminoUc : UserControl
    {
        AseguramientoDbEntities Db = new AseguramientoDbEntities();
        public MedioTerminoUc()
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string year = boxYear.Text;
            string trimestre = boxTrimestre.Text;
            string result = trimestre + " " + year;
            label3.Text = result;
            dataMedio.DataSource = Db.show_medio(UserLoginCache.idUser.ToString(), result);
            dataMedio.Columns[0].HeaderText = "Sección";
            dataMedio.Columns[0].Width = 65;
            dataMedio.Columns[1].HeaderText = "Codigo";
            dataMedio.Columns[1].Width = 65;
            dataMedio.Columns[2].HeaderText = "Asignatura";
            dataMedio.Columns[2].Width = 300;
            dataMedio.Columns[3].HeaderText = "Cr.";
            dataMedio.Columns[3].Width = 50;
            dataMedio.Columns[4].HeaderText = "Profesor";
            dataMedio.Columns[4].Width = 300;
            dataMedio.Columns[5].Visible = false;
            var Notas = new DataGridViewTextBoxColumn();
            Notas.HeaderText = "Nota";
            Notas.Width = 50;
            dataMedio.Columns.AddRange(new DataGridViewColumn[] { Notas });
            notaloops();

        }
        public void notaloops()
        {
            int i = 0;
            foreach (DataGridViewRow row in dataMedio.Rows)
            {
                string nota = Convert.ToString(dataMedio.Rows[i].Cells[5].Value);
                dataMedio.Rows[i].Cells[6].Value = Nota(decimal.Parse(nota), "");
                i++;
            }
        }

        public string Nota(decimal nota, string calif)
        {
            if (nota >= 95)
            {
                calif = "A+";
            }
            else if (nota >= 90)
            {
                calif = "A";
            }
            else if (nota >= 85)
            {
                calif = "B+";
            }
            else if (nota >= 80)
            {
                calif = "B";
            }
            else if (nota >= 75)
            {
                calif = "C+";
            }
            else if (nota >= 70)
            {
                calif = "C";
            }
            else if (nota >= 60)
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
