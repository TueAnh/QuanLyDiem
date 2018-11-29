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
    public partial class SuaDiemHocVienDT : Form
    {
        SuaDiemHocVienDT_BLL sua;
        public SuaDiemHocVienDT(string MaHV,string MaHP)
        {
            sua = new SuaDiemHocVienDT_BLL();
            InitializeComponent();
            labelMaHV.Text = MaHV;
            labelMaHP.Text = MaHP;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            sua.suaDiemHocVien_BLL(labelMaHV.Text,labelMaHP.Text,Convert.ToDouble(textboxSuaDiemBT.Text), Convert.ToDouble(textboxSuaDiemGK.Text), Convert.ToDouble(textboxSuaDiemThi.Text));
            Dispose();
        }
    }
}
