﻿using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
	public class HocVien_BLL
	{
		DAL.HocVien_DAL dAL = new HocVien_DAL();
		public HocVien getHVBLL(string str)
		{
			return dAL.getHVDAL(str);
		}

		public dynamic getDTBvXLBLL(string str)
		{
			return dAL.getDTBvXLDAL(str);
		}

		public List<int> loadCBBNHBLL(string str)
		{
			return dAL.loadCBBNHDAL(str);
		}

		public List<string> loadCBBHKBLL(string str)
		{
			return dAL.loadCBBHKDAL(str);
		}

		public dynamic getDiemQTBLL(string str)
		{
			return dAL.getDiemQTDAL(str);
		}

		public dynamic getDiemNHBLL(string str, int nh)
		{
			return dAL.getDiemNHDAL(str, nh);
		}

		public dynamic getDiemHKBLL(string str, int nh, string hk)
		{
			return dAL.getDiemHKDAL(str, nh, hk);
		}

		public string GetTenLop(string str)
		{
			return dAL.GetTenLop(str);
		}
	}
}
