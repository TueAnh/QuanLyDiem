using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiem.DAL;

namespace QuanLyDiem.BLL
{
	class ThemHocVien_BLL
	{
		ThemHocVien_DAL dAL = new ThemHocVien_DAL();

        //public dynamic checkHocVienBLL(string MaHV)
        //{
        //	return dAL.checkHocVienDAL(MaHV);
        //}
        public dynamic checkHocVienBLL(string MaHV)
        {
            return dAL.checkHocVienDAL(MaHV);
        }
        //public dynamic getSoHocVienBLL()
        //{
        //	return dAL.getSoHocVienDAL();
        //}
        public dynamic getLopBLL(string tenLop)
        {
            return dAL.getLopDAL(tenLop);
        }
        public void addHVBLL(HocVien hv)
        {
            dAL.addHVDAL(hv);
        }
        public dynamic getSoHocVienBLL()
		{
			return dAL.getSoHocVienDAL();
		}
		//public dynamic getLopBLL(string tenLop)
		//{
		//	return dAL.getLopDAL(tenLop);
		//}
		//public void addHVBLL(HocVien hv)
		//{
		//	dAL.addHVDAL(hv);
		//}
        public bool CheckID_BLL(string ID)
        {
            return dAL.CheckID(ID);
        }

	}
}
