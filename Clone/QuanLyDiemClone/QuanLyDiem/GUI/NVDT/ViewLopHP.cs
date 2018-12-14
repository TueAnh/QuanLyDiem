using QuanLyDiem.BLL;
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
    public partial class ViewLopHP : Form
    {
        #region InitandLoad
        public delegate void AddRemoveControl(Form form);
        public AddRemoveControl addControl, removeControl;
        public ViewLopHP_BLL bLL { get; set; }
        public List<int> NH;

        public ViewLopHP()
        {
            InitializeComponent();
            this.bLL = new ViewLopHP_BLL();
            loadNode();
            PhanQuyen();
        }
        void PhanQuyen()
        {
            if (FormLogin.User.typeAcc != 3)
            {
                buttonThemLopHP.Enabled = false;
            }
        }
        void loadNode()
        {
            treeView1.Nodes.Clear();
            TreeNode n = new TreeNode("Năm học");
            treeView1.Nodes.Add(n);
            NH = bLL.getNodeBLL();
            foreach (int s in NH)
            {
                TreeNode m = new TreeNode(s + "-" + (Convert.ToInt32(s) + 1).ToString());
                n.Nodes.Add(m);
                m.Nodes.Add("Học Kì 1");
                m.Nodes.Add("Học kì 2");
            }
            if (FormLogin.User.typeAcc == 3)
                n.Nodes.Add(new TreeNode("Thêm Học Kì"));
        }
        void LoadData()
        {
            string hk = treeView1.SelectedNode.Text;// hoc ky cho nay khong dung string duoc ???
            int nh = NH[treeView1.SelectedNode.Parent.Index];//nam hoc
            buttonThemLopHP.Visible = true;
            buttonXoa.Visible = true;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("STT", "STT");
            dataGridView1.DataSource = bLL.getTbHPBLL(hk, nh);// ra bảng học phần trong học kì vừa click
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["STT"].Width = 50;
            dataGridView1.RowHeadersVisible = false;
            this.panel2.Controls.Add(dataGridView1);
            if (panel2.Controls.Count > 1)
                this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }
        #endregion
        #region EventTree+Grid
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                LoadData();
                if (treeView1.SelectedNode.Text == "Thêm Học Kì")
                {
                    ThemHocKy themHKForm = new ThemHocKy();
                    themHKForm.Show();
                    themHKForm.themHKSuccess += new ThemHocKy.ThemHKSuccess(loadNode);
                }
            }
            catch
            { }

        }
        //
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < dataGridView1.Rows.Count)
                this.dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string MaHP = dataGridView1.SelectedRows[0].Cells["Mã HP"].Value.ToString();
                LopHPDT f = new LopHPDT(MaHP);// mở form HPDT
                f.addControl += new LopHPDT.AddRemoveControl(AddControlPanel);
                f.removeControl += new LopHPDT.AddRemoveControl(RemoveControlPanel);
                AddControlPanel(f);
            }

        }
        #endregion
        #region DelegateFunction
        public void AddControlPanel(Form form)
        {
            //addControl(form);
            form.TopLevel = false;
            this.panel2.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.None;
            if (panel2.Controls.Count > 1)
            {
                buttonThemLopHP.Visible = false;
                buttonXoa.Visible = false;
            }
            this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonThemLopHP_Click(object sender, EventArgs e)
        {
            ThemLopHP themLopHP = new ThemLopHP();
            themLopHP.Show();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells["Mã HP"].Value.ToString()==null)
            {
                MessageBox.Show("Không có học phần để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var hp = dataGridView1.SelectedRows[0].Cells["Mã HP"].Value.ToString();
                if (hp != null)
                {
                    if (bLL.XoaHP(hp))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Lưu ý học phần đang có sinh viên theo học!");
                    }
                }
            }
        }

        public void RemoveControlPanel(Form form)
        {
            //removeControl(form);
            this.panel2.Controls.Remove(form);
            //this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            if (this.panel2.Controls.Count == 1)
            {
                buttonThemLopHP.Visible = true;
                buttonXoa.Visible = true;
            }
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }
        #endregion
    }
}

