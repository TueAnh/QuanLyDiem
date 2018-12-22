using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    class ThemGiangVien_DAL
    {
        QuanLyDiemEntities db = new QuanLyDiemEntities();

        public void addGiangVienDAL(GiangVien gv)
        {
            db.GiangVien.Add(gv);
            db.SaveChanges();
        }

        public dynamic getMaKhoaDAL(string tenKhoa)
        {
            var v = from s in db.Khoa
                    where s.TenKhoa == tenKhoa
                    select s.MaKhoa;

            return v.SingleOrDefault();
        }

        public dynamic checkGVDAL(string maGV)
        {
            var v = from s in db.GiangVien
                    where s.ID == maGV
                    select s;
            if (v.Count() == 0)
                return true;
            return false;
        }

        public dynamic checkKhoaDAL(string tenKhoa)
        {
            var v = from s in db.Khoa
                    where s.TenKhoa == tenKhoa
                    select s;
            if (v.Count() == 0)
                return false;
            return true;
        }

		public dynamic getDSKhoaDAL()
		{
			var v = from s in db.Khoa
					orderby s.TenKhoa
					select s.TenKhoa;
			return v.ToList();
		}
    }
}
