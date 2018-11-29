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
    public partial class LopSHDT : Form
    {
		NVDT.HocVienDT f;
		public LopDT_BLL bLL;
		public string MaLop;
        public LopSHDT(string str)
        {
            InitializeComponent();
			bLL = new LopDT_BLL();
			MaLop = str;
			dataGridViewDSHV.DataSource = bLL.getDSHVBLL(MaLop);// lấy bảng danh sách các học viên của lớp đào tạo
			dataGridViewDSHV.Columns[0].HeaderText = "Mã số";
			dataGridViewDSHV.Columns[1].HeaderText = "Họ tên";
			dataGridViewDSHV.Columns[2].HeaderText = "Email" ;
			dataGridViewDSHV.Columns[3].HeaderText = "Địa chỉ";
			dataGridViewDSHV.Columns[4].HeaderText = "Điện thoại";
			dataGridViewDSHV.Columns[5].HeaderText = "Ngày sinh";
		}

		void loadCBBsearch()
		{
			comboBoxSearch.Items.Add("Mã số học viên");
			comboBoxSearch.Items.Add("Tên học viên");
		}

		private void dataGridViewDSHV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			string str = dataGridViewDSHV.SelectedCells[0].Value.ToString();
			f = new HocVienDT(str);
			f.Show();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			string str1 = comboBoxSearch.Items.ToString();
			string str2 = textBoxSearch.Text;
			if (str2 != "")
			{
				dataGridViewDSHV.DataSource = bLL.getDSSearchBLL(str1, str2, MaLop);
			}
			else
			{
				dataGridViewDSHV.DataSource = bLL.getDSHVBLL(MaLop);
			}
			dataGridViewDSHV.Columns[0].HeaderText = "Mã số";
			dataGridViewDSHV.Columns[1].HeaderText = "Họ tên";
			dataGridViewDSHV.Columns[2].HeaderText = "Email";
			dataGridViewDSHV.Columns[3].HeaderText = "Địa chỉ";
			dataGridViewDSHV.Columns[4].HeaderText = "Điện thoại";
			dataGridViewDSHV.Columns[5].HeaderText = "Ngày sinh";
		}
	}
}
