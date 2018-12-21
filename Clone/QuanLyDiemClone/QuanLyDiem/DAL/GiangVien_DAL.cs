using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.DAL
{
    class GiangVien_DAL
    {
        private static GiangVien_DAL dAL;

        public static GiangVien_DAL DAL
        {
            get => dAL == null ? dAL = new GiangVien_DAL() : dAL;
            private set => dAL = value;
        }
        private GiangVien_DAL() { }
        public List<TreeNode> GetNode()
        {
            List<TreeNode> list = new List<TreeNode>();
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                
                var res = DB.HocKy.Select(q => new { TenHK = q.TenHK, NamHoc = q.NamHoc }).ToList().Select
                    (p => new HocKy { TenHK = p.TenHK, NamHoc = p.NamHoc }).OrderBy(p => p.NamHoc).ToList();
                List<TreeNode> tmp = new List<TreeNode>();
                foreach (HocKy s in res)
                {
                    tmp.Add(new TreeNode(s.TenHK + " năm học " + s.NamHoc.ToString() + " - " + (s.NamHoc + 1).ToString()));
                }

                //Console.ReadKey();
                list.Add(new TreeNode("Học kì", tmp.ToArray()));
                return list;
            }
        }
        public List<TreeNode> GetNodeByGV(string ID)
        {
            List<TreeNode> list = new List<TreeNode>();
            using (QuanLyDiemEntities DB = new QuanLyDiemEntities())
            {
                var res = DB.HocPhan.Where(p => p.ID == ID).Select(q => new { TenHK = q.HocKy.TenHK, NamHoc = q.HocKy.NamHoc }).ToList().Select
                    (p => new HocKy { TenHK = p.TenHK, NamHoc = p.NamHoc }).OrderBy(p => p.NamHoc).ToList();
                List<TreeNode> tmp = new List<TreeNode>();
                foreach (HocKy s in res)
                {
                    tmp.Add(new TreeNode(s.TenHK + " năm học " + s.NamHoc.ToString() + " - " + (s.NamHoc + 1).ToString()));
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
                    Select(p => new { p.MaHP, p.TenHP })).ToList();
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
       
    }
}
