using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    public class LopDT_DAL
    {
        QuanLyDiemEntities db = new QuanLyDiemEntities();

        public dynamic getDSHVDAL(string str)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Mã số");
            tb.Columns.Add("Họ tên");
            tb.Columns.Add("Email");
            tb.Columns.Add("Địa chỉ");
            tb.Columns.Add("Điện thoại");
            tb.Columns.Add("Ngày sinh");

            var v = from s in db.HocVien
                    where s.LopDaoTao.MaLop == str
                    select new { s.ID, s.HoTen, s.Email, s.DiaChi, s.DienThoai,s.NgaySinh};
                    
            foreach(var x in v)
            {
                DataRow r = tb.NewRow();
                try
                {
                    
                    r["Mã số"] = x.ID.Trim();
                    r["Họ tên"] = x.HoTen.Trim();
                    //SingleOrDefault??
                    r["Email"] = x.Email;
                    r["Địa chỉ"] = x.DiaChi;
                    r["Điện thoại"] = x.DienThoai;
                    r["Ngày sinh"] = string.Format("{0: yyyy-MM-dd}", x.NgaySinh.Value);
                }
                catch { }
                tb.Rows.Add(r);
            }
            return tb;
        }

        public string getGVDAL(string str)
        {
            var v = from s in db.HocPhan
                    where s.MaHP == str
                    select s.GiangVien.HoTen;
            return v.SingleOrDefault();
        }
        public dynamic getDSSearchDAL(string str2, string MaLop)
        {

            var v = from s in db.HocVien
                    where (s.ID.Contains(str2) || s.HoTen.Contains(str2)) && (s.MaLop == MaLop)
                    select new { s.ID, s.HoTen, s.Email, s.DiaChi, s.DienThoai, s.NgaySinh };
            return v.ToList();
        }
    }
}

