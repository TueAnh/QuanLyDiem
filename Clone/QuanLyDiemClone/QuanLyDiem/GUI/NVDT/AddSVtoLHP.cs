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
    public partial class AddSVtoLHP : Form
    {
        SearchHocVien_BLL Search_bll = new SearchHocVien_BLL();
        string MaHP;
        public AddSVtoLHP(string MaHP)
        {
            InitializeComponent();
            LoadData();
            this.MaHP = MaHP;
        }
        public void LoadData()
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("STT", "STT");
            dataGridView.DataSource = Search_bll.LoadAllHocVien();
            dataGridView.Columns["STT"].Width = 50;
        }
        private void buttonReLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSearchMaHV_HoTen_Click(object sender, EventArgs e)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("STT", "STT");
            dataGridView.DataSource = Search_bll.LoadSearchedHocVien(textBoxSearchMaHV_HoTen.Text);
            dataGridView.Columns["STT"].Width = 50;
        }
        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < dataGridView.Rows.Count)
                this.dataGridView.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }
        private void buttonSort_Click_1(object sender, EventArgs e)
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
            if (comboBox1.SelectedItem.ToString() == "Theo Khoa")
            {
                dataGridView.Sort(dataGridView.Columns["Khoa"], ListSortDirection.Ascending);
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonAddHV_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                if (Search_bll.AddHV_BLL(dataGridView.SelectedRows[i].Cells["Mã HV"].Value.ToString().Trim(),MaHP))
                {
                    dataGridView.SelectedRows[i].DefaultCellStyle.BackColor = Color.Lime;
                }
                else
                {
                    dataGridView.SelectedRows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            dataGridView.ClearSelection();
        }
    }
}
