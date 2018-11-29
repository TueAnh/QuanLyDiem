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
		QuanLyDiemEntitiess db = new QuanLyDiemEntitiess();// khởi tạo đối tượng Entity giao tiếp trực tiếp với csdl

		public dynamic getDSHVDAL(string str)// lấy danh sách Học Viên
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

			var v = from s in db.KetQuaHocPhans
					where s.MaHP == str
					select new { s.ID,s.HocVien.HoTen,s.DiemBT, s.DiemGK, s.DiemThi };
			//foreach (var x in v)
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
			
		public string getGVDAL(string str)// Lấy tên giảng viên phụ trách
		{
			var v = from s in db.HocPhans
					where s.MaHP == str
					select s.GiangVien.HoTen;
			return v.SingleOrDefault();
		}

		public dynamic getDSSearchDAL(string str, string MaHP)
		{

			var v = from s in db.KetQuaHocPhans
					where (s.HocVien.ID.Contains(str) || s.HocVien.HoTen.Contains(str)) && (s.MaHP == MaHP)
					select new { s.ID, s.HocVien.HoTen, s.DiemBT, s.DiemGK, s.DiemThi };
			return v.ToList();
		}

	}
}
