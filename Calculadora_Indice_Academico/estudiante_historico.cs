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
    
    public partial class estudiante_historico
    {
        public int estudiante_id { get; set; }
        public int carrera_id { get; set; }
        public int trimestre_entrada { get; set; }
        public int trimestres_cursados { get; set; }
        public short isActive { get; set; }
    
        public virtual carrera carrera { get; set; }
        public virtual estudiante estudiante { get; set; }
        public virtual trimestre trimestre { get; set; }
    }
}
