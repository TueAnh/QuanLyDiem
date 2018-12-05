using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    class AddHocVienSH_DAL
    {
        public void AddHVSH_DAL(HocVien hv)
        {
            using(QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                DB.HocVien.Add(hv);
                DB.SaveChanges();
            }
        }
    }
}
