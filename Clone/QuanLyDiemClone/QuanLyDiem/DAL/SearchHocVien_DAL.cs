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
                tb.Columns.Add("Mã Học Viên");
                tb.Columns.Add("Họ Tên");
                tb.Columns.Add("Lớp Sinh Hoạt");
                tb.Columns.Add("Khoa");
                foreach (var i in v)
                {
                    DataRow r = tb.NewRow();
                    r["Mã Học Viên"] = i.ID.ToString().Trim();
                    r["Họ Tên"] = i.HoTen.ToString().Trim();
                    r["Lớp Sinh Hoạt"] = i.LopDaoTao.TenLop.ToString().Trim();
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
                        where c.ID.Contains(str) || c.HoTen.Contains(str)
                        select c;
                tb.Columns.Add("Mã Học Viên");
                tb.Columns.Add("Họ Tên");
                tb.Columns.Add("Lớp Sinh Hoạt");
                tb.Columns.Add("Khoa");
                foreach (var i in v)
                {
                    DataRow r = tb.NewRow();
                    r["Mã Học Viên"] = i.ID.ToString().Trim();
                    r["Họ Tên"] = i.HoTen.ToString().Trim();
                    r["Lớp Sinh Hoạt"] = i.LopDaoTao.TenLop.ToString().Trim();
                    r["Khoa"] = i.LopDaoTao.Khoa.TenKhoa.ToString().Trim();
                    tb.Rows.Add(r);
                }
            }
            return tb;
        }
    }
}
