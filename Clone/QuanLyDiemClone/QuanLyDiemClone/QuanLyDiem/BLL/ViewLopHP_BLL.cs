﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiem.DAL;

namespace QuanLyDiem.BLL
{
	public class ViewLopHP_BLL
	{
		public ViewLopHP_DAL dAL { get; set; }

		public ViewLopHP_BLL()
		{
			dAL = new ViewLopHP_DAL();
		}
		public List<int> getNodeBLL()
		{
			return dAL.getNodeDAL();
		}
		public DataTable getTbHPBLL(string hk , int nh)
		{
			return dAL.getTbHPDAL(hk, nh);
		}
		
	}
}
