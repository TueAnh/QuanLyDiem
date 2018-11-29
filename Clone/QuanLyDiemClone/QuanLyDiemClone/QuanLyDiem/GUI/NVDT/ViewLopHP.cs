using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiem.DAL;
using QuanLyDiem.BLL;

namespace QuanLyDiem.GUI.NVDT
{
    public partial class ViewLopHP : Form
    {
		public ViewLopHP_BLL bLL { get; set; }
        public List<int> NH;

        public ViewLopHP()
        {
            InitializeComponent();
			this.bLL = new ViewLopHP_BLL();
			loadNode();
        }


		void loadNode()
		{
			TreeNode n = new TreeNode("Năm học");
			treeView1.Nodes.Add(n);
			NH = bLL.getNodeBLL();
			foreach (int s in NH)
			{
                TreeNode m = new TreeNode(s+"-" + (Convert.ToInt32(s) + 1).ToString());
				n.Nodes.Add(m);
				m.Nodes.Add("Học kì 1");
				m.Nodes.Add("Học kì 2");
			}
		}

		private void buttonView_Click(object sender, EventArgs e)
		{
			//string hk = treeView1.SelectedNode.Text;// hoc ky cho nay khong dung string duoc ???
			//int nh = Convert.ToInt32(treeView1.SelectedNode.Parent.Text);//nam hoc
			//dataGridView1.DataSource = bLL.getTbHPBLL(hk, nh);
		}

		private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			string str = dataGridView1.SelectedRows[0].Cells["Mã HP"].Value.ToString();
			LopHPDT f = new LopHPDT(str);// mở form HPDT
			f.Show();
		}

		private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
            try
            {
                string hk = treeView1.SelectedNode.Text;// hoc ky cho nay khong dung string duoc ???
                int nh = NH[treeView1.SelectedNode.Parent.Index];//nam hoc
                dataGridView1.DataSource = bLL.getTbHPBLL(hk, nh);// ra bảng học phần trong học kì vừa click
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch
            {

            }            
			//dataGridView1.Columns[0].HeaderText = "Mã HP";
			//dataGridView1.Columns[1].HeaderText = "tên hp";
			//dataGridView1.Columns[2].HeaderText = "số tc";
			//dataGridView1.Columns[3].HeaderText = "số tiết lt";
			//dataGridView1.Columns[4].HeaderText = "số tiết th";
			//dataGridView1.Columns[5].HeaderText = "phần trăm dkt";
			//dataGridView1.Columns[6].HeaderText = "phần trăm dt";
		}
	}
}
