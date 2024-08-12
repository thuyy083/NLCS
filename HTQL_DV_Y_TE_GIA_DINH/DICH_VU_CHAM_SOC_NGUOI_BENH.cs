﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel.DataAnnotations;

    public partial class DICH_VU_CHAM_SOC_NGUOI_BENH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICH_VU_CHAM_SOC_NGUOI_BENH()
        {
            this.DON_GIA_DICH_VU = new HashSet<DON_GIA_DICH_VU>();
            this.LICH_CHAM_SOC = new HashSet<LICH_CHAM_SOC>();
        }

        [Required(ErrorMessage = "Mã tdịch vụ không được để trống")]
        public int Ma_Dich_Vu { get; set; }
        [Required(ErrorMessage = "Tên dịch vụ không được để trống")]
        public string Ten_Dich_Vu { get; set; }
        [Required(ErrorMessage = "Moo tả dịch vụ không được để trống")]
        public string Mo_Ta { get; set; }
        [Required(ErrorMessage = "Nơi chăm sóc không được để trống")]
        public string Noi_Cham_Soc { get; set; }
        [Required(ErrorMessage = "Giới tính không được để trống")]
        public bool Gioi_Tinh_Cua_Nhan_Vien_Cham_Soc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DON_GIA_DICH_VU> DON_GIA_DICH_VU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICH_CHAM_SOC> LICH_CHAM_SOC { get; set; }
    }
}
