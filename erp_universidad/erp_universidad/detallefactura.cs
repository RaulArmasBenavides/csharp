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
    
    public partial class detallefactura
    {
        public int iddetallefac { get; set; }
        public int NumPedido { get; set; }
        public int Cantidad { get; set; }
        public string Formadepago { get; set; }
        public Nullable<float> Punit { get; set; }
        public Nullable<float> Importe { get; set; }
        public Nullable<float> Subtotal { get; set; }
        public Nullable<float> IGV { get; set; }
        public float Total { get; set; }
        public string nserie { get; set; }
        public Nullable<int> idfactura { get; set; }
    
        public virtual factura factura { get; set; }
    }
}
