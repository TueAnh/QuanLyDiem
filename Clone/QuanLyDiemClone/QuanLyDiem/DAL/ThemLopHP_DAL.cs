using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    class ThemLopHP_DAL
    {
       
        public void ThemHP_DAL(string maHP,string tenHP,int soTC,int soTiet,double phanTramDGK,double phanTramDT,string maHK,string iD)
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                DB.HocPhan.Add(new HocPhan
                {
                    MaHP = maHP,
                    TenHP = tenHP,
                    SoTC = soTC,
                    SoTiet = soTiet,
                    PhanTramDGK = phanTramDGK,
                    PhanTramDT = phanTramDT,
                    MaHK = maHK,
                    ID = iD
                });
                DB.SaveChanges();
            }
        }
        public bool ChecKExistHP_DAL(string maHP)
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                var v = DB.HocPhan.Select(s=>s).Where(s=>s.MaHP == maHP).Count();
                return Convert.ToInt16(v) > 0;
            }
        }
        
        public void loadGV_DAL(List<string> lID,List<string> lHoTen)
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                var v = from s in DB.GiangVien
                        where s.ID.Contains("GV")
                        orderby s.HoTen
                        select s;
                foreach(var x in v)
                {
                    lID.Add(x.ID.ToString());
                    lHoTen.Add(x.HoTen.ToString());
                }
            }

        }
        public void loadHK_NH_DAL(List<string> lMaHK, List<string> lTenHK, List<string> lNamHoc)
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                var v = from s in DB.HocKy
                        orderby s.NamHoc
                        select s;
                foreach (var x in v)
                {
                    lMaHK.Add(x.MaHK.ToString());
                    lTenHK.Add(x.TenHK.ToString());
                    lNamHoc.Add(x.NamHoc.ToString());
                }
            }

        }
        
    }
}
