using System;
using System.Collections.Generic;
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
            //DataTable tb = new DataTable();
            //tb.Columns.Add("Mã số");
            //tb.Columns.Add("Họ tên");
            //tb.Columns.Add("Điểm BT");
            //tb.Columns.Add("Điểm GK");
            //tb.Columns.Add("Điểm Thi");

            //var v = from s in db.KetQuaHocPhans
            //		where s.ID == str
            //		select new { s.HocPhan.HocKy.NamHoc };

            var v = from s in db.HocVien
                    where s.LopDaoTao.MaLop == str
                    select new { s.ID, s.HoTen, s.Email, s.DiaChi, s.DienThoai,s.NgaySinh};
            //foreach(var x in v)
            //{
            //	DataRow r = tb.NewRow();
            //	r["Mã số"] = x.ID;
            //	r["Họ tên"] = x.HoTen;
            //	//SingleOrDefault??
            //	r["Điểm BT"] = x.DiemBT;
            //	r["Điểm GK"] = x.DiemGK;
            //	r["Điểm Thi"] = x.DiemThi;
            //	tb.Rows.Add(r);
            //}
            return v.ToList();
        }

        public string getGVDAL(string str)
        {
            var v = from s in db.HocPhan
                    where s.MaHP == str
                    select s.GiangVien.HoTen;
            return v.SingleOrDefault();
        }
        public dynamic getDSSearchDAL(string str1, string str2, string MaLop)
        {

            var v = from s in db.HocVien
                    where (s.ID.Contains(str2) || s.HoTen.Contains(str2)) && (s.MaLop == MaLop)
                    select new { s.ID, s.HoTen, s.Email, s.DiaChi, s.DienThoai, s.NgaySinh };
            return v.ToList();
        }
    }
}

