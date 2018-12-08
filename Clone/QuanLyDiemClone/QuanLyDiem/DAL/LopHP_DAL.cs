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
        //QuanLyDiemEntities db = new QuanLyDiemEntities();// khởi tạo đối tượng Entity giao tiếp trực tiếp với csdl


        //public dynamic getDSHoHV(string str)
        //{
        //    List<string> Listho = new List<string>();
        //    var v = from s in db.KetQuaHocPhan
        //            where s.MaHP == str
        //            select s.HocVien.HoTen;
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
        //    var v = from s in db.KetQuaHocPhan
        //            where s.MaHP == str
        //            select s.HocVien.HoTen;

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
        //public dynamic getDSHVDAL(string str)// lấy danh sách Học Viên
        //{
        //    DataTable tb = new DataTable();
        //    tb.Columns.Add("Mã số");
        //    tb.Columns.Add("Họ");
        //    tb.Columns.Add("Tên");
        //    tb.Columns.Add("Điểm BT");
        //    tb.Columns.Add("Điểm GK");
        //    tb.Columns.Add("Điểm Thi");

        //    var v = from s in db.KetQuaHocPhan
        //            where s.MaHP == str
        //            select new { s.ID, s.HocVien.HoTen, s.DiemBT, s.DiemGK, s.DiemThi };
        //    List<string> ListTen = getDSTenHV(str);
        //    List<string> ListHo = getDSHoHV(str);
        //    int index = 0;

        //    foreach (var x in v)
        //    {
        //        DataRow r = tb.NewRow();
        //        r["Mã số"] = x.ID;
        //        r["Họ"] = ListHo[index];
        //        r["Tên"] = ListTen[index++];
        //        //SingleOrDefault??
        //        r["Điểm BT"] = x.DiemBT;
        //        r["Điểm GK"] = x.DiemGK;
        //        r["Điểm Thi"] = x.DiemThi;
        //        tb.Rows.Add(r);
        //    }
        //    return tb;
        //}

        //public string getGVDAL(string str)// Lấy tên giảng viên phụ trách
        //{
        //    var v = from s in db.HocPhan
        //            where s.MaHP == str
        //            select s.GiangVien.HoTen;
        //    return v.SingleOrDefault();
        //}


        QuanLyDiemEntities db = new QuanLyDiemEntities();// khởi tạo đối tượng Entity giao tiếp trực tiếp với csdl

        public DataTable getDSHVDAL(string str)// lấy danh sách Học Viên
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Mã HV");
            tb.Columns.Add("Họ");
            tb.Columns.Add("Tên");
            tb.Columns.Add("Điểm BT");
            tb.Columns.Add("Điểm GK");
            tb.Columns.Add("Điểm Thi");
            tb.Columns.Add("Điểm TB");
            //var v = from s in db.KetQuaHocPhans
            //		where s.ID == str
            //		select new { s.HocPhan.HocKy.NamHoc };

            var v = from s in db.KetQuaHocPhan
                    where s.MaHP == str
                    select s;
            foreach (var x in v)
            {
                DataRow r = tb.NewRow();
                r["Mã HV"] = x.ID;
                var name = x.HocVien.HoTen.ToString().Trim().Split(' ');
                for (int j = 0; j < name.Count() - 1; j++)
                    r["Họ"] += name[j] + " ";
                r["Tên"] = name[name.Count() - 1];
                //singleordefault??
                r["Điểm BT"] = x.DiemBT;
                r["Điểm GK"] = x.DiemGK;
                r["Điểm Thi"] = x.DiemThi;
                if (x.DiemThi.ToString().Trim().Length > 0)
                    r["Điểm TB"] = Convert.ToDouble(x.DiemBT) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
                        + Convert.ToDouble(x.DiemGK) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
                        + Convert.ToDouble(x.DiemThi) * Convert.ToDouble(x.HocPhan.PhanTramDT);
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
            tb.Columns.Add("Mã HV");
            tb.Columns.Add("Họ");
            tb.Columns.Add("Tên");
            tb.Columns.Add("Điểm BT");
            tb.Columns.Add("Điểm GK");
            tb.Columns.Add("Điểm Thi");
            tb.Columns.Add("Điểm TB");
            var v = from s in db.KetQuaHocPhan
                    where (s.HocVien.ID.Contains(str) || s.HocVien.HoTen.Contains(str)) && (s.MaHP == MaHP)
                    select s;
            foreach (var x in v)
            {
                DataRow r = tb.NewRow();
                r["Mã HV"] = x.ID;
                var name = x.HocVien.HoTen.ToString().Trim().Split(' ');
                for (int j = 0; j < name.Count() - 1; j++)
                    r["Họ"] += name[j] + " ";
                r["Tên"] = name[name.Count() - 1];
                //singleordefault??
                r["Điểm BT"] = x.DiemBT;
                r["Điểm GK"] = x.DiemGK;
                r["Điểm Thi"] = x.DiemThi;
                if (x.DiemThi.ToString().Trim().Length > 0)
                    r["Điểm TB"] = Convert.ToDouble(x.DiemBT) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
                        + Convert.ToDouble(x.DiemGK) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
                        + Convert.ToDouble(x.DiemThi) * Convert.ToDouble(x.HocPhan.PhanTramDT);
                tb.Rows.Add(r);
            }
            return tb;
        }

    }
}
