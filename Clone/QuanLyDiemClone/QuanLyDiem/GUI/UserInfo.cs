using QuanLyDiem.BLL;
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
            tmp.DienThoai = textBoxDienThoai.Text;
            tmp.Email = textBoxEmail.Text;
            tmp.displayName = textBoxName.Text;
            tmp.PassWord = textBoxPassword.Text;
            tmp.NgaySinh = dpkNgaySinh.Value;
            tmp.DiaChi = textBoxAddress.Text;
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
                pictureBox.Image = null;
            }
            else
            {
                MemoryStream memoryStream = new MemoryStream(data);
                pictureBox.Image = Image.FromStream(memoryStream);
            }
        }

        private void buttonDoiAnhDD_Click(object sender, EventArgs e)
        {
            Image tam = null;
            if (pictureBox.Image != null) tam = pictureBox.Image;
            try
            {
                openFile.ShowDialog();
                string file = openFile.FileName;
                if (string.IsNullOrEmpty(file)) return;
                byte[] data = File.ReadAllBytes(file);
                MemoryStream mem = new MemoryStream(data);
                pictureBox.Image = Image.FromStream(mem);
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
                pictureBox.Image = tam;
            }
        }

        private void buttonluuAnh_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureBox.Image.Save(stream, ImageFormat.Jpeg);
            pictureBox.Image.Save(stream, pictureBox.Image.RawFormat);
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
            if (FormLogin.User.ID.Trim() == user.ID.Trim())
                updateImageSuccess(stream.ToArray());
            buttonluuAnh.Enabled = false;
        }
    }
   }

