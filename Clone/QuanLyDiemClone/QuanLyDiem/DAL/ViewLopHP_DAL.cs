using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    public class ViewLopHP_DAL
    {
        QuanLyDiemEntities db = new QuanLyDiemEntities();
        public List<int> getNodeDAL()// Lấy năm học
        {
            List<int> str = new List<int>();
            var hk = (from s in db.HocKy
                      select s.NamHoc).Distinct();
            foreach (var x in hk)//add nam hoc vao list
            {
                str.Add(Convert.ToInt32(x));
            }
            return str;
        }

        public DataTable getTbHPDAL(string hk, int nh)//lấy bảng danh sách các học phẩn của học kì đó từ csdl
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Mã HP");
            tb.Columns.Add("Tên HP");
            tb.Columns.Add("Số TC");
            tb.Columns.Add("Phần trăm DGK");
            tb.Columns.Add("Phần trăm DT");
            var v = from s in db.HocPhan
                    where s.HocKy.TenHK == hk && s.HocKy.NamHoc == nh
                    select new { s.MaHP, s.TenHP, s.SoTC, s.PhanTramDGK, s.PhanTramDT };
            foreach (var x in v)
            {
                DataRow r = tb.NewRow();
                r["Mã HP"] = x.MaHP.Trim();
                r["Tên HP"] = x.TenHP;
                r["Số TC"] = x.SoTC;
                r["Phần trăm DGK"] = x.PhanTramDGK;
                r["Phần trăm DT"] = x.PhanTramDT;
                tb.Rows.Add(r);
            }
            return tb;
        }
        public bool XoaHP(string ID)
        {
            try
            {
                using (QuanLyDiemEntities db = new QuanLyDiemEntities())
                {
                    db.HocPhan.Remove(db.HocPhan.Find(ID.Trim()));
                    db.SaveChanges();
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

