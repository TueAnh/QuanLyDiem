//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDiem
{
    using System;
    using System.Collections.Generic;
    
    public partial class KetQuaHocPhan
    {
        public Nullable<double> DiemBT { get; set; }
        public Nullable<double> DiemGK { get; set; }
        public Nullable<double> DiemThi { get; set; }
        public string MaHP { get; set; }
        public string ID { get; set; }
        public string MaKQHP { get; set; }
    
        public virtual HocPhan HocPhan { get; set; }
        public virtual HocVien HocVien { get; set; }
    }
}
