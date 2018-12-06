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
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyDiem.GUI.NVDT
{
    public partial class FormAddHV : Form
    {
        AddHocVienSH_BLL bll = new AddHocVienSH_BLL();
        public FormAddHV()
        {
            InitializeComponent();
        }
        #region tab1
        private void buttonPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fopen = new OpenFileDialog();
            //Duoi file
            fopen.Filter = "(Tất cả các tệp)|*.*|(Các tệp excel)|*.xlsx";
            fopen.ShowDialog();
            //xu li
            if (fopen.FileName != "")
            {
                labelPath.Text = fopen.FileName;
                //tao doi tuong Excel
                Excel.Application app = new Excel.Application();
                //Mở tập excel
                Excel.Workbook wb = app.Workbooks.Open(fopen.FileName);
                try
                {
                    Excel._Worksheet sheet = wb.Sheets[1];
                    Excel.Range range = sheet.UsedRange;
                    //doc du lieu
                    int rows = range.Rows.Count;
                    int cols = range.Columns.Count;
                    DataTable tb = new DataTable();
                    //doc tieu de
                    for (int c = 1; c <= cols; c++)
                    {
                        string columName = range.Cells[1, c].Value.ToString();
                        tb.Columns.Add(columName);
                    }

                    for (int r = 2; r <= rows; r++)
                    {
                        DataRow row = tb.NewRow();
                        for (int c = 1; c <= cols; c++)
                        {
                            var x = range.Cells[r, c].Value.ToString();
                            row[c - 1] = x;
                        }
                        tb.Rows.Add(row);
                    }
                    dataGridView1.DataSource = tb;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn không chọn tệp nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int i = 0;
            while ( i < dataGridView1.Rows.Count )
            {
                DataGridViewRow r = dataGridView1.Rows[i];
                if (
                    bll.AddHVSH_BLL(new HocVien
                    {
                        ID = r.Cells["Mã số"].Value.ToString().Trim(),
                        HoTen = r.Cells["Họ tên"].Value.ToString().Trim(),
                        Email = r.Cells["Email"].Value.ToString().Trim(),
                        DiaChi = r.Cells["Địa chỉ"].Value.ToString().Trim(),
                        DienThoai = r.Cells["Điện thoại"].Value.ToString().Trim(),
                        Password = r.Cells["Mật khẩu"].Value.ToString().Trim(),
                        MaLop = r.Cells["Mã lớp"].Value.ToString().Trim(),
                        NgaySinh = Convert.ToDateTime(r.Cells["Ngày sinh"].Value),
                        //MaLop = textBoxMaLop.Text.Trim()
                    }))
                    dataGridView1.Rows.RemoveAt(i);
                else
                {
                    r.DefaultCellStyle.BackColor = Color.Red;
                    i++;
                    //break;
                }
                dataGridView1.Refresh();
            }
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Hoàn tất!");
            }

        }
        #endregion
        #region tab2
        ThemHocVien_BLL bLL = new ThemHocVien_BLL();
        public bool checkMaHV()
        {
            if (textBoxMaHV.Text.Length != 3) return false;
            string s = textBoxMaHV.Text;
            for (int i = 0; i < 3; i++)
            {
                if (s[0] <= '0' && s[0] >= '9') return false;
            }
            return true;
        }
        //void LoadMaLop()
        //{
        //	string s = "HV";
        //	if (bLL.getSoHocVienBLL()+1 < 100)
        //		s += "0";
        //	if (bLL.getSoHocVienBLL()+1 < 10)
        //		s += "0";
        //	s += (bLL.getSoHocVienBLL() + 1);
        //	textBoxMaHV.Text = s;
        //	textBoxMaHV.ReadOnly = true;
        //}

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (bLL.getLopBLL(textBoxLopCH.Text) != null && bLL.checkHocVienBLL(textBoxMaHV.Text)
                && checkMaHV() && textBoxHoTen.Text != "")
            {
                try
                {
                    bLL.addHVBLL(new HocVien
                    {
                        ID = "HV" + textBoxMaHV.Text,
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
                }
                catch
                {
                    MessageBox.Show("Nhập sai !! ");
                }
            }
            else
            {
                MessageBox.Show("Nhập sai !!!!");
            }
        }

        #endregion
    }
}
