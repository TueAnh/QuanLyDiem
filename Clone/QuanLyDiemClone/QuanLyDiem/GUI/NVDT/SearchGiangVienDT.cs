using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiem.BLL;

namespace QuanLyDiem.GUI.NVDT
{
	public partial class SearchGiangVienDT : Form
	{
		SearchGiangVien_BLL bLL = new SearchGiangVien_BLL();
		public SearchGiangVienDT()
		{
			InitializeComponent();
			LoadDTG();
		}
		public void LoadDTG()
		{
			dataGridView.DataSource = bLL.getDSGVBLL();
		}

		private void buttonAddGV_Click(object sender, EventArgs e)
		{
			ThemGiangVien f = new ThemGiangVien();
			f.Show();
		}
	}
}
