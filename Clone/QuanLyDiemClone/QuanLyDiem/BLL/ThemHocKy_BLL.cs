using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    class ThemHocKy_BLL
    {
        ThemHocKy_DAL dal = new ThemHocKy_DAL();
        public void ThemHK_BLL(string maHK, string tenHK, DateTime TgBatDau, DateTime TgKetThuc, int namHoc)
        {
            dal.ThemHK_DAL(maHK, tenHK, TgBatDau, TgKetThuc, namHoc);
        }
        public bool ChecKExistHK_BLL(string maHK)
        {
            return dal.ChecKExistHK_DAL(maHK);
        }
    }
}
