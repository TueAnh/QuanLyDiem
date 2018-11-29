using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiem.DAL;

namespace QuanLyDiem.BLL
{
	public class LopHP_BLL
	{
		public LopHP_DAL dAL { get; set; }

		public LopHP_BLL()
		{
			dAL = new LopHP_DAL();
		}

		public dynamic getDSHVBLL(string str)
		{
			return dAL.getDSHVDAL(str);
		}

		public string getGVBLL(string str)
		{
			return dAL.getGVDAL(str);
		}

		public dynamic getDSSearchBLL(string str, string MaHP)
		{
			return dAL.getDSSearchDAL(str , MaHP);
		}
	}
}
