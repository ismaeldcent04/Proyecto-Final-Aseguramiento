using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Calculadora_Indice_Academico
{
    public partial class HistorialUc : UserControl
    {
        AseguramientoDbEntities Db = new AseguramientoDbEntities();
        public HistorialUc()
        {
            InitializeComponent();
            hideAll();
            var fullEntries = (from e in Db.estudiantes
                               join eh in Db.estudiante_historico on e.estudiante_id equals eh.estudiante_id
                               join c in Db.carreras on eh.carrera_id equals c.carrera_id
                               where e.estudiante_id == 100000
                               select new
                               {
                                   ID = e.estudiante_id,
                                   Nombre = e.estudiante_nombres,
                                   ApellidoP = e.estudiante_apellidoP,
                                   ApellidoM = e.estudiante_apellidoM,
                                   Carrera = c.carrera_nombre,
                                   TriCur = eh.trimestres_cursados
                               }).Take(1).ToList();

            foreach (var a in fullEntries)
            {
                lblID.Text = a.ID.ToString();
                lblNombre.Text = $"{a.Nombre} {a.ApellidoP} {a.ApellidoM}";
                lblPrograma.Text = a.Carrera;
                showTri(a.TriCur);
            }
            
        }
        private void hideAll()
        {
            pnlTri1.Visible = false;
            pnlTri2.Visible = false;
            pnlTri3.Visible = false;
            pnlTri4.Visible = false;
            pnlTri5.Visible = false;
            pnlTri6.Visible = false;
            pnlTri7.Visible = false;
            pnlTri8.Visible = false;
            pnlTri9.Visible = false;
            pnlTri10.Visible = false;
            pnlTri11.Visible = false;
            pnlTri12.Visible = false;
            pnlTri13.Visible = false;
            pnlTri14.Visible = false;
            pnlTri15.Visible = false;
            pnlTri16.Visible = false;
            pnlTri17.Visible = false;
            pnlTri18.Visible = false;
            pnlTri19.Visible = false;
            pnlTri20.Visible = false;
            pnlTri21.Visible = false;
        }

        private void showTri(int Tri)
        {
            switch (Tri)
            {
                case 1:
                    pnlTri1.Visible = true;
                    break;
                case 2:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    break;
                case 3:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    break;
                case 4:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    break;
                case 5:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    break;
                case 6:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    break;
                case 7:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    pnlTri7.Visible = true;
                    break;
                case 8:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    pnlTri7.Visible = true;
                    pnlTri8.Visible = true;
                    break;
                case 9:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    pnlTri7.Visible = true;
                    pnlTri8.Visible = true;
                    pnlTri9.Visible = true;
                    break;
                case 10:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    pnlTri7.Visible = true;
                    pnlTri8.Visible = true;
                    pnlTri9.Visible = true;
                    pnlTri10.Visible = true;
                    break;
                case 11:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    pnlTri7.Visible = true;
                    pnlTri8.Visible = true;
                    pnlTri9.Visible = true;
                    pnlTri10.Visible = true;
                    pnlTri11.Visible = true;
                    break;
                case 12:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    pnlTri7.Visible = true;
                    pnlTri8.Visible = true;
                    pnlTri9.Visible = true;
                    pnlTri10.Visible = true;
                    pnlTri11.Visible = true;
                    pnlTri12.Visible = true;
                    break;
                case 13:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    pnlTri7.Visible = true;
                    pnlTri8.Visible = true;
                    pnlTri9.Visible = true;
                    pnlTri10.Visible = true;
                    pnlTri11.Visible = true;
                    pnlTri12.Visible = true;
                    pnlTri13.Visible = true;
                    break;
                case 14:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    pnlTri7.Visible = true;
                    pnlTri8.Visible = true;
                    pnlTri9.Visible = true;
                    pnlTri10.Visible = true;
                    pnlTri11.Visible = true;
                    pnlTri12.Visible = true;
                    pnlTri13.Visible = true;
                    pnlTri14.Visible = true;
                    break;
                case 15:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    pnlTri7.Visible = true;
                    pnlTri8.Visible = true;
                    pnlTri9.Visible = true;
                    pnlTri10.Visible = true;
                    pnlTri11.Visible = true;
                    pnlTri12.Visible = true;
                    pnlTri13.Visible = true;
                    pnlTri14.Visible = true;
                    pnlTri15.Visible = true;
                    break;
                case 16:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    pnlTri7.Visible = true;
                    pnlTri8.Visible = true;
                    pnlTri9.Visible = true;
                    pnlTri10.Visible = true;
                    pnlTri11.Visible = true;
                    pnlTri12.Visible = true;
                    pnlTri13.Visible = true;
                    pnlTri14.Visible = true;
                    pnlTri15.Visible = true;
                    pnlTri16.Visible = true;
                    break;
                case 17:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    pnlTri7.Visible = true;
                    pnlTri8.Visible = true;
                    pnlTri9.Visible = true;
                    pnlTri10.Visible = true;
                    pnlTri11.Visible = true;
                    pnlTri12.Visible = true;
                    pnlTri13.Visible = true;
                    pnlTri14.Visible = true;
                    pnlTri15.Visible = true;
                    pnlTri16.Visible = true;
                    pnlTri17.Visible = true;
                    break;
                case 18:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    pnlTri7.Visible = true;
                    pnlTri8.Visible = true;
                    pnlTri9.Visible = true;
                    pnlTri10.Visible = true;
                    pnlTri11.Visible = true;
                    pnlTri12.Visible = true;
                    pnlTri13.Visible = true;
                    pnlTri14.Visible = true;
                    pnlTri15.Visible = true;
                    pnlTri16.Visible = true;
                    pnlTri17.Visible = true;
                    pnlTri18.Visible = true;
                    break;
                case 19:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    pnlTri7.Visible = true;
                    pnlTri8.Visible = true;
                    pnlTri9.Visible = true;
                    pnlTri10.Visible = true;
                    pnlTri11.Visible = true;
                    pnlTri12.Visible = true;
                    pnlTri13.Visible = true;
                    pnlTri14.Visible = true;
                    pnlTri15.Visible = true;
                    pnlTri16.Visible = true;
                    pnlTri17.Visible = true;
                    pnlTri18.Visible = true;
                    pnlTri19.Visible = true;
                    break;
                case 20:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    pnlTri7.Visible = true;
                    pnlTri8.Visible = true;
                    pnlTri9.Visible = true;
                    pnlTri10.Visible = true;
                    pnlTri11.Visible = true;
                    pnlTri12.Visible = true;
                    pnlTri13.Visible = true;
                    pnlTri14.Visible = true;
                    pnlTri15.Visible = true;
                    pnlTri16.Visible = true;
                    pnlTri17.Visible = true;
                    pnlTri18.Visible = true;
                    pnlTri19.Visible = true;
                    pnlTri20.Visible = true;
                    break;
                case 21:
                    pnlTri1.Visible = true;
                    pnlTri2.Visible = true;
                    pnlTri3.Visible = true;
                    pnlTri4.Visible = true;
                    pnlTri5.Visible = true;
                    pnlTri6.Visible = true;
                    pnlTri7.Visible = true;
                    pnlTri8.Visible = true;
                    pnlTri9.Visible = true;
                    pnlTri10.Visible = true;
                    pnlTri11.Visible = true;
                    pnlTri12.Visible = true;
                    pnlTri13.Visible = true;
                    pnlTri14.Visible = true;
                    pnlTri15.Visible = true;
                    pnlTri16.Visible = true;
                    pnlTri17.Visible = true;
                    pnlTri18.Visible = true;
                    pnlTri19.Visible = true;
                    pnlTri20.Visible = true;
                    pnlTri21.Visible = true;
                    break;
                default:
                    hideAll();
                    break;
            }
        }


    }
}
