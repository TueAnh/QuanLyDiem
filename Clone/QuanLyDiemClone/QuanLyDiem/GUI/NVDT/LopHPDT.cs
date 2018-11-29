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
        public delegate void AddRemoveControl(Form form);
        public AddRemoveControl addControl;
        public AddRemoveControl removeControl;
        NVDT.HocVienDT f;
        string MaHP = "";
        public LopHP_BLL bLL { get; set; }
        public LopHPDT()
        {
            InitializeComponent();
            
        }
        public LopHPDT(string str)// ham dựng lấy mã học phần
        {
            InitializeComponent();
            bLL = new LopHP_BLL();
            MaHP = str;
            dataGridViewDSHV.DataSource = bLL.getDSHVBLL(str);
            dataGridViewDSHV.Columns[0].HeaderText = "Mã số";
            dataGridViewDSHV.Columns[1].HeaderText = "Họ tên";
            dataGridViewDSHV.Columns[2].HeaderText = "Điểm BT";
            dataGridViewDSHV.Columns[3].HeaderText = "Điểm GK";
            dataGridViewDSHV.Columns[4].HeaderText = "Điểm Thi";
            textBoxGVPT.Text = bLL.getGVBLL(str);
        }

        public LopHPDT(string MaHP, string GiangVien)
        {
            InitializeComponent();
            this.MaHP = MaHP;
            textBoxGVPT.Text = GiangVien;
        }
        public void LoadData(string MaHP)
        {
            this.dataGridViewDSHV.DataSource = Login_BLL.BLL.GetListHV(MaHP);
            this.dataGridViewDSHV.Columns.Add("DTB", "DTB");
            foreach (DataGridViewRow row in dataGridViewDSHV.Rows)
            {
                row.Cells["DTB"].Value = (Convert.ToDouble(row.Cells["DiemBT"].Value) * 0.2 +
                                          Convert.ToDouble(row.Cells["DiemGK"].Value) * 0.2 +
                                          Convert.ToDouble(row.Cells["DiemThi"].Value) * 0.6).ToString();
            }
            dataGridViewDSHV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSHV.Refresh();
        }

        private void LopHPDT_Load(object sender, EventArgs e)
        {
            LoadData(MaHP);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void dataGridViewDSHV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string str = dataGridViewDSHV.SelectedCells[0].Value.ToString();
            f = new HocVienDT(str);
            f.addControl += new HocVienDT.AddRemoveControl(AddControlPanel);
            f.removeControl += new HocVienDT.AddRemoveControl(RemoveControlPanel);
            AddControlPanel(f);
            //f.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string str = textBoxSearch.Text;
            if (str != "")
            {
                dataGridViewDSHV.DataSource = bLL.getDSSearchBLL(str, MaHP);
            }
            else
            {
                dataGridViewDSHV.DataSource = bLL.getDSHVBLL(str);
            }
            dataGridViewDSHV.DataSource = bLL.getDSHVBLL(str);
            dataGridViewDSHV.Columns[0].HeaderText = "Mã số";
            dataGridViewDSHV.Columns[1].HeaderText = "Họ tên";
            dataGridViewDSHV.Columns[2].HeaderText = "Điểm BT";
            dataGridViewDSHV.Columns[3].HeaderText = "Điểm GK";
            dataGridViewDSHV.Columns[4].HeaderText = "Điểm Thi";
            dataGridViewDSHV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            removeControl(this);
            this.Dispose();
        }
        public void AddControlPanel(Form form)
        {
            addControl(form);
        }
        public void RemoveControlPanel(Form form)
        {
            removeControl(form);
        }
    }
}
