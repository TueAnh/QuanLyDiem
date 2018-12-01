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
    public partial class LopHPDT : Form
    {
        #region InitandLoad
        public delegate void AddRemoveControl(Form form);
        public AddRemoveControl addControl;
        public AddRemoveControl removeControl;

        string MaHP = "";
        public LopHP_BLL bLL { get; set; }
        public LopHPDT()
        {
            InitializeComponent();
            
        }
        public LopHPDT(string MaHP)// ham dựng lấy mã học phần
        {
            InitializeComponent();
            bLL = new LopHP_BLL();
            this.MaHP = MaHP;
            LoadData(MaHP);
        }

        ////public LopHPDT(string MaHP, string GiangVien)
        ////{
        ////    InitializeComponent();
        ////    this.MaHP = MaHP;
        ////    textBoxGVPT.Text = GiangVien;
        ////}
        public void LoadData(string MaHP)
        {
            dataGridViewDSHV.Columns.Clear();
            dataGridViewDSHV.Columns.Add("STT", "STT");
            dataGridViewDSHV.DataSource = bLL.getDSHVBLL(MaHP);
            dataGridViewDSHV.Columns[1].HeaderText = "Mã số";
            dataGridViewDSHV.Columns[2].HeaderText = "Họ tên";
            dataGridViewDSHV.Columns[3].HeaderText = "Điểm BT";
            dataGridViewDSHV.Columns[4].HeaderText = "Điểm GK";
            dataGridViewDSHV.Columns[5].HeaderText = "Điểm Thi";
            textBoxGVPT.Text = bLL.getGVBLL(MaHP);
            dataGridViewDSHV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDSHV.Columns["STT"].Width = 50;
            this.dataGridViewDSHV.Refresh();
        }

        private void LopHPDT_Load(object sender, EventArgs e)
        {
            //LoadData(MaHP);
        }
        #endregion
        #region ButtonClick
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewDSHV.Columns.Clear();
            dataGridViewDSHV.Columns.Add("STT", "STT");
            string str = textBoxSearch.Text;
            if (str != "")
            {
                dataGridViewDSHV.DataSource = bLL.getDSSearchBLL(str, MaHP);
            }
            else
            {
                dataGridViewDSHV.DataSource = bLL.getDSHVBLL(str);
            }
            dataGridViewDSHV.Columns[1].HeaderText = "Mã số";
            dataGridViewDSHV.Columns[2].HeaderText = "Họ tên";
            dataGridViewDSHV.Columns[3].HeaderText = "Điểm BT";
            dataGridViewDSHV.Columns[4].HeaderText = "Điểm GK";
            dataGridViewDSHV.Columns[5].HeaderText = "Điểm Thi";
            dataGridViewDSHV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDSHV.Columns["STT"].Width = 50;
            this.dataGridViewDSHV.Refresh();
        }
        
        private void buttonBack_Click(object sender, EventArgs e)
        {
            removeControl(this);
            this.Dispose();
        }
        #endregion
        #region DelegateFunction
        public void AddControlPanel(Form form)
        {
            addControl(form);
        }
        public void RemoveControlPanel(Form form)
        {
            removeControl(form);
        }
        #endregion
        #region DataGridViewEvent
        private void dataGridViewDSHV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < dataGridViewDSHV.Rows.Count)
                this.dataGridViewDSHV.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridViewDSHV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string MaHV = dataGridViewDSHV.SelectedRows[0].Cells["Mã số"].Value.ToString();
                NVDT.HocVienDT f = new HocVienDT(MaHV);
                f.addControl += new HocVienDT.AddRemoveControl(AddControlPanel);
                f.removeControl += new HocVienDT.AddRemoveControl(RemoveControlPanel);
                AddControlPanel(f);
            } 
        }
        #endregion
    }
}
