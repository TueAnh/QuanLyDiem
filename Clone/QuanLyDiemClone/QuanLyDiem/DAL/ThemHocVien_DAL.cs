using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
	class ThemHocVien_DAL
	{
		QuanLyDiemEntities db = new QuanLyDiemEntities();

        //public dynamic checkHocVienDAL(string MaHV)
        //{
        //	var v = from s in db.HocViens
        //			where s.ID == MaHV
        //			select s;
        //	if (v.Count() == 0)
        //		return true;
        //	return false;
        //}
        public dynamic checkHocVienDAL(string MaHV)
        {
            var v = from s in db.HocVien
                    where s.ID == MaHV
                    select s;
            if (v.Count() == 0)
                return true;
            return false;
        }
        //public dynamic getSoHocVienDAL()
        //{
        //	var v = from s in db.HocViens
        //			select s;
        //	return v.Count();
        //}
        public dynamic getLopDAL(string tenLop)
        {
            var v = from s in db.LopDaoTao
                    where s.TenLop == tenLop
                    select s.MaLop;
            return v.SingleOrDefault();
        }
        public void addHVDAL(HocVien hv)
        {
            db.HocVien.Add(hv);
            db.SaveChanges();
        }
        public dynamic getSoHocVienDAL()
		{
			var v = from s in db.HocVien
					select s;
			return v.Count();
		}
		//public dynamic getLopDAL(string tenLop)
		//{
		//	var v = from s in db.LopDaoTao
		//			where s.TenLop == tenLop
		//			select s.MaLop;
		//	return v.SingleOrDefault();
		//}
		//public void addHVDAL(HocVien hv)
		//{
  //              db.HocVien.Add(hv);
  //              db.SaveChanges();
		//}
        public bool CheckID(string ID)
        {
            if (db.HocVien.Find(ID) != null)
                return false;
            return true;
        }
	}
}
