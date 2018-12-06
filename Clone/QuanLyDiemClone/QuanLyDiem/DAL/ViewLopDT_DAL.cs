using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    public class ViewLopDT_DAL
    {
        QuanLyDiemEntities db = new QuanLyDiemEntities();
        private static ViewLopDT_DAL dAL;

        public static ViewLopDT_DAL DAL
        {
            get => dAL == null ? dAL = new ViewLopDT_DAL() : dAL;
            private set => dAL = value;
        }
        private ViewLopDT_DAL() { }

        public List<string> getNodeDAL()
        {
            List<string> st = new List<string>();
            var kHOA = from s in db.Khoa select s.TenKhoa;
            foreach (var x in kHOA)
            {
                st.Add(x);
            }
            return st;
        }

        public dynamic getTbLopDTDAL(string str)
        {
            DataTable tb = new DataTable();
            tb.Columns.Add("Mã Lớp");
            tb.Columns.Add("Tên Lớp");
            var v = from s in db.LopDaoTao
                    where s.Khoa.TenKhoa == str
                    select new { s.MaLop, s.TenLop };
            //foreach(var x in v)
            //{
            //	DataRow r = tb.NewRow();
            //	r["Mã Lớp"] = x.MaLop;
            //	r["Tên Lớp"] = x.TenLop;
            //	tb.Rows.Add(r);
            //}
            return v.ToList();
        }
        public bool DelObject_DAL(string ID)
        {
            try
            {
                using (QuanLyDiemEntities db = new QuanLyDiemEntities())
                {
                    db.LopDaoTao.Remove(db.LopDaoTao.Find(ID));
                    db.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
            
        }
    }
}
