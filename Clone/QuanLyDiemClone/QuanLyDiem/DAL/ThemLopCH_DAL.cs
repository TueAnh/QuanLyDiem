using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
	class ThemLopCH_DAL
	{
		QuanLyDiemEntities db = new QuanLyDiemEntities();

		public dynamic getSoLopDAL()
		{
			var v = from s in db.LopDaoTao
					select s;
			return v.Count();
		}

		public dynamic getMaKhoaDAL(string tenKhoa)
		{
			var v = from s in db.Khoa
					where s.TenKhoa == tenKhoa
					select s.MaKhoa;
			return v.SingleOrDefault();
		}

		public dynamic checkLopDAL(string tenLop)
		{
			var v = from s in db.LopDaoTao
					where s.TenLop == tenLop
					select s;
			if (v.Count() == 0)
				return true;
			return false;
		}

		public void addLopDAL(LopDaoTao lop)
		{
			db.LopDaoTao.Add(lop);
			db.SaveChanges();
		}
	}
}
