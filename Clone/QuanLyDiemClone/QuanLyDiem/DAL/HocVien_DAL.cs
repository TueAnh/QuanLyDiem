using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
	public class HocVien_DAL
	{
		QuanLyDiemEntities db = new QuanLyDiemEntities();
		//public string getHVDAL(string str)
		//{
		//    var v = from s in db.HocVien
		//            where s.ID == str
		//            select s.HoTen;
		//    return v.SingleOrDefault();
		//}
		public HocVien getHVDAL(string str)
		{
			var v = from s in db.HocVien
					where s.ID == str
					select s;
			return v.SingleOrDefault();
		}

		public dynamic getDTBvXLDAL(string str)
		{
			DataTable tb = new DataTable();
			tb.Columns.Add("Học kì / Năm học");
			tb.Columns.Add("Tổng số tín chỉ");
			tb.Columns.Add("Điểm TBCT10");
			var v = from s in db.KetQuaHocPhan
					where s.ID == str
					orderby s.HocPhan.HocKy.NamHoc, s.HocPhan.MaHK
					select s;
			int ttc = 0, tc = 0, key = 1;
			double dtbT10 = 0, dtbm = 0;
			string mhk = "", hk = "", nh = "";
			foreach (var x in v)
			{
				if (mhk != x.HocPhan.MaHK)
				{
					if (nh != "")
					{
						DataRow r = tb.NewRow();
						r["Học kì / Năm học"] = hk + " Năm học " + nh;
						r["Tổng số tín chỉ"] = ttc;
						dtbT10 = Math.Round(dtbT10 / ttc, 2);
						if (key == 0)
							r["Điểm TBCT10"] = " ";
						else
							r["Điểm TBCT10"] = dtbT10;
						tb.Rows.Add(r);
						key = 1;
					}
					nh = x.HocPhan.HocKy.NamHoc + "-" + (Convert.ToInt32(x.HocPhan.HocKy.NamHoc) + 1).ToString();
					mhk = x.HocPhan.MaHK;
					hk = x.HocPhan.HocKy.TenHK;
					tc = Convert.ToInt32(x.HocPhan.SoTC);
					if (x.DiemGK == null || x.DiemThi == null || x.DiemBT == null)
						key = 0;
					dtbm = Convert.ToDouble(x.DiemBT) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
						+ Convert.ToDouble(x.DiemGK) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
						+ Convert.ToDouble(x.DiemThi) * Convert.ToDouble(x.HocPhan.PhanTramDT);
					dtbT10 = dtbm * tc;
					ttc = tc;
				}
				else
				{
					tc = Convert.ToInt32(x.HocPhan.SoTC);
					dtbm = Convert.ToDouble(x.DiemBT) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
						+ Convert.ToDouble(x.DiemGK) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
						+ Convert.ToDouble(x.DiemThi) * Convert.ToDouble(x.HocPhan.PhanTramDT);
					dtbT10 += dtbm * tc;
					ttc += tc;
				}
			}
			if (v.Count() > 0)
			{
				DataRow rr = tb.NewRow();
				rr["Học kì / Năm học"] = hk + " Năm học " + nh;
				rr["Tổng số tín chỉ"] = tc;
				dtbT10 = Math.Round(dtbT10 / ttc, 2);
				if (key == 0)
					rr["Điểm TBCT10"] = " ";
				else
					rr["Điểm TBCT10"] = dtbT10;
				tb.Rows.Add(rr);
			}
			return tb;
		}

		public List<int> loadCBBNHDAL(string str)
		{
			db = new QuanLyDiemEntities();
			List<int> list = new List<int>();
			var v = from s in db.KetQuaHocPhan
					where s.ID == str
					orderby s.HocPhan.HocKy.NamHoc, s.HocPhan.MaHK
					select s.HocPhan.HocKy.NamHoc;
			foreach (var x in v)
			{
				list.Add(Convert.ToInt32(x));
			}
			return list;
		}

		public List<string> loadCBBHKDAL(string str)
		{
			List<string> list = new List<string>();
			var v = from s in db.KetQuaHocPhan
					where s.ID == str
					orderby s.HocPhan.HocKy.NamHoc, s.HocPhan.MaHK
					select s.HocPhan.HocKy.TenHK;
			return v.ToList();
		}

		public dynamic getDiemQTDAL(string str)
		{
			db.Dispose();
			db = new QuanLyDiemEntities();
			DataTable tb = new DataTable();
			tb.Columns.Add("Học kì / Năm học");
			tb.Columns.Add("Mã học phần");
			tb.Columns.Add("Tên học phần");
			tb.Columns.Add("Số TC");
			tb.Columns.Add("Điểm BT");
			tb.Columns.Add("Điểm GK");
			tb.Columns.Add("Điểm Thi");
			tb.Columns.Add("Điểm TB");
			var v = from s in db.KetQuaHocPhan
					where s.ID == str
					orderby s.HocPhan.HocKy.NamHoc, s.HocPhan.MaHK
					select s;
			string hknh = "", check = "";
			foreach (var x in v)
			{

				double dtbm;
				DataRow r = tb.NewRow();
				hknh = x.HocPhan.HocKy.TenHK + " Năm học " + x.HocPhan.HocKy.NamHoc + " - " + (x.HocPhan.HocKy.NamHoc + 1);
				if (check != hknh)
				{
					r["Học kì / Năm học"] = check = hknh;
				}
				else
				{
					r["Học kì / Năm học"] = "";
				}
				r["Mã học phần"] = x.MaHP.Trim();
				r["Tên học phần"] = x.HocPhan.TenHP;
				r["Số TC"] = x.HocPhan.SoTC;
				r["Điểm BT"] = x.DiemBT;
				r["Điểm GK"] = x.DiemGK;
				r["Điểm Thi"] = x.DiemThi;
				dtbm = Convert.ToDouble(x.DiemBT) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
						+ Convert.ToDouble(x.DiemGK) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
						+ Convert.ToDouble(x.DiemThi) * Convert.ToDouble(x.HocPhan.PhanTramDT);
				if (x.DiemThi == null || x.DiemGK == null || x.DiemBT == null)
					r["Điểm TB"] = " ";
				else
					r["Điểm TB"] = Math.Round(dtbm, 2);
				tb.Rows.Add(r);
			}

			return tb;
		}

		public dynamic getDiemNHDAL(string str, int nh)
		{

			DataTable tb = new DataTable();

			tb.Columns.Add("Học kì");
			tb.Columns.Add("Mã học phần");
			tb.Columns.Add("Tên học phần");
			tb.Columns.Add("Số TC");
			tb.Columns.Add("Điểm BT");
			tb.Columns.Add("Điểm GK");
			tb.Columns.Add("Điểm Thi");
			tb.Columns.Add("Điểm TB");
			var v = from s in db.KetQuaHocPhan
					where (s.ID == str && s.HocPhan.HocKy.NamHoc == nh)
					orderby s.HocPhan.HocKy.NamHoc, s.HocPhan.MaHK
					select s;
			string hknh = "", check = "";
			foreach (var x in v)
			{
				double dtbm;
				DataRow r = tb.NewRow();
				hknh = x.HocPhan.HocKy.TenHK;
				if (check != hknh)
				{
					r["Học kì"] = check = hknh;
				}
				else
				{
					r["Học kì"] = "";
				}
				r["Mã học phần"] = x.MaHP.Trim();
				r["Tên học phần"] = x.HocPhan.TenHP;
				r["Số TC"] = x.HocPhan.SoTC;
				r["Điểm BT"] = x.DiemBT;
				r["Điểm GK"] = x.DiemGK;
				r["Điểm Thi"] = x.DiemThi;
				dtbm = Convert.ToDouble(x.DiemBT) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
						+ Convert.ToDouble(x.DiemGK) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
						+ Convert.ToDouble(x.DiemThi) * Convert.ToDouble(x.HocPhan.PhanTramDT);
				if (x.DiemThi == null || x.DiemGK == null || x.DiemBT == null)
					r["Điểm TB"] = " ";
				else
					r["Điểm TB"] = Math.Round(dtbm, 2);
				tb.Rows.Add(r);
			}
			return tb;
		}

		public dynamic getDiemHKDAL(string str, int nh, string hk)
		{
			DataTable tb = new DataTable();
			tb.Columns.Add("Mã học phần");
			tb.Columns.Add("Tên học phần");
			tb.Columns.Add("Số TC");
			tb.Columns.Add("Điểm BT");
			tb.Columns.Add("Điểm GK");
			tb.Columns.Add("Điểm Thi");
			tb.Columns.Add("Điểm TB");
			var v = from s in db.KetQuaHocPhan
					where (s.ID == str && s.HocPhan.HocKy.NamHoc == nh && s.HocPhan.HocKy.TenHK == hk)
					orderby s.HocPhan.HocKy.NamHoc, s.HocPhan.MaHK
					select s;
			string hknh = "", check = "";
			foreach (var x in v)
			{
				double dtbm;
				DataRow r = tb.NewRow();
				r["Mã học phần"] = x.MaHP.Trim();
				r["Tên học phần"] = x.HocPhan.TenHP;
				r["Số TC"] = x.HocPhan.SoTC;
				r["Điểm BT"] = x.DiemBT;
				r["Điểm GK"] = x.DiemGK;
				r["Điểm Thi"] = x.DiemThi;
				dtbm = Convert.ToDouble(x.DiemBT) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
						+ Convert.ToDouble(x.DiemGK) * Convert.ToDouble(x.HocPhan.PhanTramDGK)
						+ Convert.ToDouble(x.DiemThi) * Convert.ToDouble(x.HocPhan.PhanTramDT);
				if (x.DiemThi == null || x.DiemGK == null || x.DiemBT == null)
					r["Điểm TB"] = " ";
				else
					r["Điểm TB"] = Math.Round(dtbm, 2);
				tb.Rows.Add(r);
			}
			return tb;
		}
		public string GetTenLop(string str)
		{
			var v = from s in db.HocVien
					where s.ID == str
					select s.LopDaoTao.TenLop;
			return v.SingleOrDefault();
		}

	}
}

