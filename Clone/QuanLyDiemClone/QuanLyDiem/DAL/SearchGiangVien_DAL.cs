using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    class SearchGiangVien_DAL
    {
        QuanLyDiemEntities db = new QuanLyDiemEntities();

        public dynamic getDSGVDAL()
        {
            DataTable tb = new DataTable();
            using (QuanLyDiemEntities db = new QuanLyDiemEntities())
            {
                var v = from c in db.GiangVien
                        select c;
                tb.Columns.Add("Mã GV");
                tb.Columns.Add("Họ");
                tb.Columns.Add("Tên");
                tb.Columns.Add("Khoa");
                foreach (var i in v)
                {
                    DataRow r = tb.NewRow();
                    string s = i.ID.ToString().Trim();
                    if (s[0] == 'D')// Bỏ xem nhân viên đào tạo
                        continue;
                    r["Mã GV"] = i.ID.ToString().Trim();
                    var name = i.HoTen.ToString().Trim().Split(' ');
                    for (int j = 0; j < name.Count() - 1; j++)
                        r["Họ"] += name[j] + " ";
                    r["Tên"] = name[name.Count() - 1];
                    r["Khoa"] = i.Khoa.TenKhoa.Trim();
                    tb.Rows.Add(r);
                }
            }
            return tb;
        }
        public bool XoaGV(string ID)
        {
            try
            {
                using (QuanLyDiemEntities db = new QuanLyDiemEntities())
                {
                    db.GiangVien.Remove(db.GiangVien.Find(ID));
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
