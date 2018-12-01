using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    public class LopHP_DAL
    {
        QuanLyDiemEntities db = new QuanLyDiemEntities();// khởi tạo đối tượng Entity giao tiếp trực tiếp với csdl

        public DataTable getDSHVDAL(string str)// lấy danh sách Học Viên
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Mã Số");
            tb.Columns.Add("Họ Tên");
            tb.Columns.Add("Điểm BT");
            tb.Columns.Add("Điểm GK");
            tb.Columns.Add("Điểm Thi");

            //var v = from s in db.KetQuaHocPhans
            //		where s.ID == str
            //		select new { s.HocPhan.HocKy.NamHoc };

            var v = from s in db.KetQuaHocPhan
                    where s.MaHP == str
                    select new { s.ID, s.HocVien.HoTen, s.DiemBT, s.DiemGK, s.DiemThi };
            foreach (var x in v)
            {
                DataRow r = tb.NewRow();
                r["Mã Số"] = x.ID;
                r["Họ Tên"] = x.HoTen;
                //singleordefault??
                r["Điểm BT"] = x.DiemBT;
                r["Điểm GK"] = x.DiemGK;
                r["Điểm Thi"] = x.DiemThi;
                tb.Rows.Add(r);
            }
            return tb;
        }

        public string getGVDAL(string str)// Lấy tên giảng viên phụ trách
        {
            var v = from s in db.HocPhan
                    where s.MaHP == str
                    select s.GiangVien.HoTen;
            return v.SingleOrDefault();
        }

        public DataTable getDSSearchDAL(string str, string MaHP)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Mã Số");
            tb.Columns.Add("Họ Tên");
            tb.Columns.Add("Điểm BT");
            tb.Columns.Add("Điểm GK");
            tb.Columns.Add("Điểm Thi");
            var v = from s in db.KetQuaHocPhan
                    where (s.HocVien.ID.Contains(str) || s.HocVien.HoTen.Contains(str)) && (s.MaHP == MaHP)
                    select new { s.ID, s.HocVien.HoTen, s.DiemBT, s.DiemGK, s.DiemThi };
            foreach (var x in v)
            {
                DataRow r = tb.NewRow();
                r["Mã Số"] = x.ID;
                r["Họ Tên"] = x.HoTen;
                //singleordefault??
                r["Điểm BT"] = x.DiemBT;
                r["Điểm GK"] = x.DiemGK;
                r["Điểm Thi"] = x.DiemThi;
                tb.Rows.Add(r);
            }
            return tb;
        }

    }
}
