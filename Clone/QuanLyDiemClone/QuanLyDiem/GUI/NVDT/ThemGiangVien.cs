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
			loadCBB();
		}

		public void loadCBB()
		{
			List<string> listKhoa = bLL.getDSKhoaBLL();
			foreach (string s in listKhoa)
			{
				comboBoxKhoa.Items.Add(s);
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền mã giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!bLL.checkGVBLL("GV" + textBoxMaGV.Text.Trim()))
            {
                MessageBox.Show("Giảng viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxKhoa.SelectedIndex <= -1)
            {
                MessageBox.Show("Hãy chọn khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền tên giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bLL.addGiangVienBLL(new GiangVien
                    {
                        ID = "GV" + textBoxMaGV.Text.Trim(),
                        HoTen = textBoxHoTen.Text.Trim(),
                        NgaySinh = dateTimePickerNS.Value,
                        DiaChi = textBoxDiaChi.Text.Trim(),
                        Email = textBoxEmail.Text.Trim(),
                        DienThoai = textBoxDienThoai.Text.Trim(),
                        MaKhoa = bLL.getMaKhoaBLL(comboBoxKhoa.SelectedItem.ToString()),
                        Password = "",
                    });
                    MessageBox.Show("Thêm giảng viên thành công");
                    this.Dispose();
                }
                catch
                {
                    MessageBox.Show("Thêm giảng viên không thành công");
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
