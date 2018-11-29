using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    public class ViewLopDT_BLL
    {
        private static ViewLopDT_BLL bLL;
        public static ViewLopDT_BLL BLL
        {
            get => (bLL == null) ? bLL = new ViewLopDT_BLL() : bLL;
            set => bLL = value;
        }
        private ViewLopDT_BLL() { }

        public List<string> getNodeBLL()
        {
            return DAL.ViewLopDT_DAL.DAL.getNodeDAL();
        }

        public dynamic getTbLopDTBLL(string str)
        {
            return DAL.ViewLopDT_DAL.DAL.getTbLopDTDAL(str);
        }

    }
}

