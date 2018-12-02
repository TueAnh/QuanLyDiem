using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.DAL
{
    public class Login_DAL
    {
        private static Login_DAL dAL;

        public static Login_DAL DAL {
            get => dAL == null? dAL = new Login_DAL():  dAL;
            private set => dAL = value; }
        private Login_DAL() { }
       
        public int CheckLogin(string ID, string pass)
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                if (ID.Contains("HV"))
                {
                    var res = from p in DB.HocVien
                              where p.ID == ID && p.Password == pass
                              select p.ID;
                    if (res.ToList().Count() == 0) return -1;
                    return 1;
                }
                if (ID.Contains("GV"))
                {
                    var res = (from p in DB.GiangVien
                               where p.ID == ID && p.Password == pass
                               select p.ID);
                    if (res.ToList().Count() == 0) return -1;
                    return 2;
                }
                if (ID.Contains("DT"))
                {
                    var res = from p in DB.GiangVien
                              where p.ID == ID && p.Password == pass
                              select p.ID;
                    if (res.ToList().Count() == 0) return -1;
                    return 3;
                }
            }
            return -1;
        }
        public User GetUser(int flag,string ID)
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                if (flag == 1)
                {
                    var res = DB.HocVien.Find(ID);
                    return new User
                    {
                      ID = res.ID,
                      PassWord = res.Password,
                      displayName =  res.HoTen,
                      typeAcc = flag,
                      DiaChi = res.DiaChi,
                      NgaySinh = Convert.ToDateTime(res.NgaySinh.ToString()),
                      Email = res.Email,
                      DienThoai = res.DienThoai
                    };                             
                }
                else
                {
                    var res = DB.GiangVien.Find(ID);
                    return new User
                    {
                        ID = res.ID,
                        PassWord = res.Password,
                        displayName = res.HoTen,
                        typeAcc = flag,
                        DiaChi = res.DiaChi,
                        NgaySinh = Convert.ToDateTime(res.NgaySinh.ToString()),
                        Email = res.Email,
                        DienThoai = res.DienThoai
                    };
                }
            }
        }
        
    }
}
