using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    class SearchGiangVien_BLL
    {
        SearchGiangVien_DAL dAL = new SearchGiangVien_DAL();

        public dynamic getDSGVBLL()
        {
            return dAL.getDSGVDAL();
        }
    }
}
