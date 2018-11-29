using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    public class LopDT_BLL
    {
        public LopDT_DAL dAL;

        public LopDT_BLL()
        {
            dAL = new LopDT_DAL();
        }

        public dynamic getDSHVBLL(string str)
        {
            return dAL.getDSHVDAL(str);
        }
        public dynamic getDSSearchBLL(string str1, string str2, string Malop)
        {
            return dAL.getDSSearchDAL(str1, str2, Malop);
        }
    }
}
