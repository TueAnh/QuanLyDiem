using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.DAL
{
    class UserInfo_DAL
    {
        private static UserInfo_DAL dAL;
        public static UserInfo_DAL DAL
        {
            get => (dAL == null) ? dAL = new UserInfo_DAL() : dAL;
            set => dAL = value;
        }
        private UserInfo_DAL() { }
        public bool UpdateUserHV(User user)
        {
            try
            {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
                        {
                            HocVien hocVien = DB.HocVien.Find(user.ID);
                            hocVien.NgaySinh = user.NgaySinh;
                            hocVien.Password = user.PassWord;
                            hocVien.DiaChi = user.DiaChi;
                            hocVien.DienThoai = user.DienThoai;
                            hocVien.Email = user.Email;
                            DB.SaveChanges();
                        }
                return true;
            }
            
            catch
            {
                return false;
            }
        }
        public bool UpdateUserGV(User user)
        {
            try
            {
                using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
                {
                    GiangVien giangVien = DB.GiangVien.Find(user.ID);
                    giangVien.NgaySinh = user.NgaySinh;
                    //GiangVien giangVien = DB.GiangVien.Where(p => p.ID == user.ID).Select(p => p).SingleOrDefault();
                    giangVien.Password = user.PassWord;
                    giangVien.DiaChi = user.DiaChi;
                    giangVien.DienThoai = user.DienThoai;
                    giangVien.Email = user.Email;
                    DB.SaveChanges();
                }
                
            }

            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
