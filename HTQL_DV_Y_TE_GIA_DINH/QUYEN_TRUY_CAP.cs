//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HTQL_DV_Y_TE_GIA_DINH
{
    using System;
    using System.Collections.Generic;
    
    public partial class QUYEN_TRUY_CAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUYEN_TRUY_CAP()
        {
            this.TAI_KHOAN = new HashSet<TAI_KHOAN>();
        }
    
        public int Ma_Quyen { get; set; }
        public string Ten_Quyen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAI_KHOAN> TAI_KHOAN { get; set; }
    }
}
