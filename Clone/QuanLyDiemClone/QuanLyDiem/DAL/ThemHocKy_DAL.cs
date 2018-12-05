using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    class ThemHocKy_DAL
    {
        public void ThemHK_DAL(string maHK, string tenHK, DateTime TgBatDau, DateTime TgKetThuc ,int namHoc)
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                DB.HocKy.Add(new HocKy
                {
                    MaHK = maHK,
                    TenHK = tenHK,
                    TGBatDau = TgBatDau,
                    TGKetThuc = TgKetThuc,
                    NamHoc = namHoc
                });
                DB.SaveChanges();
            }
        }
        public bool ChecKExistHK_DAL(string maHK)
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                var v = DB.HocKy.Select(s => s).Where(s => s.MaHK.Trim() == maHK).Count();
                return Convert.ToInt16(v) > 0;
            }
        }
    }
}
