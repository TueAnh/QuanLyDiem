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
    public partial class SearchHocVien : Form
    {
        SearchHocVien_BLL Search_bll = new SearchHocVien_BLL();
        public delegate void AddRemoveControl(Form form);
        public AddRemoveControl addControl;
        public AddRemoveControl removeControl;
        public void AddControlPanel(Form form)
        {
            //addControl(form);
            form.TopLevel = false;
            this.panel2.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.None;
            if (panel2.Controls.Count > 1)
                this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }
        public void RemoveControlPanel(Form form)
        {
            //removeControl(form);
            this.panel2.Controls.Remove(form);
            if (panel2.Controls.Count > 1)
                this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }
        
        public SearchHocVien()
        {
            InitializeComponent();
            comboBox1.SelectedItem = comboBox1.Items[0];
            LoadButton();
            LoadAllHocVien();
        }
        void LoadButton()
        {
            if (FormLogin.User.typeAcc != 3)
            {
                buttonAddHV.Enabled = false;
                buttonDel.Enabled = false;
            }
        }
        void LoadAllHocVien()
        {
            
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("STT", "STT");
            dataGridView.DataSource = Search_bll.LoadAllHocVien();
            dataGridView.Columns["STT"].Width = 50;
        }

        private void buttonReLoad_Click(object sender, EventArgs e)
        {
            LoadAllHocVien();
        }

        private void buttonSearchMaHV_HoTen_Click(object sender, EventArgs e)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("STT", "STT");
            dataGridView.DataSource = Search_bll.LoadSearchedHocVien(textBoxSearchMaHV_HoTen.Text);
            dataGridView.Columns["STT"].Width = 50;
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            //removeControl(this);
            this.Dispose();
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < dataGridView.Rows.Count)
                this.dataGridView.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HocVienDT hocVienDT = new HocVienDT(dataGridView.SelectedRows[0].Cells["Mã HV"].Value.ToString());
            hocVienDT.addControl += new HocVienDT.AddRemoveControl(AddControlPanel);
            hocVienDT.removeControl += new HocVienDT.AddRemoveControl(RemoveControlPanel);
            AddControlPanel(hocVienDT);
        }

		private void buttonAddHV_Click(object sender, EventArgs e)
		{
            //NVDT.ThemHocVien f = new ThemHocVien();
            NVDT.FormAddHV f = new FormAddHV();
			f.ShowDialog();
            LoadAllHocVien();
		}

        private void buttonDel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                if (Search_bll.XoaHV_BLL(dataGridView.SelectedRows[i].Cells["Mã HV"].Value.ToString().Trim()))
                {
                    //MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xuất hiện lỗi. Hãy thử lại!");
                }
            LoadAllHocVien();
        }

        private void buttonSort_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "Theo Tên")
            {
                dataGridView.Sort(dataGridView.Columns["Tên"], ListSortDirection.Ascending);
            }
            if (comboBox1.SelectedItem.ToString() == "Theo Mã")
            {
                dataGridView.Sort(dataGridView.Columns["Mã HV"], ListSortDirection.Ascending);
            }
            if (comboBox1.SelectedItem.ToString() == "Theo Lớp")
            {
                dataGridView.Sort(dataGridView.Columns["Lớp Cao học"], ListSortDirection.Ascending);
            }
            }
            catch
            {
                MessageBox.Show("Chọn loại sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
