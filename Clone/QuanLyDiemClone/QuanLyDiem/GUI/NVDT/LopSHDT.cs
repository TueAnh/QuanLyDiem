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
            labelMaLop.Text = MaLop;
            labelTenLop.Text = TenLop;
            LoadDataGrid();
        }
        void LoadDataGrid(string str = "")
        {
            dataGridViewDSHV.Columns.Clear();
            dataGridViewDSHV.Columns.Add("STT", "STT");
            if (str != "")
            {
                dataGridViewDSHV.DataSource = bLL.getDSSearchBLL(textBoxSearch.Text, labelMaLop.Text);
            }
                
            else
                dataGridViewDSHV.DataSource = bLL.getDSHVBLL(labelMaLop.Text);
            dataGridViewDSHV.RowHeadersVisible = false;
            dataGridViewDSHV.Columns[1].HeaderText = "Mã số";
            dataGridViewDSHV.Columns[2].HeaderText = "Họ tên";
            dataGridViewDSHV.Columns[3].HeaderText = "Email";
            dataGridViewDSHV.Columns[4].HeaderText = "Địa chỉ";
            dataGridViewDSHV.Columns[5].HeaderText = "Điện thoại";
            dataGridViewDSHV.Columns[6].HeaderText = "Ngày sinh";
            dataGridViewDSHV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDSHV.Columns["STT"].Width = 50;
            dataGridViewDSHV.Columns["Họ tên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        #endregion

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
