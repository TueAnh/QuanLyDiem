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
        public ThemLopHP()
        {
            InitializeComponent();
            themHP_BLL = new ThemLopHP_BLL();
            loadCbb();
            buttonLuuMoi.Visible = true;
        }
        public ThemLopHP(string ID)
        {
            InitializeComponent();
            themHP_BLL = new ThemLopHP_BLL();
            loadCbb();
            LoadData(ID);
            buttonLuuThayDoi.Visible = true;
        }
        public void LoadData(string ID)
        {
            string x = "", y = "";
            HocPhan hp = themHP_BLL.GetHocPhan(ID, ref x, ref y);
            if (hp != null)
            {
                textBoxMaHP.Text = hp.MaHP.Trim();
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
            if (themHP_BLL.ChecKExistHP_BLL(textBoxMaHP.Text.Trim()))
            {
                textBoxMaHP.Text= "";
                MessageBox.Show("Học phần đã tồn tại");
                
            }
            else
            {
                try
                {
                    themHP_BLL.ThemHP_BLL(textBoxMaHP.Text.Trim(),
                                       textBoxTenHP.Text.Trim(),
                                       Convert.ToInt16(textBoxSoTinChi.Text.Trim()),
                                       Convert.ToInt16(textBoxSoTiet.Text.Trim()),
                                       Convert.ToDouble(textBoxPTDiemGiuaKi.Text.Trim()),
                                       Convert.ToDouble(textBoxPTDiemThi.Text.Trim()),
                                       lMaHK[comboBoxTenHK.SelectedIndex].Trim(),
                                       lID[comboBoxTenGV.SelectedIndex].Trim());

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
                    MaHP = textBoxMaHP.Text.Trim(),
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

      
    }
}
