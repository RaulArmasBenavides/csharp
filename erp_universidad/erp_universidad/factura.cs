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
    
    public partial class factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public factura()
        {
            this.detallefactura = new HashSet<detallefactura>();
            this.orden_compra = new HashSet<orden_compra>();
            this.servicio = new HashSet<servicio>();
        }
    
        public int idfactura { get; set; }
        public System.DateTime fecha { get; set; }
        public Nullable<int> idempleado { get; set; }
        public Nullable<int> idcomprador { get; set; }
    
        public virtual comprador comprador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detallefactura> detallefactura { get; set; }
        public virtual empleado empleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orden_compra> orden_compra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<servicio> servicio { get; set; }
    }
}
