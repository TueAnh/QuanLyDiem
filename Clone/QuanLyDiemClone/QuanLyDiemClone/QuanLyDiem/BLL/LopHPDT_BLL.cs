using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
	class LopHPDT_BLL
	{
		private static LopHPDT_BLL dAL;

		public static LopHPDT_BLL DAL
		{
			get => dAL == null ? dAL = new LopHPDT_BLL() : dAL;
			private set => dAL = value;
		}
		private LopHPDT_BLL() { }
	}
}
