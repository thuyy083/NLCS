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
    
    public partial class TAI_KHOAN
    {
        public int Ma_TK { get; set; }
        public int Ma_Quyen { get; set; }
        public string Ho_Ten { get; set; }
        public System.DateTime Ngay_Sinh { get; set; }
        public string So_CCCD { get; set; }
        public bool Gioi_Tinh { get; set; }
        public string Dia_Chi { get; set; }
        public string So_Dien_Thoai { get; set; }
        public string Mat_Khau { get; set; }
    
        public virtual BAC_SI_GIA_DINH BAC_SI_GIA_DINH { get; set; }
        public virtual BENH_NHAN BENH_NHAN { get; set; }
        public virtual NHAN_VIEN_CHAM_SOC NHAN_VIEN_CHAM_SOC { get; set; }
        public virtual QUAN_TRI_VIEN QUAN_TRI_VIEN { get; set; }
        public virtual QUYEN_TRUY_CAP QUYEN_TRUY_CAP { get; set; }
    }
}
