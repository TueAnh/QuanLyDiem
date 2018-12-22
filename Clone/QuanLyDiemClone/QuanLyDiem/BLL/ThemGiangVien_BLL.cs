using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    class ThemGiangVien_BLL
    {
        ThemGiangVien_DAL dAL = new ThemGiangVien_DAL();

        public void addGiangVienBLL(GiangVien gv)
        {
            dAL.addGiangVienDAL(gv);
        }

        public dynamic getMaKhoaBLL(string tenKhoa)
        {
            return dAL.getMaKhoaDAL(tenKhoa);
        }

        public dynamic checkGVBLL(string maGV)
        {
            return dAL.checkGVDAL(maGV);
        }

        public dynamic checkKhoaBLL(string tenKhoa)
        {
            return dAL.checkKhoaDAL(tenKhoa);
        }
		public dynamic getDSKhoaBLL()
		{
			return dAL.getDSKhoaDAL();
		}
    }
}
