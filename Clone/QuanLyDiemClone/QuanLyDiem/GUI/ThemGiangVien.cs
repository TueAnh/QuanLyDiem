using System;
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
	public partial class ThemGiangVien : Form
	{
		ThemGiangVien_BLL bLL = new ThemGiangVien_BLL();

		public ThemGiangVien()
		{
			InitializeComponent();
		}

		public bool checkMaGV()
		{
			if (textBoxMaGV.Text.Length != 3) return false;
			string s = textBoxMaGV.Text;
			for (int i = 0; i < 3; i++)
			{
				if (s[i] < '0' || s[i] > '9') return false;
			}
			return true;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (checkMaGV() && textBoxHoTen.Text != "" && bLL.checkGVBLL("GV" + textBoxMaGV.Text) && bLL.checkKhoaBLL(textBoxKhoa.Text))
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
				MessageBox.Show("Nhập sai !!");
			}

		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
