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
    
    public partial class area
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public area()
        {
            this.carreras = new HashSet<carrera>();
            this.docentes = new HashSet<docente>();
        }
    
        public int area_id { get; set; }
        public string area_nombre { get; set; }
        public Nullable<int> docente_id { get; set; }
    
        public virtual docente docente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<carrera> carreras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<docente> docentes { get; set; }
    }
}
