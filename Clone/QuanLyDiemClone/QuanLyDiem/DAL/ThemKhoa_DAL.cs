using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    class ThemKhoa_DAL
    {
        public void themKhoa_DAL(Khoa k)
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                DB.Khoa.Add(k);
                DB.SaveChanges();
            }
        }
        public bool ChecKExistKHoa_DAL(string maKhoa)
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                var v = DB.Khoa.Select(s => s).Where(s => s.MaKhoa.Trim() == maKhoa).Count();
                return Convert.ToInt16(v) > 0;
            }
        }
    }
}
