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
        NVDT.HocVienDT f;
        public LopDT_BLL bLL;
        //public string MaLop;
        public LopSHDT(string MaLop,string TenLop)
        {
            InitializeComponent();
            loadCBBsearch();
            bLL = new LopDT_BLL();
            labelMaLop.Text = MaLop;
            labelTenLop.Text = TenLop;
            dataGridViewDSHV.DataSource = bLL.getDSHVBLL(MaLop);// lấy bảng danh sách các học viên của lớp đào tạo
            dataGridViewDSHV.Columns[0].HeaderText = "Mã số";
            dataGridViewDSHV.Columns[1].HeaderText = "Họ tên";
            dataGridViewDSHV.Columns[2].HeaderText = "Email";
            dataGridViewDSHV.Columns[3].HeaderText = "Địa chỉ";
            dataGridViewDSHV.Columns[4].HeaderText = "Điện thoại";
            dataGridViewDSHV.Columns[5].HeaderText = "Ngày sinh";
            dataGridViewDSHV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        void loadCBBsearch()
        {
            comboBoxSearch.Items.Add("Mã số học viên");
            comboBoxSearch.Items.Add("Tên học viên");
        }
        
        private void dataGridViewDSHV_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string str = dataGridViewDSHV.SelectedCells[0].Value.ToString();
            f = new HocVienDT(str);
            f.addControl += new HocVienDT.AddRemoveControl(AddControlPanel);
            f.removeControl += new HocVienDT.AddRemoveControl(RemoveControlPanel);
            addControl(f);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            removeControl(this);
            this.Dispose();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string str1 = comboBoxSearch.Items.ToString();
            string str2 = textBoxSearch.Text;
            if (str2 != "")
            {
                dataGridViewDSHV.DataSource = bLL.getDSSearchBLL(str1, str2, labelMaLop.Text);
            }
            else
            {
                dataGridViewDSHV.DataSource = bLL.getDSHVBLL(labelMaLop.Text);
            }
            dataGridViewDSHV.Columns[0].HeaderText = "Mã số";
            dataGridViewDSHV.Columns[1].HeaderText = "Họ tên";
            dataGridViewDSHV.Columns[2].HeaderText = "Email";
            dataGridViewDSHV.Columns[3].HeaderText = "Địa chỉ";
            dataGridViewDSHV.Columns[4].HeaderText = "Điện thoại";
            dataGridViewDSHV.Columns[5].HeaderText = "Ngày sinh";
        }
    }
}
