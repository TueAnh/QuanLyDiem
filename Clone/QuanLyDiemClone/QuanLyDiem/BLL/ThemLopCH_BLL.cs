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

		public dynamic checkTenLopBLL(string tenLop)
		{
			return dAL.checkTenLopDAL(tenLop);
		}

		public void getAddLopBLL(LopDaoTao lop)
		{
			dAL.addLopDAL(lop);
		}
        public bool checkMaLopBLL(string malop)
        {
            return dAL.checkMaLopDAL(malop);
        }

    }
}
