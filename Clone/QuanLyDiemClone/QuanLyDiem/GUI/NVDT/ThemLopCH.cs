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
	public partial class ThemLopCH : Form
	{
        ThemLopCH_BLL bLL = new ThemLopCH_BLL();

        public ThemLopCH(string tenKhoa)
        {
            InitializeComponent();
            textBoxKhoa.Text = tenKhoa;
            LoadMaLop();
        }

        public bool checkMaLop()
        {
            if (textBoxMaLop.Text.Length != 3) return false;
            string s = textBoxMaLop.Text;
            for (int i = 0; i < 3; i++)
            {
                if (s[i] < '0' || s[i] > '9') return false;
            }
            return true;
        }

        void LoadMaLop()
        {
            string s = "";
            if (bLL.getSoLopBLL() + 1 < 100)
                s += "0";
            if (bLL.getSoLopBLL() + 1 < 10)
                s += "0";
            s += (bLL.getSoLopBLL() + 1);
            textBoxMaLop.Text = s;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!bLL.checkMaLopBLL("LCH" + textBoxMaLop.Text.Trim()))
                {
                    textBoxMaLop.Text = "";
                    MessageBox.Show("Lớp đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!bLL.checkTenLopBLL(textBoxTenLop.Text.Trim()))
                {
                    textBoxTenLop.Text = "";
                    MessageBox.Show("Tên Lớp đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        bLL.getAddLopBLL(new LopDaoTao
                        {
                            MaLop = "LCH" + textBoxMaLop.Text.Trim(),
                            TenLop = textBoxTenLop.Text.Trim(),
                            MaKhoa = bLL.getMaKhoaBLL(textBoxKhoa.Text.Trim()),
                        });
                        MessageBox.Show("Thêm lớp thành công");
                    }
                    catch
                    {
                        MessageBox.Show("Thêm lớp không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Dispose();
                }
                
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBoxMaLop_Validated(object sender, EventArgs e)
        {
            errorProviderLCH.SetError(textBoxMaLop, "");
        }

        private void textBoxMaLop_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidError.ValidMaSo(textBoxMaLop.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxMaLop.Select(0, textBoxMaLop.Text.Length);

                // Set the ErrorProvider error with the text to display.  
                this.errorProviderLCH.SetError(textBoxMaLop, errorMsg);
            }
        }
    }
}
