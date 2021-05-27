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
    
    public partial class orden_compra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orden_compra()
        {
            this.detalord = new HashSet<detalord>();
        }
    
        public int idorden_compra { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string folio { get; set; }
        public Nullable<System.DateTime> fecha_rec { get; set; }
        public Nullable<System.DateTime> fecha_apr { get; set; }
        public Nullable<System.DateTime> fecha_anu { get; set; }
        public Nullable<System.DateTime> fecha_entrega { get; set; }
        public string estado { get; set; }
        public string comentario { get; set; }
        public string cr_responsable { get; set; }
        public Nullable<decimal> moneda { get; set; }
        public string forma_pago { get; set; }
        public Nullable<int> idproveedor { get; set; }
        public Nullable<int> idfactura { get; set; }
        public Nullable<int> idrecepcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalord> detalord { get; set; }
        public virtual factura factura { get; set; }
        public virtual proveedor proveedor { get; set; }
        public virtual recepcion recepcion { get; set; }
    }
}