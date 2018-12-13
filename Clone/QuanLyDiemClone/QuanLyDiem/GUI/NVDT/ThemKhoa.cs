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
    public partial class ThemKhoa : Form
    {
        ThemKhoa_BLL themKhoa_Bll;
        public delegate void ThemKhoaSuccess();
        public ThemKhoaSuccess themKhoaSuccess;
        public ThemKhoa()
        {
            InitializeComponent();
            themKhoa_Bll = new ThemKhoa_BLL();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (textBoxMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống mã Khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống tên Khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (themKhoa_Bll.ChecKExistKHoa_BLL(textBoxMaKhoa.Text.Trim()))
                {
                    textBoxMaKhoa.Text = "";
                    MessageBox.Show("Khoa đã tồn tại");
                }
                else
                {
                    try
                    {
                        themKhoa_Bll.themKhoa_BLL(new Khoa
                        {
                            MaKhoa = textBoxMaKhoa.Text.Trim(),
                            TenKhoa = textBoxTenKhoa.Text.Trim()
                        });

                        MessageBox.Show("Đã thêm mới Khoa");
                        themKhoaSuccess();
                        this.Dispose();
                    }
                    catch
                    {
                        MessageBox.Show("Thêm mới không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
