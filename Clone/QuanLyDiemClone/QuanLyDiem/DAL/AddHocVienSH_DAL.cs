using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    class AddHocVienSH_DAL
    {
        public bool AddHVSH_DAL(HocVien hv)
        {
            try
            {
                using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
                {
                    DB.HocVien.Add(hv);
                    DB.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
