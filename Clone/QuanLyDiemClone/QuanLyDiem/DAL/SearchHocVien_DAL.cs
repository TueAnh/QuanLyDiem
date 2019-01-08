using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    class SearchHocVien_DAL
    {
        public DataTable LoadAllHocVien()
        {
            DataTable tb = new DataTable();
            using (QuanLyDiemEntities db = new QuanLyDiemEntities())
            {
                var v = from c in db.HocVien
                        select c;
                tb.Columns.Add("Mã HV");
                tb.Columns.Add("Họ");
                tb.Columns.Add("Tên");
                tb.Columns.Add("Lớp Cao học");
                tb.Columns.Add("Khoa");
                foreach (var i in v)
                {
                    DataRow r = tb.NewRow();
                    r["Mã HV"] = i.ID.ToString().Trim();
                    var name = i.HoTen.ToString().Trim().Split(' ');
                    for (int j = 0; j < name.Count() - 1; j++)
                        r["Họ"] += name[j]+" ";
                    r["Tên"] = name[name.Count() - 1];
                    r["Lớp Cao học"] = i.LopDaoTao.TenLop.ToString().Trim();
                    r["Khoa"] = i.LopDaoTao.Khoa.TenKhoa.ToString().Trim();
                    tb.Rows.Add(r);
                }
            }
            return tb;
        }
        public DataTable LoadSearchedHocVien(string str)
        {
            DataTable tb = new DataTable();
            using (QuanLyDiemEntities db1 = new QuanLyDiemEntities())
            {
                var v = from c in db1.HocVien
                        where c.ID.Contains(str) || c.HoTen.Contains(str) ||c.LopDaoTao.TenLop.Contains(str)
                        select c;
                tb.Columns.Add("Mã HV");
                tb.Columns.Add("Họ");
                tb.Columns.Add("Tên");
                tb.Columns.Add("Lớp Cao học");
                tb.Columns.Add("Khoa");
                foreach (var i in v)
                {
                    DataRow r = tb.NewRow();
                    r["Mã HV"] = i.ID.ToString().Trim();
                    var name = i.HoTen.ToString().Trim().Split(' ');
                    for (int j = 0; j < name.Count() - 1; j++)
                        r["Họ"] += name[j] + " ";
                    r["Tên"] = name[name.Count() - 1];
                    r["Lớp Cao học"] = i.LopDaoTao.TenLop.ToString().Trim();
                    r["Khoa"] = i.LopDaoTao.Khoa.TenKhoa.ToString().Trim();
                    tb.Rows.Add(r);
                }
            }
            return tb;
        }
        public bool XoaHV_DAL(string ID)
        {
            try
            {
                using (QuanLyDiemEntities db = new QuanLyDiemEntities())
                {
                    HocVien hv = db.HocVien.Find(ID);
                    db.HocVien.Remove(hv);
                    db.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
                
        }
        public bool AddHV_DAL(string MaHV, string MaHP)
        {
            try
            {
                using (QuanLyDiemEntities db = new QuanLyDiemEntities())
                {
                    KetQuaHocPhan ketQuaHocPhan = db.KetQuaHocPhan.Where(p => p.ID == MaHV && p.MaHP == MaHP).Select(p => p).SingleOrDefault();
                    if (ketQuaHocPhan == null)
                    {
                        int i = 0;
                        string x;
                        do
                        {
                            i++;
                            x = i.ToString();
                            while (x.Length < 4)
                                x = '0' + x;
                            x = "KQHP" + x;
                        }
                        while (db.KetQuaHocPhan.Find(x) != null);
                        ketQuaHocPhan = new KetQuaHocPhan();
                        ketQuaHocPhan.MaKQHP = x;
                        ketQuaHocPhan.ID = db.HocVien.Find(MaHV).ID;
                        ketQuaHocPhan.MaHP = db.HocPhan.Find(MaHP).MaHP;
                        db.KetQuaHocPhan.Add(ketQuaHocPhan);
                        db.SaveChanges();
                    }
                    else
                        return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
