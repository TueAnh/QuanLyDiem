using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    class SuaDiemHocVienDT_BLL
    {
        DAL.SuaDiemHocVienDT_DAL dAL = new DAL.SuaDiemHocVienDT_DAL();

        public void suaDiemHocVien_BLL(string MaHV, string MaHP, double bt, double gk, double thi)
        {
            dAL.suaDiemHocVien_DAL(MaHV, MaHP, bt, gk, thi);
        }
        public KetQuaHocPhan GetDiem_BLL(string MaHV, string MaHP)
        {
            return dAL.GetDiem_DAL(MaHV, MaHP);
        }
        public DateTime getHanNhapDiem_DAL(string MaHP)
        {
            return dAL.getHanNhapDiem_DAL(MaHP);
        }
        public bool HanNhapDiemGiuaKi_BLL(string MaHP)
        {
            return dAL.HanNhapDiemGiuaKi_DAL(MaHP);
        }
        public bool HanNhapDiemThi_BLL(string MaHP)
        {
            return dAL.HetHanNhapDiemThi_DAL(MaHP);
        }
        public bool Check_TMP(string MaHP)
        {
            return dAL.Check_TMP(MaHP);
        }
    }
}
