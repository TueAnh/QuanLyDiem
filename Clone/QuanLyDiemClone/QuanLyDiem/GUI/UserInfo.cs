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
    public partial class UserInfo : Form
    {
        User user;
        public UserInfo(string ID)
        {
            user = Login_BLL.BLL.GetUser(1, ID);
            InitializeComponent();
            if (FormLogin.User.typeAcc != 3)
                buttonUpdate.Enabled = false;
            LoadData(user);
        }
        public UserInfo(User user)
        {
            this.user = user;
            InitializeComponent();
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
    }
   }

