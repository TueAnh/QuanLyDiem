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
    public partial class LopHPDT : Form
    {
		NVDT.HocVienDT f;
		string MaHP;
		public LopHP_BLL bLL { get; set; }//khởi tạo đối tượng bLL trong lớp GUI
		public LopHPDT(string str)// ham dựng lấy mã học phần
        {
            InitializeComponent();
			bLL = new LopHP_BLL();
			MaHP = str;
			dataGridViewDSHV.DataSource = bLL.getDSHVBLL(str);
			dataGridViewDSHV.Columns[0].HeaderText = "Mã số";
			dataGridViewDSHV.Columns[1].HeaderText = "Họ tên";
			dataGridViewDSHV.Columns[2].HeaderText = "Điểm BT";
			dataGridViewDSHV.Columns[3].HeaderText = "Điểm GK";
			dataGridViewDSHV.Columns[4].HeaderText = "Điểm Thi";
			textBoxGVPT.Text = bLL.getGVBLL(str);
        }

		private void dataGridViewDSHV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			string str = dataGridViewDSHV.SelectedCells[0].Value.ToString();
			f = new HocVienDT(str);
			f.Show();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			string str = textBoxSearch.Text;
			if (str != "")
			{
				dataGridViewDSHV.DataSource = bLL.getDSSearchBLL(str, MaHP);
			}
			else
			{
				dataGridViewDSHV.DataSource = bLL.getDSHVBLL(str);
			}
			dataGridViewDSHV.DataSource = bLL.getDSHVBLL(str);
			dataGridViewDSHV.Columns[0].HeaderText = "Mã số";
			dataGridViewDSHV.Columns[1].HeaderText = "Họ tên";
			dataGridViewDSHV.Columns[2].HeaderText = "Điểm BT";
			dataGridViewDSHV.Columns[3].HeaderText = "Điểm GK";
			dataGridViewDSHV.Columns[4].HeaderText = "Điểm Thi";
		}
	}
}
