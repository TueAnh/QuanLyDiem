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
        #region DelegateFunction
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
            if (panel2.Controls.Count == 1)
                buttonAddClass.Visible = true;
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }
        #endregion

        #region InitandLoad
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
        void LoadDataGrid(string str)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("STT", "STT");
            dataGridView1.DataSource = BLL.ViewLopDT_BLL.BLL.getTbLopDTBLL(str);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["Malop"].HeaderText = "Mã lớp";
            dataGridView1.Columns["Tenlop"].HeaderText = "Tên Lớp";
            dataGridView1.Columns["STT"].Width = 50;
            dataGridView1.RowHeadersVisible = false;
        }
        #endregion

        #region EventTree+Grid
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < dataGridView1.Rows.Count)
                this.dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.buttonAddClass.Visible = false;
                string MaLop = dataGridView1.SelectedRows[0].Cells["Malop"].Value.ToString().Trim();
                string TenLop = dataGridView1.SelectedRows[0].Cells["Tenlop"].Value.ToString().Trim();
                NVDT.LopSHDT f = new LopSHDT(MaLop, TenLop);
                f.addControl += new LopSHDT.AddRemoveControl(AddControlPanel);
                f.removeControl += new LopSHDT.AddRemoveControl(RemoveControlPanel);
                AddControlPanel(f);
            }
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
                this.buttonAddClass.Visible = false;
                //string MaLop = dataGridView1.SelectedRows[0].Cells["Malop"].Value.ToString().Trim();
                //string TenLop = dataGridView1.SelectedRows[0].Cells["Tenlop"].Value.ToString().Trim();
                NVDT.LopSHDT f = new LopSHDT();
                f.addControl += new LopSHDT.AddRemoveControl(AddControlPanel);
                f.removeControl += new LopSHDT.AddRemoveControl(RemoveControlPanel);
                AddControlPanel(f);
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                string str = treeView1.SelectedNode.Text;
                LoadDataGrid(str);
                this.buttonAddClass.Visible = true;
                this.panel2.Controls.Add(dataGridView1);
                if (panel2.Controls.Count > 1)
                    this.panel2.Controls[panel2.Controls.Count - 2].Hide();
                this.panel2.Controls[panel2.Controls.Count - 1].Show();
            }
            catch
            { }
        }
        #endregion
    }
}
