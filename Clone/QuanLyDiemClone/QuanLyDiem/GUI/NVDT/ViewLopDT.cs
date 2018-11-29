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
        public delegate void AddRemoveControl(Form form);
        public AddRemoveControl addControl, removeControl;
        public void AddControlPanel(Form form)
        {
            //addControl(form);
            form.TopLevel = false;
            this.panel2.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.None;
            this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }
        public void RemoveControlPanel(Form form)
        {
            //removeControl(form);
            this.panel2.Controls.Remove(form);
            //this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }

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

        private void buttonView_Click(object sender, EventArgs e)
        {
            //string str = treeView1.SelectedNode.Text;
            //dataGridView1.DataSource = BLL.ViewLopDT_BLL.BLL.getTbLopDTBLL(str);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string MaLop = dataGridView1.SelectedRows[0].Cells["Malop"].Value.ToString().Trim();
            string TenLop = dataGridView1.SelectedRows[0].Cells["Tenlop"].Value.ToString().Trim();
            NVDT.LopSHDT f = new LopSHDT(MaLop,TenLop);
            f.addControl += new LopSHDT.AddRemoveControl(AddControlPanel);
            f.removeControl += new LopSHDT.AddRemoveControl(RemoveControlPanel);
            AddControlPanel(f);
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                string str = treeView1.SelectedNode.Text;
                dataGridView1.DataSource = BLL.ViewLopDT_BLL.BLL.getTbLopDTBLL(str);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns["Malop"].HeaderText = "Mã lớp";
                dataGridView1.Columns["Tenlop"].HeaderText = "Tên Lớp";
                this.panel2.Controls.Add(dataGridView1);
                if (panel2.Controls.Count > 1)
                    this.panel2.Controls[panel2.Controls.Count - 2].Hide();
                this.panel2.Controls[panel2.Controls.Count - 1].Show();
            }
            catch
            { }
        }
    }
}
