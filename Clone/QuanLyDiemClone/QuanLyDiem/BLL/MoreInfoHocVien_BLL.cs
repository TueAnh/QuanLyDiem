using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    public class MoreInfoHocVien_BLL
    {
        DAL.MoreInfoHocVien_DAL more = new DAL.MoreInfoHocVien_DAL();
        public List<string> getMoreInfoHV_BLL(string MaHV)
        {
            return more.getMoreInfoHV_DAL(MaHV);
        }
    }
}
