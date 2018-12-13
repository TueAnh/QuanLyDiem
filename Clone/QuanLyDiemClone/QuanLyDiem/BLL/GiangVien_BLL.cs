using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.BLL
{
    class GiangVien_BLL
    {
        private static GiangVien_BLL bLL;

        public static GiangVien_BLL BLL
        {
            get => bLL == null ? bLL = new GiangVien_BLL() : bLL;
            private set => bLL = value;
        }
        private GiangVien_BLL() { }
        public List<TreeNode> GetNode()
        {
            return GiangVien_DAL.DAL.GetNode();
        }
        public dynamic GetListHP(string ID, string HocKy, string NamHoc)
        {
            return GiangVien_DAL.DAL.GetListHP(ID, HocKy, Convert.ToInt32(NamHoc));
        }
        public dynamic GetListHV(string MaHP)
        {
            return GiangVien_DAL.DAL.GetListHV(MaHP);
        }
        
    }
}
