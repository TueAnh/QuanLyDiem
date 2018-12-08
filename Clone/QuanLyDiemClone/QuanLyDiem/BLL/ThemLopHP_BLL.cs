using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    class ThemLopHP_BLL
    {
        ThemLopHP_DAL dal = new ThemLopHP_DAL();
        public void ThemHP_BLL(string maHP, string tenHP, int soTC, int soTiet, double phanTramDGK, double phanTramDT, string maHK, string iD)
        {
            dal.ThemHP_DAL(maHP,tenHP,soTC,soTiet,phanTramDGK,phanTramDT,maHK,iD);
        }
        public void loadGV_BLL(List<string> lID, List<string> lHoTen)
        {
            dal.loadGV_DAL(lID,lHoTen);
        }
        public void loadHK_NH_BLL(List<string> lMaHK, List<string> lTenHK, List<string> lNamHoc)
        {
            dal.loadHK_NH_DAL(lMaHK, lTenHK, lNamHoc);
        }
        public bool ChecKExistHP_BLL(string maHP)
        {
            return dal.ChecKExistHP_DAL(maHP);
        }
        public HocPhan GetHocPhan(string ID, ref string x, ref string y)
        {
            return dal.GetHocPhan(ID,ref x,ref y);
        }
        public bool UpdateHP(HocPhan hp, string MaGV, string MaHK)
        {
            return dal.UpdateHP(hp, MaGV, MaHK);
        }
    }
}
