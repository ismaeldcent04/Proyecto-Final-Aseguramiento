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
    
    public partial class estudiante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public estudiante()
        {
            this.calificacion = new HashSet<calificacion>();
            this.estudiante_historico = new HashSet<estudiante_historico>();
        }
    
        public int estudiante_id { get; set; }
        public string estudiante_cedula { get; set; }
        public string estudiante_nombres { get; set; }
        public string estudiante_apellidoP { get; set; }
        public string estudiante_apellidoM { get; set; }
        public string estudiante_telefono { get; set; }
        public string estudiante_correo { get; set; }
        public int trimestre_entrada { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<calificacion> calificacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<estudiante_historico> estudiante_historico { get; set; }
        public virtual trimestre trimestre { get; set; }
    }
}
