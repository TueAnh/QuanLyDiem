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
        public ThemHocKy()
        {
            InitializeComponent();
            themHocKy_BLL = new ThemHocKy_BLL();
            textBoxHK.Text = "HK";
            textBoxHK.Enabled = false;
            loadCbbHocKi();
        }
        void loadCbbHocKi()
        {
            comboBoxHocKi.Items.Add("Học Kì 1");
            comboBoxHocKi.Items.Add("Học Kì 2");
        }

        private void buttonLuuMoi_Click(object sender, EventArgs e)
        {
            if (themHocKy_BLL.ChecKExistHK_BLL(textBoxHK.Text+ textBoxMaHK.Text.Trim()))
            {
                textBoxMaHK.Text = "";
                MessageBox.Show("Học Kì đã tồn tại");
            }
            else
            {
                //try
                //{
                themHocKy_BLL.ThemHK_BLL(textBoxHK.Text + textBoxMaHK.Text.Trim(),
                                       comboBoxHocKi.Text,
                                       Convert.ToDateTime(dateTimePicker1.Value),
                                       Convert.ToDateTime(dateTimePicker2.Value),
                                       Convert.ToInt16(textBoxNamHoc.Text));

                MessageBox.Show("Đã thêm mới học Kì");
                //}
                //catch
                //{
                //    MessageBox.Show("Thêm mới không thành công");
                //}
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBoxNamHoc.Text = dateTimePicker1.Value.Year.ToString();
            //textBoxNamHoc.Text = dateTimePicker1.Value.Year.ToString() + " - " + (dateTimePicker1.Value.Year+1).ToString();
        }
    }
}
