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
		QuanLyDiemEntitiess db = new QuanLyDiemEntitiess();
		public dynamic getDSHVDAL(string str)// lấy bảng danh sách các học viên của lớp đào tạo từ csdl
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
					select new{s.ID,s.HoTen,s.Email,s.DiaChi,s.DienThoai,s.NgaySinh};
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

		public dynamic getDSSearchDAL(string str1 , string str2, string MaLop)
		{
			
			var v = from s in db.HocViens
					where (s.ID.Contains(str2) || s.HoTen.Contains(str2)) && (s.MaLop == MaLop)
					select new { s.ID, s.HoTen, s.Email, s.DiaChi, s.DienThoai, s.NgaySinh };
			return v.ToList();
		}

	}
}
