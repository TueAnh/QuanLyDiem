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

namespace QuanLyDiem.GUI
{
    public partial class ThemGiangVien : Form
    {
        ThemGiangVien_BLL bLL = new ThemGiangVien_BLL();
        public ThemGiangVien()
        {
            InitializeComponent();
        }

        //public bool checkMaGV()
        //{
        //    if (textBoxMaGV.Text.Length != 3) return false;
        //    string s = textBoxMaGV.Text;
        //    for (int i = 0; i < 3; i++)
        //    {
        //        if (s[i] < '0' || s[i] > '9') return false;
        //    }
        //    return true;
        //}
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxMaGV.Text == "")
            {
                MessageBox.Show("Không được để trống mã số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (bLL.checkGVBLL("GV" + textBoxMaGV.Text) && bLL.checkKhoaBLL(textBoxKhoa.Text))
                {
                    bLL.addGiangVienBLL(new GiangVien
                    {
                        ID = "GV" + textBoxMaGV.Text,
                        HoTen = textBoxHoTen.Text,
                        NgaySinh = dateTimePickerNS.Value,
                        DiaChi = textBoxDiaChi.Text,
                        Email = textBoxEmail.Text,
                        DienThoai = textBoxDienThoai.Text,
                        MaKhoa = bLL.getMaKhoaBLL(textBoxKhoa.Text),
                        Password = "",
                    });
                    MessageBox.Show("Thêm giảng viên thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thêm giảng viên không thành công thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            errorProviderGV.SetError(textBoxEmail, "");
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEmail.Text == "")
            {

            }
            else
            {
                string errorMsg;
                if (!ValidError.ValidEmailAddress(textBoxEmail.Text, out errorMsg))
                {
                    // Cancel the event and select the text to be corrected by the user.
                    e.Cancel = true;
                    textBoxEmail.Select(0, textBoxEmail.Text.Length);

                    // Set the ErrorProvider error with the text to display.  
                    this.errorProviderGV.SetError(textBoxEmail, errorMsg);
                }
            }
        }

        private void textBoxDienThoai_Validated(object sender, EventArgs e)
        {
            errorProviderGV.SetError(textBoxDienThoai, "");
        }

        private void textBoxDienThoai_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxDienThoai.Text == "")
            {

            }
            else
            {
                string errorMsg;
                if (!ValidError.ValidPhone(textBoxDienThoai.Text, out errorMsg))
                {
                    // Cancel the event and select the text to be corrected by the user.
                    e.Cancel = true;
                    textBoxDienThoai.Select(0, textBoxDienThoai.Text.Length);

                    // Set the ErrorProvider error with the text to display.  
                    this.errorProviderGV.SetError(textBoxDienThoai, errorMsg);
                }
            }
        }

        private void textBoxMaGV_Validated(object sender, EventArgs e)
        {
            errorProviderGV.SetError(textBoxMaGV, "");
        }

        private void textBoxMaGV_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidError.ValidMaSo(textBoxMaGV.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxMaGV.Select(0, textBoxMaGV.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errorProviderGV.SetError(textBoxMaGV, errorMsg);
            }
        }
    }
}
