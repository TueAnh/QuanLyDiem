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
		QuanLyDiemEntitiess db = new QuanLyDiemEntitiess();
		public List<int> getNodeDAL()// Lấy năm học
		{
			List<int> str = new List<int>();
			var hk = (from s in db.HocKies
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
			tb.Columns.Add("Số tiết LT");
			tb.Columns.Add("Số tiết TH");
			tb.Columns.Add("Phần trăm DKT");
			tb.Columns.Add("Phần trăm DT");
			var v = from s in db.HocPhans
					where s.HocKy.TenHK == hk && s.HocKy.NamHoc == nh
					select new { s.MaHP, s.TenHP, s.SoTC, s.SoTietLT, s.SoTietTH, s.PhanTramDKT, s.PhanTramDT };
			foreach (var x in v)
			{
				DataRow r = tb.NewRow();
				r["Mã HP"] = x.MaHP.Trim();
				r["Tên HP"] = x.TenHP;
				r["Số TC"] = x.SoTC;
				r["Số tiết LT"] = x.SoTietLT;
				r["Số tiết TH"] = x.SoTietTH;
				r["Phần trăm DKT"] = x.PhanTramDKT;
				r["Phần trăm DT"] = x.PhanTramDT;
				tb.Rows.Add(r);
			}
			return tb;
		}
	}
}
