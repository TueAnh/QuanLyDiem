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
	public partial class ThemHocVien : Form
	{
		ThemHocVien_BLL bLL = new ThemHocVien_BLL();
		public ThemHocVien(string MaLopCH, string LopCH)
		{
			InitializeComponent();
			textBoxLopCH.Text = LopCH;
			textBoxLopCH.ReadOnly = true;
			LoadMaLop();
		}

		public ThemHocVien()
		{
			InitializeComponent();
			LoadMaLop();
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
			if (bLL.getLopBLL(textBoxLopCH.Text) != null)
			{
				//try
				//{
				bLL.addHVBLL(new HocVien
				{
					ID = textBoxMaHV.Text,
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
				//}
				//catch
				//{
				//	MessageBox.Show("Nhập sai !! ");
				//}
			}
			else
			{
				MessageBox.Show("Lớp sai !!");
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
