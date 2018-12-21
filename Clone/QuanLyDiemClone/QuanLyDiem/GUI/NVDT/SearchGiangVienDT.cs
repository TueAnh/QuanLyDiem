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
    public partial class SearchGiangVienDT : Form
    {
        SearchGiangVien_BLL bLL = new SearchGiangVien_BLL();
        public delegate void AddRemoveControl(Form form);
        public AddRemoveControl addControl;
        public AddRemoveControl removeControl;
        public void AddControlPanel(Form form)
        {
            //addControl(form);
            form.TopLevel = false;
            this.panel1.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.None;
            if (panel1.Controls.Count > 1)
                this.panel1.Controls[panel1.Controls.Count - 2].Hide();
            this.panel1.Controls[panel1.Controls.Count - 1].Show();
        }
        public void RemoveControlPanel(Form form)
        {
            //removeControl(form);
            this.panel1.Controls.Remove(form);
            if (panel1.Controls.Count > 1)
                this.panel1.Controls[panel1.Controls.Count - 2].Hide();
            this.panel1.Controls[panel1.Controls.Count - 1].Show();
        }
        public SearchGiangVienDT()
        {
            InitializeComponent();
            LoadDTG();
        }
        public void LoadDTG()
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("STT", "STT");
            dataGridView.DataSource = bLL.getDSGVBLL();
            dataGridView.Columns["STT"].Width = 50;
        }

        private void buttonAddGV_Click(object sender, EventArgs e)
        {
            ThemGiangVien f = new ThemGiangVien();
            f.Show();
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "Theo Tên")
                {
                    dataGridView.Sort(dataGridView.Columns["Tên"], ListSortDirection.Ascending);
                }
                if (comboBox1.SelectedItem.ToString() == "Theo Mã")
                {
                    dataGridView.Sort(dataGridView.Columns["Mã GV"], ListSortDirection.Ascending);
                }
            }
            catch
            {

            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (bLL.XoaGV(dataGridView.SelectedRows[0].Cells["Mã GV"].Value.ToString().Trim()))
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Lưu ý bạn không được xóa giảng viên đang giảng dạy!");
            }
            LoadDTG();

        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                FormViewGV form = new FormViewGV(dataGridView.SelectedRows[0].Cells["Mã GV"].Value.ToString().Trim());
                form.addControl += new FormViewGV.AddRemoveControl(AddControlPanel);
                form.removeControl += new FormViewGV.AddRemoveControl(RemoveControlPanel);
                AddControlPanel(form);
            }
        }

        private void buttonReLoad_Click(object sender, EventArgs e)
        {
            LoadDTG();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("STT", "STT");
            dataGridView.DataSource = bLL.LoadSearchedHocVien(textBoxSearchMaGV_HoTen.Text);
            dataGridView.Columns["STT"].Width = 50;
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < dataGridView.Rows.Count)
                this.dataGridView.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
