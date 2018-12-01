using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    public class SearchHocVien_BLL
    {
        DAL.SearchHocVien_DAL Search_dal = new DAL.SearchHocVien_DAL();
        public DataTable LoadAllHocVien()
        {
            return Search_dal.LoadAllHocVien();
        }
        public DataTable LoadSearchedHocVien(string str)
        {
            return Search_dal.LoadSearchedHocVien(str);
        }
    }
}
