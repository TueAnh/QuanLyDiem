using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyDiem.DAL
{
    internal class SuaDiemHocVienDT_DAL
    {
        public void suaDiemHocVien_DAL(string MaHV, string MaHP, double bt, double gk, double thi)
        {
            using (QuanLyDiemEntities db = new QuanLyDiemEntities())
            {
                KetQuaHocPhan ketQuaHocPhan = (from c in db.KetQuaHocPhan where c.HocVien.ID == MaHV && c.HocPhan.MaHP == MaHP
                                               select c).SingleOrDefault();
                ketQuaHocPhan.DiemBT = bt;
                ketQuaHocPhan.DiemGK = gk;
                ketQuaHocPhan.DiemThi = thi;
                db.SaveChanges();
            }
        }
        public KetQuaHocPhan GetDiem_DAL(string MaHV, string MaHP)
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                KetQuaHocPhan ketQuaHocPhan = (from c in DB.KetQuaHocPhan
                                               where c.HocVien.ID == MaHV && c.HocPhan.MaHP == MaHP
                                               select c).SingleOrDefault();
                return ketQuaHocPhan;
            }
        }
    }
}