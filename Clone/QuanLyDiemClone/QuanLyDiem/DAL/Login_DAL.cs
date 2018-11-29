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
        public List<TreeNode> GetNode()
        {
            List<TreeNode> list = new List<TreeNode>();
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                //var res = DB.Khoa.Select(p => p.TenKhoa);
                var res = DB.HocKy.Select(q => new {TenHK = q.TenHK, NamHoc = q.NamHoc}).ToList().Select
                    (p => new HocKy {TenHK =  p.TenHK, NamHoc = p.NamHoc}).ToList();
                List<TreeNode> tmp = new List<TreeNode>();
                foreach(HocKy s in res)
                {
                    tmp.Add(new TreeNode(s.TenHK +" năm học " + s.NamHoc.ToString() +" - "+(s.NamHoc + 1).ToString()));
                }
                
                //Console.ReadKey();
                list.Add(new TreeNode("Học kì", tmp.ToArray()));
                return list;
            }
        }
        public dynamic GetListHP(string ID, string HocKy, int NamHoc)
        {
            //List<string> list = new List<string>();
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                var res = DB.HocKy.Where(p => p.TenHK == HocKy && p.NamHoc == NamHoc).
                    Select(p => p.MaHK).FirstOrDefault();
                var resu = (DB.HocPhan.Where(p => p.ID == ID && p.MaHK == res.ToString().Trim()).
                    Select(p => new { p.MaHP, p.TenHP})).ToList();
                return resu;
            }
            //return list;
        }
        public dynamic GetListHV(string MaHP)
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                var res = DB.KetQuaHocPhan.Where(p => p.MaHP == MaHP)
                    .Select(p => new { p.ID, p.HocVien.HoTen, p.HocVien.LopDaoTao.TenLop, p.DiemBT, p.DiemGK, p.DiemThi }).ToList();
                return res;
            }
        }
       
        public IEnumerable<HocVien> GetList()
        {
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                var res = (from p in DB.HocVien
                           select new {ID = p.ID }).ToList().Select
                           (x => new HocVien { ID =  x.ID });
                return res;
            }
        }
        
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
                      typeAcc = flag
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
                        typeAcc = flag
                    };
                }
            }
        }
    }
}
