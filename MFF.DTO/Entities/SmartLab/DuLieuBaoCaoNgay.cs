//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MFF.DTO.Entities.SmartLab
{
    using System;
    using System.Collections.Generic;
    
    public partial class DuLieuBaoCaoNgay
    {
        public int Ma_DuLieuBaoCaoNgay { get; set; }
        public Nullable<int> Ma_Cttv { get; set; }
        public string TenDong { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<double> GiaTri { get; set; }
        public Nullable<bool> Xoa { get; set; }
        public string TaoBoi { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public string CapNhatBoi { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
    }
}