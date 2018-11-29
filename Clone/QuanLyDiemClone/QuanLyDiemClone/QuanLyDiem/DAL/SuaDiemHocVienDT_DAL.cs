using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    class SuaDiemHocVienDT_DAL
    {
 //       QuanLyDiemEntitiess db = new QuanLyDiemEntitiess();
        public void suaDiemHocVien_DAL(string MaHV, string MaHP, double bt, double gk, double thi)
        {
            using (QuanLyDiemEntitiess db = new QuanLyDiemEntitiess())
            {
                KetQuaHocPhan ketQuaHocPhan = (from c in db.KetQuaHocPhans
                                               where c.HocVien.ID == MaHV && c.HocPhan.MaHP == MaHP
                                               select c).SingleOrDefault();
                ketQuaHocPhan.DiemBT = bt;
                ketQuaHocPhan.DiemGK = gk;
                ketQuaHocPhan.DiemThi = thi;
                db.SaveChanges();
            }
        }
    }
}
