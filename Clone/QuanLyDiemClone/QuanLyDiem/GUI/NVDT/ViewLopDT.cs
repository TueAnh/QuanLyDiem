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
            this.buttonAddClass.Visible = false;
            this.buttonXoaLop.Visible = false;
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
            if (panel2.Controls.Count == 1)
            {
                this.buttonAddClass.Visible = true;
                this.buttonXoaLop.Visible = true;
            }
                
            //this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }
        #endregion

        #region InitandLoad
        public ViewLopDT()
        {
            InitializeComponent();
            loadNode();
            PhanQuyen();
        }
        void PhanQuyen()
        {
            if (FormLogin.User.typeAcc != 3)
            {
                buttonAddClass.Enabled = false;
                buttonXoaLop.Enabled = false;
            }
        }
        void loadNode()
        {
            treeView1.Nodes.Clear();
            TreeNode n = new TreeNode("Khoa");
            treeView1.Nodes.Add(n);
            List<string> st = BLL.ViewLopDT_BLL.BLL.getNodeBLL();
            foreach (var x in st)
            {
                n.Nodes.Add(x);
            }
            if (FormLogin.User.typeAcc == 3)
                n.Nodes.Add(new TreeNode("Thêm Khoa"));
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

                string MaLop = dataGridView1.SelectedRows[0].Cells["Malop"].Value.ToString().Trim();
                string TenLop = dataGridView1.SelectedRows[0].Cells["Tenlop"].Value.ToString().Trim();
                NVDT.LopSHDT f = new LopSHDT(MaLop, TenLop, treeView1.SelectedNode.Text);
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
			string Khoa = treeView1.SelectedNode.Text;
			NVDT.ThemLopCH f = new ThemLopCH(Khoa);
			f.ShowDialog();
            LoadDataGrid(treeView1.SelectedNode.Text);
            this.buttonAddClass.Visible = true;
        }

        private void buttonXoaLop_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                string MaLop = dataGridView1.SelectedRows[i].Cells["Malop"].Value.ToString().Trim();
                if (BLL.ViewLopDT_BLL.BLL.DelObject_BLL(MaLop))
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Không thành công! Chú ý rằng bạn không có quyền xóa lớp có học viên.");
                }
            }          
            LoadDataGrid(treeView1.SelectedNode.Text);
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                string str = treeView1.SelectedNode.Text;
                LoadDataGrid(str);
                if (dataGridView1.Rows.Count > 0)
                {
                    this.buttonAddClass.Visible = true;
                    this.buttonXoaLop.Visible = true;
                }

                this.panel2.Controls.Add(dataGridView1);
                if (panel2.Controls.Count > 1)
                    this.panel2.Controls[panel2.Controls.Count - 2].Hide();
                this.panel2.Controls[panel2.Controls.Count - 1].Show();
                if (treeView1.SelectedNode.Text == "Thêm Khoa")
                {
                    ThemKhoa themKhoaForm = new ThemKhoa();
                    themKhoaForm.Show();
                    themKhoaForm.themKhoaSuccess += new ThemKhoa.ThemKhoaSuccess(loadNode);
                }
            }
            catch
            { }
        }
        #endregion
    }
}
