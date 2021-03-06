﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiem.BLL;

namespace QuanLyDiem.GUI.NVDT
{
	public partial class ThemHocVien : Form
	{
		ThemHocVien_BLL bLL = new ThemHocVien_BLL();
		public ThemHocVien(string MaLopCH, string LopCH)
		{
			InitializeComponent();
			textBoxLopCH.Text = LopCH;
			textBoxLopCH.ReadOnly = true;
			//LoadMaLop();
		}

		public ThemHocVien()
		{
			InitializeComponent();
			//LoadMaLop();
		}
		void LoadMaLop()
		{
			string s = "HV";
			if (bLL.getSoHocVienBLL() + 1 < 100)
				s += "0";
			if (bLL.getSoHocVienBLL() + 1 < 10)
				s += "0";
			s += (bLL.getSoHocVienBLL() + 1);
			textBoxMaHV.Text = s;
			textBoxMaHV.ReadOnly = true;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
            if (textBoxMaHV.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền mã học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!bLL.checkHocVienBLL("HV" + textBoxMaHV.Text.Trim()))
            {
                MessageBox.Show("Học viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bLL.getLopBLL(textBoxLopCH.Text) == null)
            {
                MessageBox.Show("Không thể thêm học viên vào lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền tên học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bLL.addHVBLL(new HocVien
                    {
                        ID = "HV" + textBoxMaHV.Text,
                        HoTen = textBoxHoTen.Text,
                        NgaySinh = dateTimePickerNS.Value,
                        MaLop = bLL.getLopBLL(textBoxLopCH.Text),
                        DiaChi = textBoxDiaChi.Text,
                        Email = textBoxEmail.Text,
                        DienThoai = textBoxDienThoai.Text,
                        Password = "",
                    });
                    MessageBox.Show("Thêm học viên thành công");
                    this.Dispose();
                }
                catch
                {
                    MessageBox.Show("Thêm học viên không thành công");
                }
            }
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            errorProviderHV.SetError(textBoxEmail, "");
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
                    e.Cancel = true;
                    textBoxEmail.Select(0, textBoxEmail.Text.Length);

                    this.errorProviderHV.SetError(textBoxEmail, errorMsg);
                }
            }
        }

        private void textBoxDienThoai_Validated(object sender, EventArgs e)
        {
            errorProviderHV.SetError(textBoxDienThoai, "");
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
                    e.Cancel = true;
                    textBoxDienThoai.Select(0, textBoxDienThoai.Text.Length);

                    this.errorProviderHV.SetError(textBoxDienThoai, errorMsg);
                }
            }
        }

        private void textBoxMaHV_Validated(object sender, EventArgs e)
        {
            errorProviderHV.SetError(textBoxMaHV, "");
        }

        private void textBoxMaHV_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidError.ValidMaSo(textBoxMaHV.Text, out errorMsg))
            {
                e.Cancel = true;
                textBoxMaHV.Select(0, textBoxMaHV.Text.Length);

                this.errorProviderHV.SetError(textBoxMaHV, errorMsg);
            }
        }
    }
}
