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
	public partial class LopHPDT : Form
	{
		#region InitandLoad
		public delegate void AddRemoveControl(Form form);
		public AddRemoveControl addControl;
		public AddRemoveControl removeControl;

		string MaHP = "";
		public LopHP_BLL bLL { get; set; }
		public LopHPDT()
		{
			InitializeComponent();

		}
		public LopHPDT(string MaHP)// ham dựng lấy mã học phần
		{
			InitializeComponent();
			bLL = new LopHP_BLL();
			this.MaHP = MaHP;
			LoadData();
            if (FormLogin.User.typeAcc != 3)
            {
                buttonChange.Enabled = false;
            }
        }

		////public LopHPDT(string MaHP, string GiangVien)
		////{
		////    InitializeComponent();
		////    this.MaHP = MaHP;
		////    textBoxGVPT.Text = GiangVien;
		////}
		public void LoadData()
		{
			dataGridViewDSHV.Columns.Clear();
			dataGridViewDSHV.Columns.Add("STT", "STT");
			dataGridViewDSHV.DataSource = bLL.getDSHVBLL(MaHP);
			//dataGridViewDSHV.Columns[1].HeaderText = "Mã số";
			//dataGridViewDSHV.Columns[2].HeaderText = "Họ tên";
			//dataGridViewDSHV.Columns[3].HeaderText = "Điểm BT";
			//dataGridViewDSHV.Columns[4].HeaderText = "Điểm GK";
			//dataGridViewDSHV.Columns[5].HeaderText = "Điểm Thi";
			textBoxGVPT.Text = bLL.getGVBLL(MaHP);
			textBoxLDT.Text = MaHP;
			dataGridViewDSHV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewDSHV.Columns["STT"].Width = 50;
			this.dataGridViewDSHV.Refresh();
		}

		private void LopHPDT_Load(object sender, EventArgs e)
		{
			//LoadData(MaHP);
		}
		#endregion
		#region ButtonClick
		private void buttonSearch_Click(object sender, EventArgs e)
		{
			dataGridViewDSHV.Columns.Clear();
			dataGridViewDSHV.Columns.Add("STT", "STT");
			string str = textBoxSearch.Text;
			if (str != "")
			{
				dataGridViewDSHV.DataSource = bLL.getDSSearchBLL(str, MaHP);
			}
			else
			{
				dataGridViewDSHV.DataSource = bLL.getDSHVBLL(str);
			}
			dataGridViewDSHV.Columns[1].HeaderText = "Mã số";
			dataGridViewDSHV.Columns[2].HeaderText = "Họ tên";
			dataGridViewDSHV.Columns[3].HeaderText = "Điểm BT";
			dataGridViewDSHV.Columns[4].HeaderText = "Điểm GK";
			dataGridViewDSHV.Columns[5].HeaderText = "Điểm Thi";
			dataGridViewDSHV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewDSHV.Columns["STT"].Width = 50;
			this.dataGridViewDSHV.Refresh();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			removeControl(this);
			this.Dispose();
		}
		#endregion
		#region DelegateFunction
		public void AddControlPanel(Form form)
		{
			addControl(form);
		}
		public void RemoveControlPanel(Form form)
		{
			removeControl(form);
		}
		#endregion
		#region DataGridViewEvent
		private void dataGridViewDSHV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			if (e.RowIndex < dataGridViewDSHV.Rows.Count)
				this.dataGridViewDSHV.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
		}

		private void dataGridViewDSHV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
            //if (e.RowIndex != -1)
            //{
            //    string MaHV = dataGridViewDSHV.SelectedRows[0].Cells["Mã số"].Value.ToString();
            //    NVDT.HocVienDT f = new HocVienDT(MaHV);
            //    f.addControl += new HocVienDT.AddRemoveControl(AddControlPanel);
            //    f.removeControl += new HocVienDT.AddRemoveControl(RemoveControlPanel);
            //    AddControlPanel(f);
            //} 
            try
            {
                if (e.RowIndex != -1)
                {
                    string MaHV = dataGridViewDSHV.SelectedRows[0].Cells["Mã HV"].Value.ToString();
                    GUI.NVDT.SuaDiemHocVienDT suaDiemHocVienDT_form = new SuaDiemHocVienDT(MaHV, MaHP);
                    suaDiemHocVienDT_form.removeControl += new SuaDiemHocVienDT.AddRemoveControl(RemoveControlPanel);
                    suaDiemHocVienDT_form.saveSuccess += new SuaDiemHocVienDT.SaveSuccess(LoadData);
                    AddControlPanel(suaDiemHocVienDT_form);
                }
            }
            catch
            {

            }
		}
		#endregion

		private void buttonXem_Click(object sender, EventArgs e)
		{
            try
            {
                if (dataGridViewDSHV.SelectedRows[0].Cells["Mã HV"].Value.ToString() != null)
                {
                    NVDT.HocVienDT f = new HocVienDT(dataGridViewDSHV.SelectedRows[0].Cells["Mã HV"].Value.ToString());
                    f.addControl += new HocVienDT.AddRemoveControl(AddControlPanel);
                    f.removeControl += new HocVienDT.AddRemoveControl(RemoveControlPanel);
                    AddControlPanel(f);
                }
            }
            catch
            {

            }

		}

		private void buttonChange_Click(object sender, EventArgs e)
		{
			ThemLopHP themLopHP = new ThemLopHP(textBoxLDT.Text);
			themLopHP.ShowDialog();
			this.removeControl(this);

		}

		private void buttonSort_Click(object sender, EventArgs e)
		{
            try
            {
                if (comboBox1.SelectedItem.ToString().Trim().Length > 0)
                {
                    if (comboBox1.SelectedItem.ToString() == "Theo Tên")
                    {
                        dataGridViewDSHV.Sort(dataGridViewDSHV.Columns["Tên"], ListSortDirection.Ascending);
                    }
                    if (comboBox1.SelectedItem.ToString() == "Theo Mã")
                    {
                        dataGridViewDSHV.Sort(dataGridViewDSHV.Columns["Mã HV"], ListSortDirection.Ascending);
                    }
                    if (comboBox1.SelectedItem.ToString() == "Theo Điểm TB")
                    {
                        dataGridViewDSHV.Sort(dataGridViewDSHV.Columns["Điểm TB"], ListSortDirection.Descending);
                    }
                }
            }
            catch
            {

            }
		}
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
		private void copyAlltoClipboard()
		{
			dataGridViewDSHV.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			if (dataGridViewDSHV.SelectedRows.Count == 1)
				dataGridViewDSHV.SelectAll();
			DataObject dataObj = dataGridViewDSHV.GetClipboardContent();
			if (dataObj != null)
				Clipboard.SetDataObject(dataObj);
		}
		private void buttonOut_Click(object sender, EventArgs e)
		{
			DataTable tb = bLL.getDSHVBLL2(MaHP);

			copyAlltoClipboard();
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Excel Documents (*.xls)|*.xls";
			sfd.FileName = "Bảng điểm HP.xls";
			if (sfd.ShowDialog() == DialogResult.OK)
			{

				// Copy DataGridView results to clipboard

				object misValue = System.Reflection.Missing.Value;
				Microsoft.Office.Interop.Excel.Application xlexcel = new Microsoft.Office.Interop.Excel.Application();

				xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
				Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
				Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


				//dinh dang column width
				xlWorkSheet.Columns["A"].ColumnWidth = 4.70;
				xlWorkSheet.Columns["B"].ColumnWidth = 21.85;
				xlWorkSheet.Columns["C"].ColumnWidth = 8.43;
				xlWorkSheet.Columns["D"].ColumnWidth = 8.43;
				xlWorkSheet.Columns["E"].ColumnWidth = 8.14;
				xlWorkSheet.Columns["F"].ColumnWidth = 12.71;
				xlWorkSheet.Columns["G"].ColumnWidth = 12.71;
				xlWorkSheet.Columns["H"].ColumnWidth = 11.57;
				xlWorkSheet.Columns["I"].ColumnWidth = 10.14;

				//Dinh dang 

				Microsoft.Office.Interop.Excel.Range r = xlWorkSheet.get_Range("A1", "D1");

				r.MergeCells = true;
				r.Value2 = "ĐẠI HỌC ĐÀ NẴNG";
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.Font.FontStyle = Microsoft.Office.Interop.Excel.XlThemeFont.xlThemeFontMajor;

				r = xlWorkSheet.get_Range("E1", "I1");
				r.MergeCells = true;
				r.Font.Bold = true;
				r.Value2 = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

				r = xlWorkSheet.get_Range("A2", "D2");
				r.MergeCells = true;
				r.Font.Bold = true;
				r.Value2 = "TRƯỜNG ĐẠI HỌC BÁCH KHOA";
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

				r = xlWorkSheet.get_Range("E2", "I2");
				r.MergeCells = true;
				r.Font.Bold = true;
				r.Value2 = "Độc lập - Tự do - Hạnh phúc";
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

				r = xlWorkSheet.get_Range("A5", "I5");
				r.MergeCells = true;
				r.Value2 = "BẢNG ĐIỂM MÔN HỌC CAO HỌC";
				r.Font.Size = 17;
				r.Font.Bold = true;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

				r = xlWorkSheet.get_Range("A7", "D7");
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "Chuyên ngành: " + bLL.getTenKhoaBLL(MaHP);

				r = xlWorkSheet.get_Range("A8", "D8");
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "Môn học: " + bLL.getTenHPBLL(MaHP);

				r = xlWorkSheet.get_Range("A9", "D9");
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "Họ, tên CBGD: " + textBoxGVPT.Text;

				r = xlWorkSheet.get_Range("H7", "I7");
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "Khóa: " + MaHP;

				int soTC = Convert.ToInt32(bLL.getSoTCBLL(MaHP));
				r = xlWorkSheet.get_Range("H8", "I8");
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "Số tín chỉ: " + soTC + "TC";

				r = xlWorkSheet.get_Range("H9", "I9");
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "Ngày thi: ...................";

				//Table
				xlWorkSheet.Rows[12].RowHeight = 27.75;
				xlWorkSheet.Rows[11].RowHeight = 19.5;

				r = xlWorkSheet.get_Range("A11", "A12");
				r.Font.Bold = true;
				r.MergeCells = true;
				r.Value2 = "STT";
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("B11", "B12");
				r.Font.Bold = true;
				r.MergeCells = true;
				r.Value2 = "Họ và tên học viên";
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("C11", "D11");
				r.Font.Bold = true;
				r.MergeCells = true;
				r.Value2 = "Đánh giá định kì";
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("C12", "C12");
				r.Font.Italic = true;
				r.MergeCells = true;
				r.Value2 = "Bài KT (...)";
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
				r.WrapText = true;

				r = xlWorkSheet.get_Range("D12", "D12");
				r.Font.Italic = true;
				r.MergeCells = true;
				r.Value2 = "Tiểu luận (...)";
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
				r.WrapText = true;

				r = xlWorkSheet.get_Range("E11", "E12");
				r.Font.Bold = true;
				r.MergeCells = true;
				r.Value2 = "Thi";
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("F11", "G11");
				r.Font.Bold = true;
				r.MergeCells = true;
				r.Value2 = "Điểm môn học";
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("F12", "F12");
				r.Font.Italic = true;
				r.MergeCells = true;
				r.Value2 = "Bằng số";
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("G12", "G12");
				r.Font.Italic = true;
				r.MergeCells = true;
				r.Value2 = "Bằng chữ";
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("H11", "H12");
				r.Font.Bold = true;
				r.MergeCells = true;
				r.Value2 = "Chữ ký học viên";
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
				r.WrapText = true;

				r = xlWorkSheet.get_Range("I11", "I12");
				r.Font.Bold = true;
				r.MergeCells = true;
				r.Value2 = "Ghi chú";
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
				r.WrapText = true;

				int count = 13;
				string[] nguyen = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" ,"mười" , ""};
				string[] thapphan = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" ,"",""};
				for (int i = 0; i < tb.Rows.Count; i++)
				{
                    int a, b ,y;
                    double x;
                    if (tb.Rows[i][5] != "")
                    {
                        x = Convert.ToDouble(tb.Rows[i][5]) * 10;
                        y = Convert.ToInt32(x);
                        a = y / 10; b = y % 10;
                    }
                    else
                    {
                        a = 11;b = 11;
                    }
					dynamic[] arr = { i + 1, tb.Rows[i][1], tb.Rows[i][2]==null?"":tb.Rows[i][2],
                                    tb.Rows[i][3]==null?"":tb.Rows[i][3] , tb.Rows[i][4]==null?"":tb.Rows[i][4] ,
									tb.Rows[i][5] , nguyen[a] + " " + thapphan[b] , "" ,""};
					r = xlWorkSheet.get_Range("A" + count, "I" + count);
					r.Value2 = arr;
					r.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
					r.Cells.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
					count++;
				}

				//hau table
				r = xlWorkSheet.get_Range("A" + count, "B" + (count++));
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "Tổng số bài : ............";


				r = xlWorkSheet.get_Range("A" + count, "B" + (count++));
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "Tổng số tờ : ............";

				r = xlWorkSheet.get_Range("F" + count, "I" + (count++));
				r.MergeCells = true;
				r.Font.Italic = true;
				r.Font.Size = 12;
				r.Value2 = String.Format("Đà Nẵng, ngày  {0}  tháng  {1}  năm {2}   ",
					DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("A" + (count += 1), "B" + (count));
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Font.Bold = true;
				r.Value2 = "Cán bộ coi thi thứ nhất";
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("A" + (count + 1), "B" + (count + 1));
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "(Ký và ghi rõ họ tên )";
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("C" + count, "E" + count);
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Font.Bold = true;
				r.Value2 = "Cán bộ coi thi thứ hai";
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("C" + (count + 1), "E" + (count + 1));
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "(Ký và ghi rõ họ tên )";
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("F" + count, "G" + count);
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Font.Bold = true;
				r.Value2 = "Cán bộ chấm thi thứ nhất";
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("F" + (count + 1), "G" + (count + 1));
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "(Ký và ghi rõ họ tên )";
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("H" + count, "I" + count);
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Font.Bold = true;
				r.Value2 = "Cán bộ chấm thi thứ hai";
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("H" + (count + 1), "I" + (count + 1));
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "(Ký và ghi rõ họ tên )";
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("D" + (count += 7), "G" + count);
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "Xác nhận của Trường Đại học Bách Khoa";
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

				r = xlWorkSheet.get_Range("B" + (count += 2), "B" + count);
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "Phòng đào tạo";

				/*
				// Format column D as text before pasting results, this was required for my data
				Microsoft.Office.Interop.Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
				rng.NumberFormat = "@";

				// Paste clipboard results to worksheet range
				Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
				CR.Select();
				xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

				// For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
				// Delete blank column A and select cell A1
				Microsoft.Office.Interop.Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
				delRng.Delete(Type.Missing);
				xlWorkSheet.get_Range("A1").Select();

				// Save the excel file under the captured location from the SaveFileDialog
				xlWorkBook.SaveAs(sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
				xlexcel.DisplayAlerts = true;
				xlWorkBook.Close(true, misValue, misValue);
				xlexcel.Quit();

				releaseObject(xlWorkSheet);
				releaseObject(xlWorkBook);
				releaseObject(xlexcel);

				// Clear Clipboard and DataGridView selection
				Clipboard.Clear();
				dataGridViewDSHV.ClearSelection();

				// Open the newly saved excel file
				//if (File.Exists(sfd.FileName))
				//    System.Diagnostics.Process.Start(sfd.FileName);
				///
				*/
				xlWorkBook.SaveAs(sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
				xlexcel.DisplayAlerts = true;
				xlWorkBook.Close(true, misValue, misValue);
				xlexcel.Quit();

				releaseObject(xlWorkSheet);
				releaseObject(xlWorkBook);
				releaseObject(xlexcel);

				// Clear Clipboard and DataGridView selection
				Clipboard.Clear();
			}

		}

		private void buttonInput_Click(object sender, EventArgs e)
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
				Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
				//Mở tập excel
				Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Open(fopen.FileName);
				//try
				//{
				Microsoft.Office.Interop.Excel._Worksheet sheet = wb.Sheets[1];
				Microsoft.Office.Interop.Excel.Range range = sheet.UsedRange;
				//doc du lieu
				int rows = range.Rows.Count;
				int cols = range.Columns.Count;
				string[] v = range.Cells[7, 9].Value.ToString().Trim().Split(' ');
				string mahp = v[v.Length - 1];
				if (mahp != MaHP)
				{
					MessageBox.Show("Khác lớp học phần");
					return;
				}
				System.Data.DataTable tb = new System.Data.DataTable();
				//doc tieu de
				tb.Columns.Add("Mã HV");
				tb.Columns.Add("Họ");
				tb.Columns.Add("Tên");
				tb.Columns.Add("Điểm BT");
				tb.Columns.Add("Điểm GK");
				tb.Columns.Add("Điểm Thi");
				tb.Columns.Add("Điểm TB");

				for (int r = 13; r <= rows - 14; r++)
				{
					DataRow row = tb.NewRow();
					row["Mã HV"] = range.Cells[r, 2].Value;
					string[] name = range.Cells[r, 3].Value.Split(' ');
					for (int j = 0; j < name.Length - 1; j++)
						row["Họ"] += name[j] + " ";
					row["Tên"] = name[name.Length - 1];
					row["Điểm BT"] = range.Cells[r, 4].Value;
					row["Điểm GK"] = range.Cells[r, 5].Value;
					row["Điểm Thi"] = range.Cells[r, 6].Value;
					row["Điểm TB"] = range.Cells[r, 7].Value;
					tb.Rows.Add(row);
				}
				dataGridViewDSHV.DataSource = tb;
				releaseObject(app);
				releaseObject(wb);
				releaseObject(sheet);
				//}
				//catch (Exception ex)
				//{
				//	MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//}
			}
			else
			{
				MessageBox.Show("Bạn không chọn tệp nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
            bool valid =false;
			foreach (DataGridViewRow r in dataGridViewDSHV.Rows)
			{
				dynamic DBT = null;
				dynamic DGK = null;
				dynamic DT = null;
				try
				{
					if (r.Cells["Điểm BT"].Value.ToString().Trim().Length > 0)
						DBT = Convert.ToDouble(r.Cells["Điểm BT"].Value.ToString());
					if (r.Cells["Điểm GK"].Value.ToString().Trim().Length > 0)
						DGK = Convert.ToDouble(r.Cells["Điểm GK"].Value.ToString());
					if (r.Cells["Điểm Thi"].Value.ToString().Trim().Length > 0)
						DT = Convert.ToDouble(r.Cells["Điểm Thi"].Value.ToString());
                    
                
                int key;
                if (r.Cells["Mã HV"].Value.ToString().Trim()!="")
                {
                    key =bLL.UpdateKQHP(new KetQuaHocPhan{
                    DiemBT = DBT,
                    DiemGK = DGK,
                    DiemThi = DT
                    }, r.Cells["Mã HV"].Value.ToString().Trim(), textBoxLDT.Text.Trim());
                }
                else
                {
                    key = -1;
                }
                if (key == -1) r.DefaultCellStyle.BackColor = Color.Red;
                if (key == 1) r.DefaultCellStyle.BackColor = Color.Lime;
                    valid = true;
                }
                
                catch
                {
                    continue;
                } 
            }
            if (valid == false)
            {
                MessageBox.Show("Đối tượng cập nhật không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridViewDSHV.ClearSelection();
		}

		private void buttonXoa_Click(object sender, EventArgs e)
		{
            try
            {
                foreach (DataGridViewRow r in dataGridViewDSHV.SelectedRows)
                {
                    if (bLL.XoaHV(r.Cells["Mã HV"].Value.ToString().Trim(), textBoxLDT.Text.Trim()))
                    {
                        r.DefaultCellStyle.BackColor = Color.Lime;
                    }
                    else
                    {
                        r.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                dataGridViewDSHV.ClearSelection();
            }
            catch
            {
                MessageBox.Show("Đối tượng xóa không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}

		private void buttonReload_Click(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
