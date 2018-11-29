    using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.BLL
{
    public class Login_BLL
    {
        private static Login_BLL bLL;
        public static Login_BLL BLL {           
            get => (bLL == null)? bLL = new Login_BLL(): bLL;
            set => bLL = value; }
        private Login_BLL() { }
        public int CheckLogin(string ID, string pass)
        {          
            return Login_DAL.DAL.CheckLogin(ID, pass); ;
        }
        public User GetUser(int flag, string ID)
        {
            return Login_DAL.DAL.GetUser(flag, ID);
        }
        
        public IEnumerable<HocVien> GetList()
        {
            return Login_DAL.DAL.GetList();
        }
        
        public List<TreeNode> GetNode()
        {
            return Login_DAL.DAL.GetNode();
        }
        public dynamic GetListHP(string ID, string HocKy, string NamHoc)
        {
            return Login_DAL.DAL.GetListHP(ID, HocKy, Convert.ToInt32(NamHoc));
        }
        public dynamic GetListHV(string MaHP)
        {
            return Login_DAL.DAL.GetListHV(MaHP);
        }
    }
}
