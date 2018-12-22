using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    class ThemKhoa_BLL
    {
        ThemKhoa_DAL dal = new ThemKhoa_DAL();
        public void themKhoa_BLL(Khoa k)
        {
            dal.themKhoa_DAL(k);
        }
        public bool ChecKExistKHoa_BLL(string maKhoa)
        {
            return dal.ChecKExistKHoa_DAL(maKhoa);
        }

        public bool ChecKExistTenKHoa_BLL(string tenKhoa)
        {
            return dal.ChecKExistTenKHoa_DAL(tenKhoa);
        }
    }
}
