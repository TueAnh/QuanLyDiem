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
			LoadCBB();
		}
		public void LoadCBB()
		{
			List<string> listLCH = bll.getDSLCHBLL();
			foreach (string s in listLCH)
			{
				comboBoxLCH.Items.Add(s);
			}
		}
		#region tab1
		private void releaseObject(object obj)
		{
			try
			{
				System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
				obj = null;
			}
			catch (Exception ex)
			{
				obj = null;
				MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
			}
			finally
			{
				GC.Collect();
			}
		}
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
                labelPath.Visible = true;
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
							var x = range.Cells[r, c].Value;
							row[c - 1] = x;
						}
						tb.Rows.Add(row);
					}
					dataGridView1.DataSource = tb;
					releaseObject(app);
					releaseObject(wb);
					releaseObject(sheet);
                    buttonSave.Visible = true;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelPath.Visible = false;
                    dataGridView1.DataSource = null;
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
            try
            {
                int i = 0;
                while (i < dataGridView1.Rows.Count)
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
            catch
            {
                MessageBox.Show("Đối tượng học viên thêm từ Excel không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            buttonSave.Visible = false;
            labelPath.Visible = false;

        }
		#endregion
		#region tab2
		ThemHocVien_BLL bLL = new ThemHocVien_BLL();

		private void buttonAdd_Click(object sender, EventArgs e)
		{
            if (textBoxMaHV.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền mã học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!bLL.checkHocVienBLL("HV"+textBoxMaHV.Text.Trim()))
            {
                MessageBox.Show("Học viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(comboBoxLCH.SelectedIndex <= -1)
            {
                MessageBox.Show("Hãy chọn lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textBoxHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Hãy điền tên học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bLL.addHVBLL(new HocVien
                    {
                        ID = "HV" + textBoxMaHV.Text.Trim(),
                        HoTen = textBoxHoTen.Text.Trim(),
                        NgaySinh = dateTimePickerNS.Value,
                        MaLop = bLL.getLopBLL(comboBoxLCH.SelectedItem.ToString()),
                        DiaChi = textBoxDiaChi.Text.Trim(),
                        Email = textBoxEmail.Text.Trim(),
                        DienThoai = textBoxDienThoai.Text.Trim(),
                        Password = "",
                    });
                    MessageBox.Show("Thêm học viên thành công");
                    this.Dispose();
                }
                catch
                {
                    MessageBox.Show("Thêm học viên không thành công");
                }
            }
		}

        #endregion

        private void textBoxMaHV_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidError.ValidMaSo(textBoxMaHV.Text, out errorMsg))
            {
                e.Cancel = true;
                textBoxMaHV.Select(0, textBoxMaHV.Text.Length);

                this.errorProviderAddHV.SetError(textBoxMaHV, errorMsg);
            }
        }

        private void textBoxMaHV_Validated(object sender, EventArgs e)
        {
            errorProviderAddHV.SetError(textBoxMaHV, "");
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEmail.Text == "")
            {

            }
            else
            {
                string errorMsg;
                if (!ValidError.ValidEmailAddress(textBoxEmail.Text, out errorMsg))
                {
                    e.Cancel = true;
                    textBoxEmail.Select(0, textBoxEmail.Text.Length);

                    this.errorProviderAddHV.SetError(textBoxEmail, errorMsg);
                }
            }
        }

        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            errorProviderAddHV.SetError(textBoxEmail, "");
        }

        private void textBoxDienThoai_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxDienThoai.Text == "")
            {

            }
            else
            {
                string errorMsg;
                if (!ValidError.ValidPhone(textBoxDienThoai.Text, out errorMsg))
                {
                    e.Cancel = true;
                    textBoxDienThoai.Select(0, textBoxDienThoai.Text.Length);

                    this.errorProviderAddHV.SetError(textBoxDienThoai, errorMsg);
                }
            }
        }

        private void textBoxDienThoai_Validated(object sender, EventArgs e)
        {
            errorProviderAddHV.SetError(textBoxDienThoai, "");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
