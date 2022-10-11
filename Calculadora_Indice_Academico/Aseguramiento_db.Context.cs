﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Aseguramiento_dbEntities : DbContext
    {
        public Aseguramiento_dbEntities()
            : base("name=Aseguramiento_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<administrador> administrador { get; set; }
        public virtual DbSet<area> area { get; set; }
        public virtual DbSet<aula> aula { get; set; }
        public virtual DbSet<calificacion> calificacion { get; set; }
        public virtual DbSet<carrera> carrera { get; set; }
        public virtual DbSet<docente> docente { get; set; }
        public virtual DbSet<estudiante> estudiante { get; set; }
        public virtual DbSet<estudiante_historico> estudiante_historico { get; set; }
        public virtual DbSet<materia> materia { get; set; }
        public virtual DbSet<tipo_aula> tipo_aula { get; set; }
        public virtual DbSet<trimestre> trimestre { get; set; }
        public virtual DbSet<trimestre_materia> trimestre_materia { get; set; }
        public virtual DbSet<user_login> user_login { get; set; }
    
        public virtual int insert_docente(string docente_cedula, string docente_nombres, string docente_apellidoP, string docente_apellidoM, string docente_telefono, string docente_correo, Nullable<int> area_id, string user_password)
        {
            var docente_cedulaParameter = docente_cedula != null ?
                new ObjectParameter("docente_cedula", docente_cedula) :
                new ObjectParameter("docente_cedula", typeof(string));
    
            var docente_nombresParameter = docente_nombres != null ?
                new ObjectParameter("docente_nombres", docente_nombres) :
                new ObjectParameter("docente_nombres", typeof(string));
    
            var docente_apellidoPParameter = docente_apellidoP != null ?
                new ObjectParameter("docente_apellidoP", docente_apellidoP) :
                new ObjectParameter("docente_apellidoP", typeof(string));
    
            var docente_apellidoMParameter = docente_apellidoM != null ?
                new ObjectParameter("docente_apellidoM", docente_apellidoM) :
                new ObjectParameter("docente_apellidoM", typeof(string));
    
            var docente_telefonoParameter = docente_telefono != null ?
                new ObjectParameter("docente_telefono", docente_telefono) :
                new ObjectParameter("docente_telefono", typeof(string));
    
            var docente_correoParameter = docente_correo != null ?
                new ObjectParameter("docente_correo", docente_correo) :
                new ObjectParameter("docente_correo", typeof(string));
    
            var area_idParameter = area_id.HasValue ?
                new ObjectParameter("area_id", area_id) :
                new ObjectParameter("area_id", typeof(int));
    
            var user_passwordParameter = user_password != null ?
                new ObjectParameter("user_password", user_password) :
                new ObjectParameter("user_password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insert_docente", docente_cedulaParameter, docente_nombresParameter, docente_apellidoPParameter, docente_apellidoMParameter, docente_telefonoParameter, docente_correoParameter, area_idParameter, user_passwordParameter);
        }
    
        public virtual int insert_student(string estudiante_cedula, string estudiante_nombres, string estudiante_apellidoP, string estudiante_apellidoM, string estudiante_telefono, string estudiante_correo, Nullable<int> carrera_id, string user_password)
        {
            var estudiante_cedulaParameter = estudiante_cedula != null ?
                new ObjectParameter("estudiante_cedula", estudiante_cedula) :
                new ObjectParameter("estudiante_cedula", typeof(string));
    
            var estudiante_nombresParameter = estudiante_nombres != null ?
                new ObjectParameter("estudiante_nombres", estudiante_nombres) :
                new ObjectParameter("estudiante_nombres", typeof(string));
    
            var estudiante_apellidoPParameter = estudiante_apellidoP != null ?
                new ObjectParameter("estudiante_apellidoP", estudiante_apellidoP) :
                new ObjectParameter("estudiante_apellidoP", typeof(string));
    
            var estudiante_apellidoMParameter = estudiante_apellidoM != null ?
                new ObjectParameter("estudiante_apellidoM", estudiante_apellidoM) :
                new ObjectParameter("estudiante_apellidoM", typeof(string));
    
            var estudiante_telefonoParameter = estudiante_telefono != null ?
                new ObjectParameter("estudiante_telefono", estudiante_telefono) :
                new ObjectParameter("estudiante_telefono", typeof(string));
    
            var estudiante_correoParameter = estudiante_correo != null ?
                new ObjectParameter("estudiante_correo", estudiante_correo) :
                new ObjectParameter("estudiante_correo", typeof(string));
    
            var carrera_idParameter = carrera_id.HasValue ?
                new ObjectParameter("carrera_id", carrera_id) :
                new ObjectParameter("carrera_id", typeof(int));
    
            var user_passwordParameter = user_password != null ?
                new ObjectParameter("user_password", user_password) :
                new ObjectParameter("user_password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insert_student", estudiante_cedulaParameter, estudiante_nombresParameter, estudiante_apellidoPParameter, estudiante_apellidoMParameter, estudiante_telefonoParameter, estudiante_correoParameter, carrera_idParameter, user_passwordParameter);
        }
    
        public virtual ObjectResult<show_carreras_Result> show_carreras()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<show_carreras_Result>("show_carreras");
        }
    
        public virtual ObjectResult<show_docente_Result> show_docente()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<show_docente_Result>("show_docente");
        }
    
        public virtual ObjectResult<show_students_Result> show_students()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<show_students_Result>("show_students");
        }
    }
}