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
using Excel = Microsoft.Office.Interop.Excel;
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
                buttonThemLopHP.Visible = false;
                buttonXoa.Visible = false;
                buttonThemHPExcel.Visible = false;
                buttonThemLopHP.Enabled = false;
                buttonXoa.Enabled = false;
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
            try
            {
                if (e.RowIndex < dataGridView1.Rows.Count)
                    this.dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
            }
            catch
            {

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch
            {

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
            try
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
            catch
            {

            }
        }

        private void buttonThemHPExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog fopen = new OpenFileDialog();
            //Duoi file
            fopen.Filter = "(Tất cả các tệp)|*.*|(Các tệp excel)|*.xlsx";
            fopen.ShowDialog();
            //xu li
            if (fopen.FileName != "")
            {
                labelPath.Text = fopen.FileName;
                labelPath.Visible = true;
                //tao doi tuong Excel
                Excel.Application app = new Excel.Application();
                //Mở tập excel
                Excel.Workbook wb = app.Workbooks.Open(fopen.FileName);
                try
                {
                    Excel._Worksheet sheet = wb.Sheets[1];
                    Excel.Range range = sheet.UsedRange;
                    //doc du lieu
                    int rows = range.Rows.Count;
                    int cols = range.Columns.Count;
                    DataTable tb = new DataTable();
                    //doc tieu de
                    for (int c = 1; c <= cols; c++)
                    {
                        string columName = range.Cells[1, c].Value.ToString();
                        tb.Columns.Add(columName);
                    }

                    for (int r = 2; r <= rows; r++)
                    {
                        DataRow row = tb.NewRow();
                        for (int c = 1; c <= cols; c++)
                        {
                            var x = range.Cells[r, c].Value;
                            row[c - 1] = x;
                        }
                        tb.Rows.Add(row);
                    }
                    dataGridView1.DataSource = tb;
                    buttonSave.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelPath.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Bạn không chọn tệp nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ThemLopHP_BLL themHP = new ThemLopHP_BLL();
            try
            {
                foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (
                themHP.AddHP_BLL(new HocPhan
                {
                    MaHP = r.Cells["Mã Học Phần"].Value.ToString().Trim(),
                    TenHP = r.Cells["Tên Học Phần"].Value.ToString().Trim(),
                    SoTC = Convert.ToInt16(r.Cells["Số Tín Chỉ "].Value.ToString().Trim()),
                    SoTiet = Convert.ToInt16(r.Cells["Số Tiết"].Value.ToString().Trim()),
                    PhanTramDGK = Convert.ToDouble(r.Cells["PT Điểm Giữa Kì"].Value.ToString().Trim()),
                    PhanTramDT = Convert.ToDouble(r.Cells["PT Điểm Thi"].Value.ToString().Trim()),
                    MaHK = r.Cells["Mã Học Kì"].Value.ToString().Trim(),
                    ID = r.Cells["ID"].Value.ToString().Trim()
                }))
                    r.DefaultCellStyle.BackColor = Color.Lime;
                else
                    r.DefaultCellStyle.BackColor = Color.Red;
            }
            }
            catch
            {
                MessageBox.Show("Excel không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buttonSave.Visible = false;
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

