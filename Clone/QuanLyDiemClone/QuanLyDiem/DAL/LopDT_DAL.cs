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
        //QuanLyDiemEntities db = new QuanLyDiemEntities();

        //public dynamic getDSHoHV(string str)
        //{
        //    List<string> Listho = new List<string>();
        //    var v = from s in db.HocVien
        //            where s.MaLop == str
        //            select s.HoTen;
        //    foreach (string x in v)
        //    {
        //        string s = "";
        //        int index = 0;
        //        for (int i = x.Length - 1; i >= 0; i--)
        //        {
        //            if (x[i] == ' ')
        //            {
        //                index = i;
        //                break;
        //            }
        //        }
        //        for (int j = 0; j < index; j++)
        //        {
        //            s += x[j];
        //        }
        //        Listho.Add(s);
        //    }
        //    return Listho;
        //}

        //public List<string> getDSTenHV(string str)
        //{
        //    List<string> Listten = new List<string>();
        //    var v = from s in db.HocVien
        //            where s.MaLop == str
        //            select s.HoTen;

        //    foreach (string x in v)
        //    {
        //        string s = "";
        //        int index = 0;
        //        for (int i = x.Length - 1; i >= 0; i--)
        //        {
        //            if (x[i] == ' ')
        //            {
        //                index = i;
        //                break;
        //            }
        //        }
        //        for (int j = index + 1; j < x.Length; j++)
        //        {
        //            s += x[j];
        //        }
        //        Listten.Add(s);
        //    }
        //    return Listten;
        //}
        //public dynamic getDSHVDAL(string str)// lấy bảng danh sách các học viên của lớp đào tạo từ csdl
        //{
        //    DataTable tb = new DataTable();
        //    tb.Columns.Add("Mã số");
        //    tb.Columns.Add("Họ");
        //    tb.Columns.Add("Tên");
        //    tb.Columns.Add("Email");
        //    tb.Columns.Add("Địa chỉ");
        //    tb.Columns.Add("Điện thoại");
        //    tb.Columns.Add("Ngày sinh");
        //    var v = from s in db.HocVien
        //            where s.MaLop == str
        //            select new { s.ID, s.HoTen, s.Email, s.DiaChi, s.DienThoai, s.NgaySinh };
        //    List<string> ListTen = getDSTenHV(str);
        //    List<string> ListHo = getDSHoHV(str);
        //    int index = 0;

        //    foreach (var x in v)
        //    {
        //        DataRow r = tb.NewRow();
        //        r["Mã số"] = x.ID;
        //        r["Họ"] = ListHo[index];
        //        r["Tên"] = ListTen[index++];
        //        r["Email"] = x.Email;
        //        r["Địa chỉ"] = x.DiaChi;
        //        r["Điện thoại"] = x.DienThoai;
        //        r["Ngày sinh"] = x.NgaySinh;
        //        tb.Rows.Add(r);
        //    }
        //    return tb;
        //}

        //public dynamic getDSSearchDAL(string str2, string MaLop)
        //{

        //    var v = from s in db.HocVien
        //            where (s.ID.Contains(str2) || s.HoTen.Contains(str2)) && (s.MaLop == MaLop)
        //            select new { s.ID, s.HoTen, s.Email, s.DiaChi, s.DienThoai, s.NgaySinh };
        //    return v.ToList();
        //}

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
                    select new { s.ID, s.HoTen, s.Email, s.DiaChi, s.DienThoai, s.NgaySinh };

            foreach (var x in v)
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
            DataTable tb = new DataTable();
            tb.Columns.Add("Mã số");
            tb.Columns.Add("Họ tên");
            tb.Columns.Add("Email");
            tb.Columns.Add("Địa chỉ");
            tb.Columns.Add("Điện thoại");
            tb.Columns.Add("Ngày sinh");
            var v = from s in db.HocVien
                    where (s.ID.Contains(str2) || s.HoTen.Contains(str2)) && (s.MaLop == MaLop)
                    select new { s.ID, s.HoTen, s.Email, s.DiaChi, s.DienThoai, s.NgaySinh };
            foreach (var x in v)
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

        public dynamic checkLopDAL(string TenLop)
        {
            var v = from s in db.LopDaoTao
                    where s.TenLop == TenLop
                    select s.TenLop;
            if (v.Count() == 0)
                return true;
            return false;
        }

        public void upDateLopCHDAL(string maLop, string tenLop)
        {
            var ldt = from s in db.LopDaoTao
                      where s.MaLop == maLop
                      select s;
            ldt.SingleOrDefault().TenLop = tenLop;
            db.SaveChanges();
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
    }
}

