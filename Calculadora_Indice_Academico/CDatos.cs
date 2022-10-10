using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Calculadora_Indice_Academico
{   
    
    internal class CDatos
    {
        Aseguramiento_bdEntities db;

        public List<estudiante> Read()
        {
            try
            {
                using(db= new Aseguramiento_bdEntities())
                {
                    return db.estudiantes.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;    
            }
        }
    }
}
