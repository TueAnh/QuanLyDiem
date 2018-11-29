using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            using (QuanLyDiemEntitiess DB = new QuanLyDiemEntitiess())
            {
                if (ID.Contains("HV"))
                {
                    var res = from p in DB.HocViens
                              where p.ID == ID && p.Password == pass
                              select p.ID;
                    if (res == null) return -1;
                    return 1;
                }
                if (ID.Contains("GV"))
                {
                    var res = (from p in DB.GiangViens
                               where p.ID == ID && p.Password == pass
                               select p.ID);
                    if (res == null) return -1;
                    return 2;
                }
                if (ID.Contains("DT"))
                {
                    var res = from p in DB.GiangViens
                              where p.ID == ID && p.Password == pass
                              select p.ID;
                    if (res == null) return -1;
                    return 3;
                }
            }
            return -1;
        }
        public void LoadInfo(int flag)
        {
            using (QuanLyDiemEntitiess DB = new QuanLyDiemEntitiess())
            {
                if (flag == 1)
                {
                    //var res = from p in DB.HocVien
                              
                }
                
            }
        }
    }
}
