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
    public partial class LopSHDT : Form
    {
        #region DelegateFunction
        public delegate void AddRemoveControl(Form form);
        public AddRemoveControl addControl, removeControl;
        public void AddControlPanel(Form form)
        {
            addControl(form);
        }
        public void RemoveControlPanel(Form form)
        {
            removeControl(form);
        }
        #endregion

        #region Init+Load
        NVDT.HocVienDT f;
        public LopDT_BLL bLL;
        //public string MaLop;
        public LopSHDT(string MaLop,string TenLop)
        {
            InitializeComponent();
            bLL = new LopDT_BLL();
            textBoxMaLop.Text = MaLop;
            textBoxTenLop.Text = TenLop;
            LoadDataGrid();
        }
        public LopSHDT()
        {
            InitializeComponent();
        }
        void LoadDataGrid(string str = "")
        {
            dataGridViewDSHV.Columns.Clear();
            dataGridViewDSHV.Columns.Add("STT", "STT");
            if (str != "")
            {
                dataGridViewDSHV.DataSource = bLL.getDSSearchBLL(textBoxSearch.Text, textBoxMaLop.Text);
            }
                
            else
                dataGridViewDSHV.DataSource = bLL.getDSHVBLL(textBoxMaLop.Text);
            
            dataGridViewDSHV.RowHeadersVisible = false;
            dataGridViewDSHV.Columns[1].HeaderText = "Mã số";
            dataGridViewDSHV.Columns[2].HeaderText = "Họ tên";
            dataGridViewDSHV.Columns[3].HeaderText = "Email";
            dataGridViewDSHV.Columns[4].HeaderText = "Địa chỉ";
            dataGridViewDSHV.Columns[5].HeaderText = "Điện thoại";
            dataGridViewDSHV.Columns[6].HeaderText = "Ngày sinh";
            dataGridViewDSHV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDSHV.Columns["STT"].Width = 50;
            try
            {
                dataGridViewDSHV.Columns["Họ tên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch { }
            //dataGridViewDSHV.Columns["Tên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        #endregion
        AddHocVienSH_BLL bll = new AddHocVienSH_BLL();
        #region ButtonClick
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            removeControl(this);
            this.Dispose();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadDataGrid(textBoxSearch.Text);
        }
        #endregion

        #region EventDataGrid

        private void dataGridViewDSHV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < dataGridViewDSHV.Rows.Count)
                this.dataGridViewDSHV.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void buttonThemHVExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog fopen = new OpenFileDialog();
            //Duoi file
            fopen.Filter = "(Tất cả các tệp)|*.*|(Các tệp excel)|*.xlsx";
            fopen.ShowDialog();
            //xu li
            if (fopen.FileName != "")
            {
                labelPath.Text = fopen.FileName;
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
                            var x = range.Cells[r, c].Value.ToString();
                            row[c - 1] = x;
                        }
                        tb.Rows.Add(row);
                    }
                    dataGridViewDSHV.DataSource = tb;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn không chọn tệp nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dataGridViewDSHV.Rows)
            {
                bll.AddHVSH_BLL(new HocVien
                {
                    ID = r.Cells["Mã số"].Value.ToString().Trim(),
                    HoTen = r.Cells["Họ tên"].Value.ToString().Trim(),
                    Email = r.Cells["Email"].Value.ToString().Trim(),
                    DiaChi = r.Cells["Địa chỉ"].Value.ToString().Trim(),
                    DienThoai = r.Cells["Điện thoại"].Value.ToString().Trim(),
                    Password = r.Cells["Mật khẩu"].Value.ToString().Trim(),
                    NgaySinh = Convert.ToDateTime(r.Cells["Ngày sinh"].Value),
                    MaLop = textBoxMaLop.Text.Trim()
                });
            }
            
        }

		private void buttonAdđ_Click(object sender, EventArgs e)
		{
			ThemHocVien f = new ThemHocVien(textBoxMaLop.Text, textBoxTenLop.Text);
			f.Show();
		}

		private void dataGridViewDSHV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = dataGridViewDSHV.SelectedRows[0].Cells["Mã số"].Value.ToString();
            f = new HocVienDT(str);
            f.addControl += new HocVienDT.AddRemoveControl(AddControlPanel);
            f.removeControl += new HocVienDT.AddRemoveControl(RemoveControlPanel);
            AddControlPanel(f);
        }
        #endregion

    }
}
