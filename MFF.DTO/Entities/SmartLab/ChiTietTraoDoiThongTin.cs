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
    
    public partial class ChiTietTraoDoiThongTin
    {
        public int Ma_ChiTietTraoDoiThongTin { get; set; }
        public Nullable<int> Khoa_ChiTiet { get; set; }
        public Nullable<int> Ma_TraoDoiThongTin { get; set; }
        public Nullable<int> Ma_NguoiDung { get; set; }
        public string GiuPhanHoi { get; set; }
        public Nullable<bool> Xem { get; set; }
    }
}
