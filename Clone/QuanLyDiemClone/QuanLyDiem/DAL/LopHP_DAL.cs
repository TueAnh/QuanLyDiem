using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

		public DataTable getDSHVDAL2(string str)// lấy danh sách Học Viên
		{
			DataTable tb = new DataTable();
			tb.Columns.Add("Mã HV");
			tb.Columns.Add("Họ tên");
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
				r["Họ tên"] = x.HocVien.HoTen.Trim();
				//singleordefault??
				r["Điểm BT"] = x.DiemBT;
				r["Điểm GK"] = x.DiemGK;
				r["Điểm Thi"] = x.DiemThi;
                if (x.DiemThi.ToString().Trim().Length > 0)
                    r["Điểm TB"] = Convert.ToDouble(x.DiemBT) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
                        + Convert.ToDouble(x.DiemGK) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
                        + Convert.ToDouble(x.DiemThi) * Convert.ToDouble(x.HocPhan.PhanTramDT);
                else
                    r["Điểm TB"] = "";

                tb.Rows.Add(r);
			}
			return tb;
		}

		public GiangVien getGVDAL(string str)// Lấy tên giảng viên phụ trách
		{
			var v = from s in db.HocPhan
					where s.MaHP == str
					select s.GiangVien;
			return v.SingleOrDefault();
		}
		public string getTenKhoaDAL(string maHP)
		{
			var v = from s in db.HocPhan
					where s.MaHP == maHP
					select s.GiangVien.Khoa.TenKhoa;
			return v.SingleOrDefault();
		}
		public string getTenHPDAL(string maHP)
		{
			var v = from s in db.HocPhan
					where s.MaHP == maHP
					select s.TenHP;
			return v.SingleOrDefault();
		}
		public dynamic getSoTCDAL(string maHP)
		{
			var v = from s in db.HocPhan
					where s.MaHP == maHP
					select s.SoTC;
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
		public int UpdateKQHP(KetQuaHocPhan kq, string MaHV, string MaHP)
		{
			try
			{
				using (QuanLyDiemEntities db = new QuanLyDiemEntities())
				{
					//if (!HanNhapDiemGiuaKi_DAL(MaHP))
					//{
					//    kq.DiemGK = null;
					//    kq.DiemBT = null;
					//}

					//if (!HetHanNhapDiemThi_DAL(MaHP))
					//    kq.DiemThi = null;
					bool flag = false, flag2 = false;
					KetQuaHocPhan ketQuaHocPhan = db.KetQuaHocPhan.Where(p => p.ID == MaHV && p.MaHP == MaHP).Select(p => p).SingleOrDefault();
					if (ketQuaHocPhan == null)
					{
						flag = true;
						flag2 = true;
						ketQuaHocPhan = kq;
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

						ketQuaHocPhan.MaKQHP = x;
						ketQuaHocPhan.ID = db.HocVien.Find(MaHV).ID;
						ketQuaHocPhan.MaHP = db.HocPhan.Find(MaHP).MaHP;

					}
					else
					{
						if (db.HocVien.Find(MaHV) == null ||
						   db.HocPhan.Find(MaHP) == null)
							return -1;
					}
					if (ketQuaHocPhan.DiemBT != kq.DiemBT)
					{
						flag = true;
						ketQuaHocPhan.DiemBT = kq.DiemBT;
					}
					if (ketQuaHocPhan.DiemGK != kq.DiemGK)
					{
						flag = true;
						ketQuaHocPhan.DiemGK = kq.DiemGK;
					}
					if (ketQuaHocPhan.DiemThi != kq.DiemThi)
					{
						flag = true;
						ketQuaHocPhan.DiemThi = kq.DiemThi;
					}
					if (flag2)
						db.KetQuaHocPhan.Add(ketQuaHocPhan);
					db.SaveChanges();
					if (flag == true)
						return 1;
					return 0;
				}

			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString());
				return -1;
			}
		}
		public bool XoaHV(string ID, string MaHP)
		{
			try
			{
				using (QuanLyDiemEntities db = new QuanLyDiemEntities())
				{
					KetQuaHocPhan kq = db.KetQuaHocPhan.Where(p => p.ID == ID && p.MaHP == MaHP).Select(p => p).SingleOrDefault();
					if (kq != null)
						db.KetQuaHocPhan.Remove(kq);
					db.SaveChanges();
				}
			}
			catch
			{
				return false;
			}
			return true;
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
	}
}
