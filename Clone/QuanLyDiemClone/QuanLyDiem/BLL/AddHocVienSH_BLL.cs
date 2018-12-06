using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    class AddHocVienSH_BLL
    {
        AddHocVienSH_DAL dal = new AddHocVienSH_DAL();
        public bool AddHVSH_BLL(HocVien hv)
        {
            return dal.AddHVSH_DAL(hv);
        }
    }
}
