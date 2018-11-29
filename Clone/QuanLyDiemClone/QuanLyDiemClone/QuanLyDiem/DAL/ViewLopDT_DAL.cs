using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
	public class ViewLopDT_DAL
	{
		QuanLyDiemEntitiess db = new QuanLyDiemEntitiess();
		private static ViewLopDT_DAL dAL;

		public static ViewLopDT_DAL DAL
		{
			get => dAL == null ? dAL = new ViewLopDT_DAL() : dAL;
			private set => dAL = value;
		}
		private ViewLopDT_DAL() { }

		public List<string> getNodeDAL()
		{
			List<string> st = new List<string>();
			var kHOA = from s in db.Khoas select s.TenKhoa;
			foreach (var x in kHOA)
			{
				st.Add(x);
			}
			return st;
		}

		public dynamic getTbLopDTDAL(string str)// lấy bảng các lớp đào tạo từ csdl
		{
			DataTable tb = new DataTable();
			tb.Columns.Add("Mã Lớp");
			tb.Columns.Add("Tên Lớp");
			var v = from s in db.LopDaoTaos
					where s.Khoa.TenKhoa == str
					select new { s.MaLop, s.TenLop };
			//foreach(var x in v)
			//{
			//	DataRow r = tb.NewRow();
			//	r["Mã Lớp"] = x.MaLop;
			//	r["Tên Lớp"] = x.TenLop;
			//	tb.Rows.Add(r);
			//}
			return v.ToList();
		}

		public dynamic getDSHVDAL(string str)// lấy danh sách học viên
		{
			//DataTable tb = new DataTable();
			//tb.Columns.Add("Mã số");
			//tb.Columns.Add("Họ tên");
			//tb.Columns.Add("Email");
			//tb.Columns.Add("Địa chỉ");
			//tb.Columns.Add("Điện thoại");
			//tb.Columns.Add("Ngày sinh");
			var v = from s in db.HocViens
					where s.MaLop == str
					select new { s.ID, s.HoTen, s.Email, s.DiaChi, s.DienThoai, s.NgaySinh };
			//foreach(var x in v)
			//{
			//	DataRow r = tb.NewRow();
			//	r["Mã số"] = x.ID;
			//	r["Họ tên"] = x.HoTen;
			//	r["Email"] = x.Email;
			//	r["Địa chỉ"] = x.DiaChi;
			//	r["Điện thoại"] = x.DienThoai;
			//	r["Ngày sinh"] = x.NgaySinh;
			//	tb.Rows.Add(r);
			//}
			return v.ToList();
		}

	}
}
