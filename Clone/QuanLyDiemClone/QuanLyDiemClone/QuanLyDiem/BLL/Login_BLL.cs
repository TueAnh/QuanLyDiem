using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void LoadInfo()
        {
            
        }
    }
}
