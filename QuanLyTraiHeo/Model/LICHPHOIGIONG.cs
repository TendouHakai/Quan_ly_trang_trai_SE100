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
    using System;
    using System.Collections.Generic;
    
    public partial class LICHPHOIGIONG
    {
        public string MaLichPhoi { get; set; }
        public string MaHeoDuc { get; set; }
        public string MaHeoCai { get; set; }
        public string Trangthai { get; set; }
        public Nullable<System.DateTime> NgayDuKienDe { get; set; }
        public Nullable<System.DateTime> NgayDeThucTe { get; set; }
        public Nullable<int> SoCon { get; set; }
        public Nullable<int> SoConChet { get; set; }
        public Nullable<System.DateTime> NgayCaiSua { get; set; }
        public Nullable<System.DateTime> SoConChon { get; set; }
    
        public virtual HEO HEO { get; set; }
        public virtual HEO HEO1 { get; set; }
    }
}
