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
    
    public partial class trimestre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trimestre()
        {
            this.estudiante = new HashSet<estudiante>();
            this.estudiante_historico = new HashSet<estudiante_historico>();
            this.trimestre_materia = new HashSet<trimestre_materia>();
        }
    
        public int trimestre_id { get; set; }
        public string trimestre_nombre { get; set; }
        public System.DateTime trimestre_fechIN { get; set; }
        public System.DateTime trimestre_fechOUT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<estudiante> estudiante { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<estudiante_historico> estudiante_historico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trimestre_materia> trimestre_materia { get; set; }
    }
}