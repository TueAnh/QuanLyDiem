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
using Microsoft.Office.Interop.Excel; // nho Add them:  Reference\ interop.excel
using app = Microsoft.Office.Interop.Excel.Application;
using System.IO;

namespace QuanLyDiem.GUI
{
    public partial class FormViewHV : Form
    {

        public delegate void AddRemoveControl(Form form);
        public AddRemoveControl addControl;
        public AddRemoveControl removeControl;
        public void AddControlPanel(Form form)
        {
            addControl(form);
        }
        public void RemoveControlPanel(Form form)
        {
            removeControl(form);
        }
        BLL.HocVien_BLL bLL = new HocVien_BLL();
        string MaHV;
        List<int> strNH = new List<int>();
        List<string> strHK = new List<string>();
        List<int> strHKNH = new List<int>();
        public FormViewHV(string str)
        {
            MaHV = FormHome.UserAcc.ID;
            MemoryStream stream = new MemoryStream();
            InitializeComponent();
            LoadData();
            User HV = Login_BLL.BLL.GetUser(1, MaHV);
            loadImage(HV.Image);
        }
        public void loadImage(byte[] data)
        {

            if (data == null)
            {
                pictureBox1.Image = null;
            }
            else
            {
                MemoryStream memoryStream = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(memoryStream);
            }
        }
        public void LoadData()
        {
            textBoxMSHV.Text = MaHV;
            textBoxNAME.Text = bLL.getHVBLL(MaHV);
            dataGridViewDTBvXL.Columns.Clear();
            dataGridViewDTBvXL.Columns.Add("STT", "STT");
            dataGridViewXemDiem.Columns.Clear();
            dataGridViewXemDiem.Columns.Add("STT", "STT");
            dataGridViewDTBvXL.DataSource = bLL.getDTBvXLBLL(MaHV);
            dataGridViewDTBvXL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            radioButtonQuaTrinh.Checked = true;
            dataGridViewXemDiem.DataSource = bLL.getDiemQTBLL(MaHV);
            dataGridViewXemDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewXemDiem.Columns[dataGridViewXemDiem.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewDTBvXL.Columns["STT"].Width = 50;
            dataGridViewXemDiem.Columns["STT"].Width = 50;
            loadCBB();
        }
        private void loadCBB()
        {
            strHKNH = bLL.loadCBBNHBLL(MaHV);
            foreach (int x in strHKNH)
            {
                int index = 0;
                foreach (int y in strNH)
                {
                    if (y == x) index = 1;
                }
                if (index == 0)
                {
                    strNH.Add(x);
                }
            }
            strHK = bLL.loadCBBHKBLL(MaHV);
        }
        #region radioBTT
        private void radioButtonQuaTrinh_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDoanXem.Items.Clear();
            comboBoxDoanXem.ResetText();
        }

        private void radioButtonNamHoc_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDoanXem.Items.Clear();
            comboBoxDoanXem.ResetText();
            if (radioButtonNamHoc.Checked == true)
            {
                comboBoxDoanXem.Items.Clear();
                foreach (int y in strNH)
                {
                    comboBoxDoanXem.Items.Add("Năm học " + y + " - " + (y + 1));

                }
            }
        }

        private void radioButtonHocKi_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDoanXem.Items.Clear();
            comboBoxDoanXem.ResetText();
            if (radioButtonHocKi.Checked == true)
            {
                for (int i = 0; i < strHK.Count; i++)
                {
                    comboBoxDoanXem.Items.Add(strHK[i] + " Năm học " + strHKNH[i] + " - " + (strHKNH[i] + 1));
                }
            }
        }
        #endregion

        private void buttonXem_Click(object sender, EventArgs e)
        {
            if (radioButtonQuaTrinh.Checked == true)
            {
                comboBoxDoanXem.Items.Clear();
                comboBoxDoanXem.SelectedText = "";
                dataGridViewXemDiem.DataSource = null;
                dataGridViewXemDiem.DataSource = bLL.getDiemQTBLL(MaHV);
                dataGridViewXemDiem.Columns[dataGridViewXemDiem.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            if (radioButtonNamHoc.Checked == true)
            {
                dataGridViewXemDiem.DataSource = null;
                if (comboBoxDoanXem.SelectedIndex >= 0)
                {
                    dataGridViewXemDiem.DataSource = bLL.getDiemNHBLL(MaHV, strNH[comboBoxDoanXem.SelectedIndex]);
                    dataGridViewXemDiem.Columns[dataGridViewXemDiem.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else MessageBox.Show("Chọn Năm Học");
            }
            if (radioButtonHocKi.Checked == true)
            {
                dataGridViewXemDiem.DataSource = null;
                if (comboBoxDoanXem.SelectedIndex >= 0)
                {
                    dataGridViewXemDiem.DataSource = bLL.getDiemHKBLL(MaHV, strHKNH[comboBoxDoanXem.SelectedIndex],
                                                                  strHK[comboBoxDoanXem.SelectedIndex]);
                    dataGridViewXemDiem.Columns[dataGridViewXemDiem.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else MessageBox.Show("Chọn Học Kì / Năm Học");
            }
            dataGridViewXemDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void exportToExcel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 15;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
            MessageBox.Show("File Excel được lưu vào : " + duongDan + tenTap + ".xlsx");
        }

        private void buttonInBangDiem_Click(object sender, EventArgs e)
        {
            exportToExcel(dataGridViewXemDiem, @"F:\", "InBangDiem");
        }
        private void buttonMore_Click(object sender, EventArgs e)
        {
            //MoreInfoHocVien moreInfo = new MoreInfoHocVien(textBoxMSHV.Text);
            //moreInfo.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridViewDTBvXL_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < dataGridViewDTBvXL.Rows.Count)
                this.dataGridViewDTBvXL.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridViewXemDiem_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < dataGridViewXemDiem.Rows.Count)
                this.dataGridViewXemDiem.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
