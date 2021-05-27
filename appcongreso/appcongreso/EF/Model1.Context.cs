﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace appcongreso.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CongresoEntities : DbContext
    {
        public CongresoEntities()
            : base("name=CongresoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<actividades> actividades { get; set; }
        public virtual DbSet<asistencias> asistencias { get; set; }
        public virtual DbSet<participantes> participantes { get; set; }
    
        public virtual ObjectResult<usp_actividades_listar_all_Result> usp_actividades_listar_all()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_actividades_listar_all_Result>("usp_actividades_listar_all");
        }
    
        public virtual int usp_actualiza_participante(string ap_paterno, string ap_materno, string nombre, string telefono, string sexo, string correo, string dNI, string dirrecion, string tipo)
        {
            var ap_paternoParameter = ap_paterno != null ?
                new ObjectParameter("ap_paterno", ap_paterno) :
                new ObjectParameter("ap_paterno", typeof(string));
    
            var ap_maternoParameter = ap_materno != null ?
                new ObjectParameter("ap_materno", ap_materno) :
                new ObjectParameter("ap_materno", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("sexo", sexo) :
                new ObjectParameter("sexo", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var dNIParameter = dNI != null ?
                new ObjectParameter("DNI", dNI) :
                new ObjectParameter("DNI", typeof(string));
    
            var dirrecionParameter = dirrecion != null ?
                new ObjectParameter("dirrecion", dirrecion) :
                new ObjectParameter("dirrecion", typeof(string));
    
            var tipoParameter = tipo != null ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_actualiza_participante", ap_paternoParameter, ap_maternoParameter, nombreParameter, telefonoParameter, sexoParameter, correoParameter, dNIParameter, dirrecionParameter, tipoParameter);
        }
    
        public virtual int usp_eliminar_participante(string dNI)
        {
            var dNIParameter = dNI != null ?
                new ObjectParameter("DNI", dNI) :
                new ObjectParameter("DNI", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_eliminar_participante", dNIParameter);
        }
    
        public virtual ObjectResult<usp_participantes_listar_all_Result> usp_participantes_listar_all()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_participantes_listar_all_Result>("usp_participantes_listar_all");
        }
    
        public virtual int usp_registrar_participante(string ap_paterno, string ap_materno, string nombre, string telefono, string sexo, string correo, string dNI, string carrera, string direccion, string tipo)
        {
            var ap_paternoParameter = ap_paterno != null ?
                new ObjectParameter("ap_paterno", ap_paterno) :
                new ObjectParameter("ap_paterno", typeof(string));
    
            var ap_maternoParameter = ap_materno != null ?
                new ObjectParameter("ap_materno", ap_materno) :
                new ObjectParameter("ap_materno", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("sexo", sexo) :
                new ObjectParameter("sexo", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var dNIParameter = dNI != null ?
                new ObjectParameter("DNI", dNI) :
                new ObjectParameter("DNI", typeof(string));
    
            var carreraParameter = carrera != null ?
                new ObjectParameter("carrera", carrera) :
                new ObjectParameter("carrera", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            var tipoParameter = tipo != null ?
                new ObjectParameter("tipo", tipo) :
                new ObjectParameter("tipo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_registrar_participante", ap_paternoParameter, ap_maternoParameter, nombreParameter, telefonoParameter, sexoParameter, correoParameter, dNIParameter, carreraParameter, direccionParameter, tipoParameter);
        }
    
        public virtual int usp_actualizar_actividad(Nullable<int> id, string descripcion, Nullable<System.DateTime> fecha)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_actualizar_actividad", idParameter, descripcionParameter, fechaParameter);
        }
    
        public virtual int usp_eliminar_actividad(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_eliminar_actividad", idParameter);
        }
    
        public virtual int usp_registrar_actividad(string descripcion, Nullable<System.DateTime> fecha)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_registrar_actividad", descripcionParameter, fechaParameter);
        }
    }
}