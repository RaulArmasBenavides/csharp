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
    
    public partial class detalord
    {
        public int iddetalord { get; set; }
        public Nullable<int> cantidad { get; set; }
        public string unidad { get; set; }
        public Nullable<float> precio { get; set; }
        public string estado { get; set; }
        public string origen { get; set; }
        public Nullable<int> idorden_compra { get; set; }
        public Nullable<int> idexplotacion { get; set; }
        public Nullable<int> idarticulo { get; set; }
        public Nullable<int> idcta { get; set; }
        public Nullable<int> idproducto { get; set; }
    
        public virtual articulo articulo { get; set; }
        public virtual ctascontables ctascontables { get; set; }
        public virtual unidadexplot unidadexplot { get; set; }
        public virtual orden_compra orden_compra { get; set; }
        public virtual producto producto { get; set; }
    }
}