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
    
    public partial class tipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipo()
        {
            this.articulo = new HashSet<articulo>();
        }
    
        public int idtipo { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> idmarca { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<articulo> articulo { get; set; }
        public virtual marca marca { get; set; }
    }
}