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
        public void luuAnh_DAL(string ID,byte[] a)
        {
            using (QuanLyDiemEntities db = new QuanLyDiemEntities())
            {
                HocVien img = (from c in db.HocVien
                                               where c.ID == ID
                                               select c).SingleOrDefault();
                img.Image = a;
                db.SaveChanges();
            }
        }
        public byte[] TaiAnh_DAL(string ID)
        {
            using (QuanLyDiemEntities db = new QuanLyDiemEntities())
            {
                HocVien img = (from c in db.HocVien
                                 where c.ID == ID
                                 select c).SingleOrDefault();
                if (img == null) return null;
                else return (byte[])img.Image;
            }
        }
    }
}
