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
using Microsoft.Office.Interop.Excel; // nho Add them:  Reference\ interop.excel
using app = Microsoft.Office.Interop.Excel.Application;
using System.IO;

namespace QuanLyDiem.GUI
{
	public partial class FormViewHV : Form
	{
		HocVien hv;
		public delegate void AddRemoveControl(Form form);
		public AddRemoveControl addControl;
		public AddRemoveControl removeControl;
		public void AddControlPanel(Form form)
		{
			addControl(form);
		}
		public void RemoveControlPanel(Form form)
		{
			removeControl(form);
		}
		BLL.HocVien_BLL bLL = new HocVien_BLL();
		string MaHV;
		List<int> strNH = new List<int>();
		List<string> strHK = new List<string>();
		List<int> strHKNH = new List<int>();
		public FormViewHV(string str)
		{
			MaHV = FormHome.UserAcc.ID;
			MemoryStream stream = new MemoryStream();
			InitializeComponent();
			LoadData();
			User HV = Login_BLL.BLL.GetUser(1, MaHV);
			loadImage(HV.Image);
		}
		public void loadImage(byte[] data)
		{

			if (data == null)
			{
				pictureBox1.Image = null;
			}
			else
			{
				MemoryStream memoryStream = new MemoryStream(data);
				pictureBox1.Image = Image.FromStream(memoryStream);
			}
		}
		public void LoadData()
		{
			textBoxMSHV.Text = MaHV;
			hv = bLL.getHVBLL(MaHV);
			textBoxNAME.Text = hv.HoTen;
			dataGridViewDTBvXL.Columns.Clear();
			dataGridViewDTBvXL.Columns.Add("STT", "STT");
			dataGridViewXemDiem.Columns.Clear();
			dataGridViewXemDiem.Columns.Add("STT", "STT");
			dataGridViewDTBvXL.DataSource = bLL.getDTBvXLBLL(MaHV);
			dataGridViewDTBvXL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			radioButtonQuaTrinh.Checked = true;
			dataGridViewXemDiem.DataSource = bLL.getDiemQTBLL(MaHV);
			dataGridViewXemDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridViewXemDiem.Columns[dataGridViewXemDiem.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewDTBvXL.Columns["STT"].Width = 50;
			dataGridViewXemDiem.Columns["STT"].Width = 50;
			loadCBB();
		}
		private void loadCBB()
		{
			strHKNH = bLL.loadCBBNHBLL(MaHV);
			foreach (int x in strHKNH)
			{
				int index = 0;
				foreach (int y in strNH)
				{
					if (y == x) index = 1;
				}
				if (index == 0)
				{
					strNH.Add(x);
				}
			}
			strHK = bLL.loadCBBHKBLL(MaHV);
		}
		#region radioBTT
		private void radioButtonQuaTrinh_CheckedChanged(object sender, EventArgs e)
		{
			comboBoxDoanXem.Items.Clear();
			comboBoxDoanXem.ResetText();
		}

		private void radioButtonNamHoc_CheckedChanged(object sender, EventArgs e)
		{
			comboBoxDoanXem.Items.Clear();
			comboBoxDoanXem.ResetText();
			if (radioButtonNamHoc.Checked == true)
			{
				comboBoxDoanXem.Items.Clear();
				foreach (int y in strNH)
				{
					comboBoxDoanXem.Items.Add("Năm học " + y + " - " + (y + 1));

				}
			}
		}

		private void radioButtonHocKi_CheckedChanged(object sender, EventArgs e)
		{
			comboBoxDoanXem.Items.Clear();
			comboBoxDoanXem.ResetText();
			if (radioButtonHocKi.Checked == true)
			{
				for (int i = 0; i < strHK.Count; i++)
				{
					comboBoxDoanXem.Items.Add(strHK[i] + " Năm học " + strHKNH[i] + " - " + (strHKNH[i] + 1));
				}
			}
		}
		#endregion

		private void buttonXem_Click(object sender, EventArgs e)
		{
			if (radioButtonQuaTrinh.Checked == true)
			{
				comboBoxDoanXem.Items.Clear();
				comboBoxDoanXem.SelectedText = "";
				dataGridViewXemDiem.DataSource = null;
				dataGridViewXemDiem.DataSource = bLL.getDiemQTBLL(MaHV);
				dataGridViewXemDiem.Columns[dataGridViewXemDiem.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			}
			if (radioButtonNamHoc.Checked == true)
			{
				dataGridViewXemDiem.DataSource = null;
				if (comboBoxDoanXem.SelectedIndex >= 0)
				{
					dataGridViewXemDiem.DataSource = bLL.getDiemNHBLL(MaHV, strNH[comboBoxDoanXem.SelectedIndex]);
					dataGridViewXemDiem.Columns[dataGridViewXemDiem.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				}
				else MessageBox.Show("Chọn Năm Học");
			}
			if (radioButtonHocKi.Checked == true)
			{
				dataGridViewXemDiem.DataSource = null;
				if (comboBoxDoanXem.SelectedIndex >= 0)
				{
					dataGridViewXemDiem.DataSource = bLL.getDiemHKBLL(MaHV, strHKNH[comboBoxDoanXem.SelectedIndex],
																  strHK[comboBoxDoanXem.SelectedIndex]);
					dataGridViewXemDiem.Columns[dataGridViewXemDiem.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				}
				else MessageBox.Show("Chọn Học Kì / Năm Học");
			}
			dataGridViewXemDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		}
		private void exportToExcel(DataGridView g, string duongDan, string tenTap)
		{
			//app obj = new app();
			//obj.Application.Workbooks.Add(Type.Missing);
			//obj.Columns.ColumnWidth = 15;
			//for (int i = 1; i < g.Columns.Count + 1; i++)
			//{
			//    obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
			//}
			//for (int i = 0; i < g.Rows.Count; i++)
			//{
			//    for (int j = 0; j < g.Columns.Count; j++)
			//    {
			//        if (g.Rows[i].Cells[j].Value != null)
			//        {
			//            obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
			//        }
			//    }
			//}
			//obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
			//obj.ActiveWorkbook.Saved = true;
			//MessageBox.Show("File Excel được lưu vào : " + duongDan + tenTap + ".xlsx");

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
		private void buttonInBangDiem_Click(object sender, EventArgs e)
		{
			//exportToExcel(dataGridViewXemDiem, @"F:\", "InBangDiem");

			int t;
			string Type = "QUÁ TRÌNH";
			System.Data.DataTable db = bLL.getDiemQTBLL(MaHV); ;

			if (radioButtonNamHoc.Checked)
			{
				if (comboBoxDoanXem.SelectedIndex >= 0)
				{
					Type = comboBoxDoanXem.SelectedItem.ToString();
					Type = Type.ToUpper();
					db = bLL.getDiemNHBLL(MaHV, strNH[comboBoxDoanXem.SelectedIndex]);
				}
				else
				{
					MessageBox.Show("Chọn Năm Học");
					return;
				}
			}
			if (radioButtonHocKi.Checked)
			{
				if (comboBoxDoanXem.SelectedIndex >= 0)
				{
					Type = comboBoxDoanXem.SelectedItem.ToString();
					Type = Type.ToUpper();
					db = bLL.getDiemHKBLL(MaHV, strHKNH[comboBoxDoanXem.SelectedIndex],
																  strHK[comboBoxDoanXem.SelectedIndex]);
				}
				else
				{
					MessageBox.Show("Chọn Năm Học");
					return;
				}
			}
			int count = (db.Rows.Count % 2 == 0) ? (db.Rows.Count / 2) : ((db.Rows.Count + 1) / 2);
			double dtb = 0;
			int tc = 0;
			bool flag = true;
			try
			{
				for (int i = 0; i < dataGridViewDTBvXL.Rows.Count - 1; i++)
				{
					tc += Convert.ToInt32(dataGridViewDTBvXL.Rows[i].Cells["Tổng số tín chỉ"].Value);
					dtb += Convert.ToInt32(dataGridViewDTBvXL.Rows[i].Cells["Tổng số tín chỉ"].Value) *
						Convert.ToDouble(dataGridViewDTBvXL.Rows[i].Cells["Điểm TBCT10"].Value);
				}
			}
			catch
			{
				flag = false;
			}

			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Excel Documents (*.xls)|*.xls";
			sfd.FileName = "Bảng điểm.xls";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				// Copy DataGridView results to clipboard

				object misValue = System.Reflection.Missing.Value;
				Microsoft.Office.Interop.Excel.Application xlexcel = new Microsoft.Office.Interop.Excel.Application();

				xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
				Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
				Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.ActiveSheet;

				//dinh dang column width
				xlWorkSheet.Columns["A"].ColumnWidth = 4;
				xlWorkSheet.Columns["B"].ColumnWidth = 28;
				xlWorkSheet.Columns["C"].ColumnWidth = 5;
				xlWorkSheet.Columns["D"].ColumnWidth = 7;
				xlWorkSheet.Columns["E"].ColumnWidth = 0.53;
				xlWorkSheet.Columns["F"].ColumnWidth = 4;
				xlWorkSheet.Columns["G"].ColumnWidth = 28;
				xlWorkSheet.Columns["H"].ColumnWidth = 5;
				xlWorkSheet.Columns["I"].ColumnWidth = 7;

				Microsoft.Office.Interop.Excel.Range r = xlWorkSheet.get_Range("A1", "D1");
				r = xlWorkSheet.get_Range("A1", "I1");
				r.MergeCells = true;
				r.Value2 = "BẢNG ĐIỂM " + Type;
				r.Font.Size = 17;
				r.Font.Bold = true;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

				r = xlWorkSheet.get_Range("A3", "D3");
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "MSHV: " + hv.ID;

				r = xlWorkSheet.get_Range("F3", "I3");
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "Học viên: " + hv.HoTen;

				r = xlWorkSheet.get_Range("A4", "D4");
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = String.Format("Ngày sinh: {0}/{1}/{2}", hv.NgaySinh.Value.Day, hv.NgaySinh.Value.Month, hv.NgaySinh.Value.Year);

				r = xlWorkSheet.get_Range("F4", "I4");
				r.MergeCells = true;
				r.Font.Size = 12;
				r.Value2 = "Lớp: " + bLL.GetTenLop(MaHV);

				r = xlWorkSheet.get_Range("A7", "A7");
				r.Font.Bold = true;
				r.MergeCells = true;
				r.Value2 = "STT";
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r = xlWorkSheet.get_Range("B7", "B7");
				r.MergeCells = true;
				r.Font.Bold = true;
				r.Value2 = "Tên học phần";
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r = xlWorkSheet.get_Range("C7", "C7");
				r.MergeCells = true;
				r.Value2 = "TC";
				r.Font.Bold = true;
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r = xlWorkSheet.get_Range("D7", "D7");
				r.MergeCells = true;
				r.Value2 = "Điểm";
				r.Font.Bold = true;
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

				r = xlWorkSheet.get_Range("F7", "F7");
				r.MergeCells = true;
				r.Value2 = "STT";
				r.Font.Bold = true;
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r = xlWorkSheet.get_Range("G7", "G7");
				r.MergeCells = true;
				r.Value2 = "Tên học phần";
				r.Font.Bold = true;
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r = xlWorkSheet.get_Range("H7", "H7");
				r.MergeCells = true;
				r.Value2 = "TC";
				r.Font.Bold = true;
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
				r = xlWorkSheet.get_Range("I7", "I7");
				r.MergeCells = true;
				r.Value2 = "Điểm";
				r.Font.Bold = true;
				r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
				r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

				//dua diem vao
				int row = 8;
				for (int i = 0; i < db.Rows.Count; i++)
				{
					if (i < count)
					{
						dynamic[] arr = { i + 1, db.Rows[i]["Tên học phần"], db.Rows[i]["Số TC"], db.Rows[i]["Điểm TB"] };
						r = xlWorkSheet.get_Range("A" + (row + i), "D" + (row + i));
						r.Value2 = arr;
						r.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
						r.Cells.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
					}
					else
					{
						dynamic[] arr = { i + 1, db.Rows[i]["Tên học phần"], db.Rows[i]["Số TC"], db.Rows[i]["Điểm TB"] };
						r = xlWorkSheet.get_Range("F" + (row + i - count), "I" + (row + i - count));
						r.Value2 = arr;
						r.Cells.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
						r.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
					}

				}

				xlWorkBook.SaveAs(sfd.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
				xlexcel.DisplayAlerts = true;
				xlWorkBook.Close(true, misValue, misValue);
				xlexcel.Quit();

				releaseObject(xlWorkSheet);
				releaseObject(xlWorkBook);
				releaseObject(xlexcel);

				// Clear Clipboard and DataGridView selection
				Clipboard.Clear();
				dataGridViewDTBvXL.ClearSelection();

				// Open the newly saved excel file
				//if (File.Exists(sfd.FileName))
				//    System.Diagnostics.Process.Start(sfd.FileName);
			}
		}
		private void buttonMore_Click(object sender, EventArgs e)
		{
			//MoreInfoHocVien moreInfo = new MoreInfoHocVien(textBoxMSHV.Text);
			//moreInfo.Show();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void dataGridViewDTBvXL_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			if (e.RowIndex < dataGridViewDTBvXL.Rows.Count)
				this.dataGridViewDTBvXL.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
		}

		private void dataGridViewXemDiem_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			if (e.RowIndex < dataGridViewXemDiem.Rows.Count)
				this.dataGridViewXemDiem.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
		}
	}
}
