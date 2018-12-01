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
    public partial class MoreInfoHocVien : Form
    {
        BLL.HocVien_BLL bLL = new HocVien_BLL();
        //BLL.LuuAnhVaoDB_BLL lu = new LuuAnhVaoDB_BLL();
        BLL.MoreInfoHocVien_BLL more = new MoreInfoHocVien_BLL();

        public MoreInfoHocVien(string MaHV)
        {
            InitializeComponent();
            List<string> ls = more.getMoreInfoHV_BLL(MaHV);
            textBoxMSHV.Text = MaHV;
            textBoxNAME.Text = bLL.getHVBLL(MaHV);
            textBoxPassword.Text = ls[0].Trim();
            dpkNgaySinh.Value = Convert.ToDateTime(ls[1]);
            textBoxEmail.Text = ls[2].Trim();
            textBoxDienThoai.Text = ls[3].Trim();
            textBoxDiaChi.Text = ls[4].Trim();
        }

    }
}
