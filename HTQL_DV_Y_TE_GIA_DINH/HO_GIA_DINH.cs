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

    public partial class HO_GIA_DINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HO_GIA_DINH()
        {
            this.BENH_NHAN = new HashSet<BENH_NHAN>();
            this.PHAN_CONG_CHAM_SOC = new HashSet<PHAN_CONG_CHAM_SOC>();
        }
        [Required(ErrorMessage = "Mã không được để trống")]
        public int Ma_HGD { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"^\d{10,11}$", ErrorMessage = "Số điện thoại phải chứa từ 10 đến 11 chữ số")]
        public string SoDienThoai_HGD { get; set; }

        [Required(ErrorMessage = "Tên chủ hộ không được để trống")]
        public string Chu_Ho { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Dia_Chi_HGD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BENH_NHAN> BENH_NHAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHAN_CONG_CHAM_SOC> PHAN_CONG_CHAM_SOC { get; set; }
    }
}
