//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calculadora_Indice_Academico
{
    using System;
    using System.Collections.Generic;
    
    public partial class trimestre_materia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trimestre_materia()
        {
            this.calificacions = new HashSet<calificacion>();
        }
    
        public int triMat_id { get; set; }
        public int trimestre_id { get; set; }
        public int materia_id { get; set; }
        public int docente_id { get; set; }
        public int aula_id { get; set; }
        public int seccion { get; set; }
        public string triMat_lunes { get; set; }
        public string triMat_martes { get; set; }
        public string triMat_miercoles { get; set; }
        public string triMat_jueves { get; set; }
        public string triMat_viernes { get; set; }
        public string triMat_sabado { get; set; }
    
        public virtual aula aula { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<calificacion> calificacions { get; set; }
        public virtual docente docente { get; set; }
        public virtual materia materia { get; set; }
        public virtual trimestre trimestre { get; set; }
    }
}
