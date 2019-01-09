using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyDiem.DAL
{
    internal class SuaDiemHocVienDT_DAL
    {
        public void suaDiemHocVien_DAL(string MaHV, string MaHP, string bt, string gk, string thi)
        {
            using (QuanLyDiemEntities db = new QuanLyDiemEntities())
            {
                KetQuaHocPhan ketQuaHocPhan = (from c in db.KetQuaHocPhan where c.HocVien.ID == MaHV && c.HocPhan.MaHP == MaHP
                                               select c).SingleOrDefault();
                if(bt!="") ketQuaHocPhan.DiemBT = Convert.ToDouble(bt);
                if(gk!="") ketQuaHocPhan.DiemGK = Convert.ToDouble(gk);
                if(thi!="")ketQuaHocPhan.DiemThi = Convert.ToDouble(thi);
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
        public DateTime getHanNhapDiem_DAL(string MaHK)
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                var hanNhapDiem = (from c in DB.HocKy
                                   where c.MaHK == MaHK
                                   select c).SingleOrDefault();
                return Convert.ToDateTime(hanNhapDiem);
            }
        }
        public bool HanNhapDiemGiuaKi_DAL(string MaHP)
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                var hanNhapDiem = (from c in DB.HocPhan
                                   where c.MaHP.ToString().Trim() == MaHP
                                   select c.HocKy).SingleOrDefault();
                TimeSpan diff1 = DateTime.Now - Convert.ToDateTime(hanNhapDiem.TGBatDau);
                TimeSpan diff2 = DateTime.Now - Convert.ToDateTime(hanNhapDiem.TGKetThuc);
                return (diff1.Days - 56 > 0 && diff2.Days - 30 < 0); // N>0 CON HAN
            }
        }
        public bool HetHanNhapDiemThi_DAL(string MaHP)
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                var hanNhapDiem = (from c in DB.HocPhan
                                   where c.MaHP.ToString().Trim() == MaHP
                                   select c.HocKy).SingleOrDefault();
                TimeSpan diff = DateTime.Now - Convert.ToDateTime(hanNhapDiem.TGKetThuc);
                return (diff.Days > 0 && diff.Days - 30 < 0); // N>0 CON HAN
            }
        }
        public bool Check_TMP(string MaHP)
        {
            using (QuanLyDiemEntities db = new QuanLyDiemEntities())
            {
                var MaGV = (from c in db.HocPhan
                           where c.MaHP.ToString().Trim() == MaHP
                           select c.ID).SingleOrDefault();
                if (MaGV.ToString().Trim() == FormLogin.User.ID.Trim())
                    return true;
                return false;
            }
        }
    }
}