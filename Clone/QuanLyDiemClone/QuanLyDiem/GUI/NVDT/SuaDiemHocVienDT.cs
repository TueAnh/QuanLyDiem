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
        public delegate void AddRemoveControl(Form form);
        public AddRemoveControl removeControl;
        SuaDiemHocVienDT_BLL sua = new SuaDiemHocVienDT_BLL();
        public void LoadData()
        {
            KetQuaHocPhan kq = sua.GetDiem_BLL(labelMaHV.Text, labelMaHP.Text);
            textboxSuaDiemBT.Text = kq.DiemBT.ToString();
            textboxSuaDiemGK.Text = kq.DiemGK.ToString();
            textboxSuaDiemThi.Text = kq.DiemThi.ToString();
        }
        public SuaDiemHocVienDT(string MaHV, string MaHP, string DBT = "", string DGK="", string DT="")
        {

            InitializeComponent();
            labelMaHV.Text = MaHV;
            labelMaHP.Text = MaHP;
            LoadData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            sua.suaDiemHocVien_BLL(labelMaHV.Text, labelMaHP.Text, Convert.ToDouble(textboxSuaDiemBT.Text), Convert.ToDouble(textboxSuaDiemGK.Text), Convert.ToDouble(textboxSuaDiemThi.Text));
            //Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            removeControl(this);
            this.Dispose();
        }
    }
}
