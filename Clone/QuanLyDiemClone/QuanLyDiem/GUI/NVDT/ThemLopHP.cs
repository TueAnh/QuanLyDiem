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
    public partial class ThemLopHP : Form
    {
        List<string> lID = new List<string>();
        List<string> lHoTen = new List<string>();
        List<string> lMaHK = new List<string>();
        List<string> lTenHK = new List<string>();
        List<string> lNamHoc = new List<string>();
        List<int> strGV = new List<int>();
        ThemLopHP_BLL themHP_BLL;
        public delegate void ThemHPSuccess();
        public ThemHPSuccess themHPSuccess;
        public ThemLopHP()
        {
            InitializeComponent();
            themHP_BLL = new ThemLopHP_BLL();
            loadCbb();
            if (FormLogin.User.typeAcc != 3)
            {
                buttonLuuMoi.Visible = false;
            }
        }
        public ThemLopHP(string ID)
        {
            InitializeComponent();
            themHP_BLL = new ThemLopHP_BLL();
            loadCbb();
            LoadData(ID);
            buttonLuuThayDoi.Visible = true;
            buttonLuuMoi.Visible = false;
        }
        public void LoadData(string ID)
        {
            string x = "", y = "";
            HocPhan hp = themHP_BLL.GetHocPhan(ID, ref x, ref y);
            if (hp != null)
            {
                string[] data = hp.MaHP.Trim().Split('P');
                textBoxMaHP.Text = data[1];
                textBoxPTDiemGiuaKi.Text = hp.PhanTramDGK.ToString();
                textBoxPTDiemThi.Text = hp.PhanTramDT.ToString();
                textBoxSoTiet.Text = hp.SoTiet.ToString();
                textBoxSoTinChi.Text = hp.SoTC.ToString();
                textBoxTenHP.Text = hp.TenHP.Trim();
                comboBoxTenHK.SelectedItem = comboBoxTenHK.Items[lMaHK.IndexOf(x)];
                comboBoxTenGV.SelectedItem = comboBoxTenGV.Items[lID.IndexOf(y)];

            }
        }
        
        public void loadCbb()
        {
            themHP_BLL.loadGV_BLL(lID, lHoTen);
            for (int i= 0; i < lID.Count; i++)
            {
                comboBoxTenGV.Items.Add(lID[i].Trim() + " - " + lHoTen[i].Trim());
            }
            themHP_BLL.loadHK_NH_BLL(lMaHK, lTenHK,lNamHoc);
            for (int i = 0; i < lMaHK.Count; i++)
            {
                comboBoxTenHK.Items.Add(lMaHK[i].Trim() + " - " + lTenHK[i].Trim() + " - " + lNamHoc[i].Trim());
            }
        }
        private void buttonLuuMoi_Click(object sender, EventArgs e)
        {
            if (textBoxMaHP.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống mã học phần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxTenHP.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống tên học phần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (themHP_BLL.ChecKExistHP_BLL("HP"+ textBoxMaHP.Text.Trim()))
            {
                textBoxMaHP.Text= "";
                MessageBox.Show("Học phần đã tồn tại");
                
            }
            else if (comboBoxTenHK.SelectedIndex <= -1)
            {
                MessageBox.Show("Hãy chọn học kì", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBoxTenGV.SelectedIndex <= -1)
            {
                MessageBox.Show("Hãy chọn giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    themHP_BLL.ThemHP_BLL("HP"+textBoxMaHP.Text.Trim(),
                                       textBoxTenHP.Text.Trim(),
                                       Convert.ToInt16(textBoxSoTinChi.Text.Trim()),
                                       Convert.ToInt16(textBoxSoTiet.Text.Trim()),
                                       Convert.ToDouble(textBoxPTDiemGiuaKi.Text.Trim()),
                                       Convert.ToDouble(textBoxPTDiemThi.Text.Trim()),
                                       lMaHK[comboBoxTenHK.SelectedIndex].Trim(),
                                       lID[comboBoxTenGV.SelectedIndex].Trim());
                    themHPSuccess();


                MessageBox.Show("Đã thêm mới học phần");
                this.Dispose();
                }
                catch
                {
                    MessageBox.Show("Thêm mới không thành công");
                }
            }
        }

        private void buttonLuuThayDoi_Click(object sender, EventArgs e)
        {
            try
            {
                HocPhan hp = new HocPhan
                {
                    MaHP = "HP"+ textBoxMaHP.Text.Trim(),
                    TenHP = textBoxTenHP.Text.Trim(),
                    SoTC = Convert.ToInt32(textBoxSoTinChi.Text),
                    SoTiet = Convert.ToInt32(textBoxSoTiet.Text),
                    PhanTramDGK = Convert.ToDouble(textBoxPTDiemGiuaKi.Text),
                    PhanTramDT = Convert.ToDouble(textBoxPTDiemThi.Text)
                };
                string MaGV = lID[comboBoxTenGV.SelectedIndex].Trim();
                string MaHK = lMaHK[comboBoxTenHK.SelectedIndex].Trim();

                if (themHP_BLL.UpdateHP(hp, MaGV, MaHK))
                    MessageBox.Show("Thay đổi thành công");
                this.Dispose();
            }
            catch
            {
                MessageBox.Show("Không thành công!");
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBoxMaHP_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidError.ValidMaSo(textBoxMaHP.Text, out errorMsg))
            {
                e.Cancel = true;
                textBoxMaHP.Select(0, textBoxMaHP.Text.Length);

                this.errorProviderHP.SetError(textBoxMaHP, errorMsg);
            }
        }

        private void textBoxMaHP_Validated(object sender, EventArgs e)
        {
            errorProviderHP.SetError(textBoxMaHP, "");
        }

        private void textBoxSoTinChi_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidError.ValidPhone(textBoxSoTinChi.Text, out errorMsg))
            {
                e.Cancel = true;
                textBoxSoTinChi.Select(0, textBoxSoTinChi.Text.Length);

                this.errorProviderHP.SetError(textBoxSoTinChi, errorMsg);
            }
        }

        private void textBoxSoTinChi_Validated(object sender, EventArgs e)
        {
            errorProviderHP.SetError(textBoxSoTinChi, "");
        }

        private void textBoxSoTiet_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidError.ValidPhone(textBoxSoTiet.Text, out errorMsg))
            {
                e.Cancel = true;
                textBoxSoTiet.Select(0, textBoxSoTiet.Text.Length);

                this.errorProviderHP.SetError(textBoxSoTiet, errorMsg);
            }
        }

        private void textBoxSoTiet_Validated(object sender, EventArgs e)
        {
            errorProviderHP.SetError(textBoxSoTiet, "");
        }

        private void textBoxPTDiemGiuaKi_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidError.ValidPTDiem(textBoxPTDiemGiuaKi.Text, out errorMsg))
            {
                e.Cancel = true;
                textBoxPTDiemGiuaKi.Select(0, textBoxPTDiemGiuaKi.Text.Length);

                this.errorProviderHP.SetError(textBoxPTDiemGiuaKi, errorMsg);
            }
        }

        private void textBoxPTDiemGiuaKi_Validated(object sender, EventArgs e)
        {
            errorProviderHP.SetError(textBoxPTDiemGiuaKi, "");
        }

        private void textBoxPTDiemThi_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidError.ValidPTDiem(textBoxPTDiemThi.Text, out errorMsg))
            {
                e.Cancel = true;
                textBoxPTDiemThi.Select(0, textBoxPTDiemThi.Text.Length);

                this.errorProviderHP.SetError(textBoxPTDiemThi, errorMsg);
            }
        }

        private void textBoxPTDiemThi_Validated(object sender, EventArgs e)
        {
            errorProviderHP.SetError(textBoxPTDiemThi, "");
        }
    }
}
