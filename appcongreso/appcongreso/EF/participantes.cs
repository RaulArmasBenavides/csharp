//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class participantes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public participantes()
        {
            this.asistencias = new HashSet<asistencias>();
        }
    
        public int idparticipante { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string sexo { get; set; }
        public string correo { get; set; }
        public string DNI { get; set; }
        public string carrera { get; set; }
        public string direccion { get; set; }
        public string tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<asistencias> asistencias { get; set; }
    }
}
