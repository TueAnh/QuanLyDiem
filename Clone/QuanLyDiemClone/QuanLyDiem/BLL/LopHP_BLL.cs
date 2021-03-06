﻿using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
	public class LopHP_BLL
	{
		public LopHP_DAL dAL { get; set; }

		public LopHP_BLL()
		{
			dAL = new LopHP_DAL();
		}

		public DataTable getDSHVBLL(string str)
		{
			return dAL.getDSHVDAL(str);
		}
		public DataTable getDSHVBLL2(string str)
		{
			return dAL.getDSHVDAL2(str);
		}

		public GiangVien getGVBLL(string str)
		{
			return dAL.getGVDAL(str);
		}
		public string getTenKhoaBLL(string maHP)
		{
			return dAL.getTenKhoaDAL(maHP);
		}
		public string getTenHPBLL(string maHP)
		{
			return dAL.getTenHPDAL(maHP);
		}
		public dynamic getSoTCBLL(string maHP)
		{
			return dAL.getSoTCDAL(maHP);
		}
		public DataTable getDSSearchBLL(string str, string MaHP)
		{
			return dAL.getDSSearchDAL(str, MaHP);
		}
		public int UpdateKQHP(KetQuaHocPhan kq, string MaHV, string MaHP)
		{
			return dAL.UpdateKQHP(kq, MaHV, MaHP);
		}
		public bool XoaHV(string ID, string MaHP)
		{
			return dAL.XoaHV(ID, MaHP);
		}
	}
}
