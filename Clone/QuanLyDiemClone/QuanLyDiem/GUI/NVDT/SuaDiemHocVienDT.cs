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
        public delegate void SaveSuccess();
        public SaveSuccess saveSuccess;
        public void LoadData()
        {
            KetQuaHocPhan kq = sua.GetDiem_BLL(textBoxMaHV.Text, textBoxMaHP.Text);
            textboxSuaDiemBT.Text = kq.DiemBT.ToString();
            textboxSuaDiemGK.Text = kq.DiemGK.ToString();
            textboxSuaDiemThi.Text = kq.DiemThi.ToString();
        }
        public SuaDiemHocVienDT(string MaHV, string MaHP, string DBT = "", string DGK="", string DT="")
        {

            InitializeComponent();
            textBoxMaHV.Text = MaHV.Trim();
            textBoxMaHP.Text = MaHP.Trim();
            LoadData();
            Edit();
        }
        public void Edit()
        {
            if (FormLogin.User.typeAcc == 2 && !sua.Check_TMP(textBoxMaHP.Text))
                return;
            if (FormLogin.User.typeAcc >= 2)
                {
                    if (sua.HanNhapDiemGiuaKi_BLL(textBoxMaHP.Text))
                    {
                        textboxSuaDiemBT.ReadOnly = false;
                        textboxSuaDiemGK.ReadOnly = false;
                        buttonSave.Enabled = true;
                    }
                    if (sua.HanNhapDiemThi_BLL(textBoxMaHP.Text))
                    {
                        textboxSuaDiemThi.ReadOnly = false;
                    }
            }
        }
        public SuaDiemHocVienDT(KetQuaHocPhan kq)
        {

            InitializeComponent();
            textBoxMaHV.Text = kq.ID.Trim();
            textBoxMaHP.Text = kq.MaHP.Trim();
            LoadData();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                sua.suaDiemHocVien_BLL(textBoxMaHV.Text, textBoxMaHP.Text, Convert.ToDouble(textboxSuaDiemBT.Text), Convert.ToDouble(textboxSuaDiemGK.Text), Convert.ToDouble(textboxSuaDiemThi.Text));
                saveSuccess();
                removeControl(this);
                Dispose();
            }
            catch
            {
                MessageBox.Show("Sửa điểm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            removeControl(this);
            this.Dispose();
        }
    }
}
