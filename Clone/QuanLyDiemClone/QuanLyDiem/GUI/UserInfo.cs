﻿using QuanLyDiem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.GUI
{
    public partial class UserInfo : Form
    {
        public delegate void UpdateImageSuccess(byte[] a);
        public UpdateImageSuccess updateImageSuccess;
        User user;
        public UserInfo(string ID)
        {
            user = Login_BLL.BLL.GetUser(1, ID);
            InitializeComponent();
            if (FormLogin.User.typeAcc != 3)
                buttonUpdate.Enabled = false;
            buttonluuAnh.Enabled = false;
            LoadData(user);
        }
        public UserInfo(User user)
        {
            this.user = user;
            InitializeComponent();
            buttonluuAnh.Enabled = false;
            LoadData(user);
        }
        public void LoadData(User user)
        {
            if (user.typeAcc == 1)
                textBoxType.Text = "Học viên";
            else if (user.typeAcc == 2)
                textBoxType.Text = "Giảng viên";
            else
                textBoxType.Text = "Nhân viên";
            textBoxID.Text = user.ID.Trim();
            textBoxAddress.Text = user.DiaChi.Trim();
            textBoxDienThoai.Text = user.DienThoai.Trim();
            textBoxEmail.Text = user.Email.Trim();
            textBoxName.Text = user.displayName.Trim();
            textBoxPassword.Text = user.PassWord.Trim();
            dpkNgaySinh.Value = user.NgaySinh;
            loadImage(user.Image);
        }

        private void panelBG_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelBG.ClientRectangle, Color.Blue, ButtonBorderStyle.Solid);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Red, ButtonBorderStyle.Dashed);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.DisplayRectangle, Color.Yellow, ButtonBorderStyle.Dashed);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User tmp = user;
            tmp.DienThoai = textBoxDienThoai.Text.Trim();
            tmp.Email = textBoxEmail.Text.Trim();
            tmp.displayName = textBoxName.Text.Trim();
            tmp.PassWord = textBoxPassword.Text.Trim();
            tmp.NgaySinh = dpkNgaySinh.Value;
            tmp.DiaChi = textBoxAddress.Text.Trim();
            if (UserInfo_BLL.BLL.UpdateUser(user))
            {
                MessageBox.Show("Thay đổi thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Refresh();
                //LoadData(user);
                user = tmp;
            }
            else
            {
                MessageBox.Show("Thay đổi không thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadData(user);
            }
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

        private void buttonDoiAnhDD_Click(object sender, EventArgs e)
        {
            Image tam = null;
            if (pictureBox1.Image != null) tam = pictureBox1.Image;
            try
            {
                openFile.ShowDialog();
                string file = openFile.FileName;
                if (string.IsNullOrEmpty(file)) return;
                byte[] data = File.ReadAllBytes(file);
                MemoryStream mem = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(mem);
            }
            catch
            {
                return;
            }
            DialogResult result = MessageBox.Show("Đã chọn ảnh ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                buttonluuAnh.Enabled = true;
            }
            if (result == DialogResult.Cancel)
            {
                pictureBox1.Image = tam;
            }
        }

        private void buttonluuAnh_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            try
            {
                pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
                pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            }
            catch
            {
                MessageBox.Show("Nên định dạng ảnh PNG hoặc JPG.");
            }
            try
            {
                Login_BLL.BLL.luuAnh_BLL(user.typeAcc,user.ID, stream.ToArray());
            }
            catch
            {
                MessageBox.Show("Chưa thành công , chọn ảnh lại");
                buttonluuAnh.Enabled = false;
                return;
            }
            MessageBox.Show("Đã cập nhật ảnh đại diện");
            user.Image = stream.ToArray();
            loadImage(stream.ToArray());
            if (FormLogin.User.ID.Trim() == user.ID.Trim())
                updateImageSuccess(stream.ToArray());
            buttonluuAnh.Enabled = false;
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidError.ValidMatKhau(textBoxPassword.Text, out errorMsg))
            {
                e.Cancel = true;
                textBoxPassword.Select(0, textBoxPassword.Text.Length);

                this.errorProviderUser.SetError(textBoxPassword, errorMsg);
            }
        }

        private void textBoxPassword_Validated(object sender, EventArgs e)
        {
            errorProviderUser.SetError(textBoxPassword, "");
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

                    this.errorProviderUser.SetError(textBoxEmail, errorMsg);
                }
            }
        }

        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            errorProviderUser.SetError(textBoxEmail, "");
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

                    this.errorProviderUser.SetError(textBoxDienThoai, errorMsg);
                }
            }
        }

        private void textBoxDienThoai_Validated(object sender, EventArgs e)
        {
            errorProviderUser.SetError(textBoxDienThoai, "");
        }
    }
 }

