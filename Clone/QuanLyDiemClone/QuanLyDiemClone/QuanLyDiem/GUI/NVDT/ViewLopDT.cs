using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.GUI.NVDT
{
	public partial class ViewLopDT : Form
	{
		NVDT.LopSHDT f;
		public ViewLopDT()
		{
			InitializeComponent();
			loadNode(); 
		}

		void loadNode()
		{
			TreeNode n = new TreeNode("Khoa");
			treeView1.Nodes.Add(n);
			List<string> st = BLL.ViewLopDT_BLL.BLL.getNodeBLL();
			foreach (var x in st)
			{
				n.Nodes.Add(x);
			}
		}

		private void buttonView_Click(object sender, EventArgs e)//bỏ đi
		{
			//string str = treeView1.SelectedNode.Text;
			//dataGridView1.DataSource = BLL.ViewLopDT_BLL.BLL.getTbLopDTBLL(str);
		}

		private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			// sau double click hiện ra form LopSHDT 
			string str = dataGridView1.SelectedRows[0].Cells["Malop"].Value.ToString();
			dataGridView1.DataSource = BLL.ViewLopDT_BLL.BLL.getDSHVBLL(str);
			f = new LopSHDT(str);
			f.Show();
		}

		private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			// sau double click hiện ra danh sách lớp của khoa chọn
			string str = treeView1.SelectedNode.Text;
			dataGridView1.DataSource = BLL.ViewLopDT_BLL.BLL.getTbLopDTBLL(str);
			dataGridView1.Columns["Malop"].HeaderText = "Mã lớp";
			dataGridView1.Columns["Tenlop"].HeaderText = "Tên Lớp";
		}

		private void buttonBack_Click(object sender, EventArgs e)//bo di
		{
			////f.Close();
			////dataGridView1.Visible = true;
			//string str = treeView1.SelectedNode.Text;
			//dataGridView1.DataSource = BLL.ViewLopDT_BLL.BLL.getTbLopDTBLL(str);
			//dataGridView1.Columns["Malop"].HeaderText = "Mã lớp";
			//dataGridView1.Columns["Tenlop"].HeaderText = "Tên Lớp";
		}
	}
}
