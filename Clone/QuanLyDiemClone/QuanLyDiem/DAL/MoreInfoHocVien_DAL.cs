using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    class MoreInfoHocVien_DAL
    {
        QuanLyDiemEntities db = new QuanLyDiemEntities();
        public List<string> getMoreInfoHV_DAL(string MaHV)
        {
            List<string> ls = new List<string>();
            using (QuanLyDiemEntities db = new QuanLyDiemEntities())
            {
                var v = (from c in db.HocVien
                         where c.ID == MaHV
                         select c).SingleOrDefault();
                ls.Add(v.Password.ToString());

                ls.Add(v.NgaySinh.Value.ToString());

                ls.Add(v.Email.ToString());

                ls.Add(v.DienThoai.ToString());

                ls.Add(v.DiaChi.ToString());
                return ls;

            }
        }
    }
}
