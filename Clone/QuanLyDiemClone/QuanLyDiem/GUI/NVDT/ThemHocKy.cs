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
    public partial class ThemHocKy : Form
    {
        ThemHocKy_BLL themHocKy_BLL;
        string nam = "";
        public delegate void ThemHKSuccess();
        public ThemHKSuccess themHKSuccess;
        public ThemHocKy()
        {
            InitializeComponent();
            themHocKy_BLL = new ThemHocKy_BLL();
            dateTimePicker2.Enabled = false;
            textBoxNamHoc.Enabled = false;
            LoadMaHK();
            loadCbbHocKi();
            textBoxNamHoc.Text = dateTimePicker1.Value.Year + " - " + (dateTimePicker1.Value.Year + 1).ToString();
            comboBoxHocKi.SelectedIndex = 0;
        }
        void LoadMaHK()
        {
            string s = "HK";
            if (themHocKy_BLL.getSoHK_DAL() + 1 < 100)
                s += "0";
            if (themHocKy_BLL.getSoHK_DAL() + 1 < 10)
                s += "0";
            s += (themHocKy_BLL.getSoHK_DAL() + 1);
            textBoxMaHK.Text = s;
            textBoxMaHK.Enabled = false;
        }
        void loadCbbHocKi()
        {
            comboBoxHocKi.Items.Add("Học Kì 1");
            comboBoxHocKi.Items.Add("Học Kì 2");
        }



        private void buttonLuuMoi_Click(object sender, EventArgs e)
        {
            if (themHocKy_BLL.ChecKExistHK_BLL(textBoxMaHK.Text.Trim()))
            {
                textBoxMaHK.Text = "";
                MessageBox.Show("Học Kì đã tồn tại");
            }
            else if (themHocKy_BLL.CheckExistMore2HocKi_BLL(comboBoxHocKi.Text, Convert.ToInt16(nam)))
            {
                textBoxNamHoc.Text = "";
                MessageBox.Show("Đã tồn tại " + comboBoxHocKi.Text + " trong năm " + nam.ToString());
            }
            
            else
            {
                try
                {
                    themHocKy_BLL.ThemHK_BLL(textBoxMaHK.Text.Trim(),
                                       comboBoxHocKi.Text,
                                       Convert.ToDateTime(dateTimePicker1.Value),
                                       Convert.ToDateTime(dateTimePicker2.Value),
                                       Convert.ToInt16(nam));

                    MessageBox.Show("Đã thêm mới học Kì");
                    themHKSuccess();
                    this.Dispose();
                }
                catch
                {
                    MessageBox.Show("Thêm mới không thành công");
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            nam = dateTimePicker1.Value.Year.ToString();
            textBoxNamHoc.Text = nam + " - " + (dateTimePicker1.Value.Year + 1).ToString();
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(9);
            TimeSpan diff = dateTimePicker1.Value - DateTime.Now;
            if (diff.Days < 0)
            {
                MessageBox.Show("Thời gian bắt đầu không phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
