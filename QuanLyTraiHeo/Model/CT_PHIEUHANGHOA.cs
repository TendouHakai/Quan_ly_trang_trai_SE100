//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyTraiHeo.Model
{
    using QuanLyTraiHeo.ViewModel;
    using System;
    using System.Collections.Generic;
    
    public partial class CT_PHIEUHANGHOA:BaseViewModel
    {
        public string SoPhieu { get; set; }
        public string MaHangHoa { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> _soLuong { get => SoLuong; set { SoLuong = value;  OnPropertyChanged(); } }
        public Nullable<int> DonGia { get; set; }
        public Nullable<int> _donGia { get => DonGia; set { DonGia = value; OnPropertyChanged(); } }
    
        public virtual HANGHOA HANGHOA { get; set; }
        public virtual PHIEUHANGHOA PHIEUHANGHOA { get; set; }
    }
}
