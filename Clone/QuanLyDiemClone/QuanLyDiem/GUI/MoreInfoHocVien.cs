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
using System.Drawing.Imaging; //
using System.IO;

namespace QuanLyDiem.GUI
{
    public partial class MoreInfoHocVien : Form
    {
        BLL.HocVien_BLL bLL = new HocVien_BLL();
        BLL.MoreInfoHocVien_BLL more = new MoreInfoHocVien_BLL();

        public MoreInfoHocVien(string MaHV)
        {
            InitializeComponent();
            List<string> ls = more.getMoreInfoHV_BLL(MaHV);
            textBoxMSHV.Text = MaHV;
			HocVien hv = bLL.getHVBLL(MaHV);
			textBoxNAME.Text = hv.HoTen;
			textBoxPassword.Text = ls[0].Trim();
            dpkNgaySinh.Value = Convert.ToDateTime(ls[1]);
            textBoxEmail.Text = ls[2].Trim();
            textBoxDienThoai.Text = ls[3].Trim();
            textBoxDiaChi.Text = ls[4].Trim();
            loadImage();
            buttonLuuAnh.Visible = false;
        }

        private void buttonDoiAnh_Click(object sender, EventArgs e)
        {
            //Image tam = null;
            //if (pictureBox.Image != null) tam = pictureBox.Image;
            //try
            //{
            //    openFile.ShowDialog();
            //    string file = openFile.FileName;
            //    if (string.IsNullOrEmpty(file)) return;
            //    byte[] data = File.ReadAllBytes(file);
            //    MemoryStream mem = new MemoryStream(data);
            //    pictureBox.Image = Image.FromStream(mem);
            //}
            //catch
            //{
            //    return;
            //}
            //DialogResult result = MessageBox.Show("lưu thay đổi ", "Update",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    try
            //    {
            //        MemoryStream stream = new MemoryStream();
            //        pictureBox.Image.Save(stream, ImageFormat.Jpeg);
            //        pictureBox.Image.Save(stream, pictureBox.Image.RawFormat);
            //        more.luuAnh_BLL(textBoxMSHV.Text.Trim(), stream.ToArray());

            //    }
            //    catch
            //    {
            //        MessageBox.Show("Chưa thành công , chọn ảnh lại");
            //        return;
            //    }
            //    MessageBox.Show("Đã cập nhật ảnh đại diện");
            //}
            //if (result == DialogResult.Cancel)
            //{
            //    pictureBox.Image = tam;
            //}

        }
        public void loadImage()
        {
            
            //byte[] data = more.TaiAnh_BLL(textBoxMSHV.Text.Trim());
            //if (data == null)
            //{
            //    pictureBox.Image = null;
            //}
            //else
            //{
            //    MemoryStream memoryStream = new MemoryStream(data);
            //    pictureBox.Image = Image.FromStream(memoryStream);
            //}
        }

        private void buttonLuuAnh_Click(object sender, EventArgs e)
        {
            //MemoryStream stream = new MemoryStream();
            //pictureBox.Image.Save(stream, ImageFormat.Jpeg);
            //pictureBox.Image.Save(stream, pictureBox.Image.RawFormat);
            //try
            //{
            //    more.luuAnh_BLL(textBoxMSHV.Text.Trim(), stream.ToArray());
            //}
            //catch
            //{
            //    MessageBox.Show("Chưa thành công , chọn ảnh lại");
            //    return;
            //}
            //loadImage();
            //MessageBox.Show("Đã cập nhật ảnh đại diện");
        }
    }
}
