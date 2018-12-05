using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiem.DAL;

namespace QuanLyDiem.BLL
{
	class ThemLopCH_BLL
	{
		ThemLopCH_DAL dAL = new ThemLopCH_DAL();

		public dynamic getSoLopBLL()
		{
			return dAL.getSoLopDAL();
		}

		public dynamic getMaKhoaBLL(string tenKhoa)
		{
			return dAL.getMaKhoaDAL(tenKhoa);
		}

		public dynamic checkMaKhoaBLL(string tenLop)
		{
			return dAL.checkLopDAL(tenLop);
		}

		public void getAddLopBLL(LopDaoTao lop)
		{
			dAL.addLopDAL(lop);
		}
	}
}
