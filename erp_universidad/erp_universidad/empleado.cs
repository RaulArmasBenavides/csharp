//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace erp_universidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empleado()
        {
            this.factura = new HashSet<factura>();
            this.solicitud = new HashSet<solicitud>();
            this.usuarios = new HashSet<usuarios>();
        }
    
        public int idempleado { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public string nombre { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public string estado_civil { get; set; }
        public string domicilio { get; set; }
        public string DNI { get; set; }
        public Nullable<int> idcontrato { get; set; }
    
        public virtual contrato contrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factura> factura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<solicitud> solicitud { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuarios> usuarios { get; set; }
    }
}
