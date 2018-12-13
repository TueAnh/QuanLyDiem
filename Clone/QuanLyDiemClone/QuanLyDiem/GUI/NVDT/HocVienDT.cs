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
    public partial class HocVienDT : Form
    {
        #region InitandLoad
        public delegate void AddRemoveControl(Form form);
        public AddRemoveControl addControl;
        public AddRemoveControl removeControl;
        BLL.HocVienDT_BLL bLL = new HocVienDT_BLL();
        string MaHV;
        HocVien hv;
        List<int> strNH = new List<int>();
        List<string> strHK = new List<string>();
        List<int> strHKNH = new List<int>();
        public HocVienDT()
        {
            InitializeComponent();
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
            dataGridViewDTBvXL.Columns["STT"].Width = 50;
            dataGridViewXemDiem.Columns["STT"].Width = 50;
            loadCBB();
        }
        public HocVienDT(string str)
        {
            MaHV = str;
            InitializeComponent();
            LoadData();
        }
        private void HocVienDT_Load(object sender, EventArgs e)
        {
            //LoadData();
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
        #endregion
        #region RadioButton
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

        private void radioButtonQuaTrinh_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDoanXem.Items.Clear();
            comboBoxDoanXem.ResetText();
        }
        #endregion
        #region ButtonClick
        private void buttonXem_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonQuaTrinh.Checked == true)
                {
                    comboBoxDoanXem.Items.Clear();
                    comboBoxDoanXem.SelectedText = "";
                    //dataGridViewXemDiem.DataSource = null;
                    dataGridViewXemDiem.DataSource = bLL.getDiemQTBLL(MaHV);
                }
                if (radioButtonNamHoc.Checked == true)
                {
                   // dataGridViewXemDiem.DataSource = null;
                    dataGridViewXemDiem.DataSource = bLL.getDiemNHBLL(MaHV, strNH[comboBoxDoanXem.SelectedIndex]);
                }
                if (radioButtonHocKi.Checked == true)
                {
                   // dataGridViewXemDiem.DataSource = null;
                    dataGridViewXemDiem.DataSource = bLL.getDiemHKBLL(MaHV, strHKNH[comboBoxDoanXem.SelectedIndex],
                                                                    strHK[comboBoxDoanXem.SelectedIndex]);
                }
                dataGridViewXemDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch
            {

            }
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
        private void dataGridViewXemDiem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                GUI.NVDT.SuaDiemHocVienDT suaDiemHocVienDT_form = new SuaDiemHocVienDT(textBoxMSHV.Text, dataGridViewXemDiem.SelectedRows[0].Cells["Mã học phần"].Value.ToString());
                suaDiemHocVienDT_form.removeControl += new SuaDiemHocVienDT.AddRemoveControl(RemoveControlPanel);
                suaDiemHocVienDT_form.saveSuccess += new SuaDiemHocVienDT.SaveSuccess(LoadData);
                AddControlPanel(suaDiemHocVienDT_form);
                suaDiemHocVienDT_form.Dock = DockStyle.Fill;
            }
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
        #endregion

        private void buttonMore_Click(object sender, EventArgs e)
        {
            UserInfo form = new UserInfo(textBoxMSHV.Text.Trim());
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
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
            dataGridViewDTBvXL.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            if (dataGridViewDTBvXL.SelectedRows.Count == 1)
                dataGridViewDTBvXL.SelectAll();
            DataObject dataObj = dataGridViewDTBvXL.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void buttonOut_Click(object sender, EventArgs e)
        {
            DataTable db =  bLL.getDiemQTBLL(MaHV);
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
            
            //copyAlltoClipboard();
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

                //Dinh dang 

                Microsoft.Office.Interop.Excel.Range r = xlWorkSheet.get_Range("A1", "D1");
                r.MergeCells = true;
                r.Value2 = "ĐẠI HỌC ĐÀ NẴNG";
                r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                r = xlWorkSheet.get_Range("F1", "I1");
                r.MergeCells = true;
                r.Font.Bold = true;
                r.Value2 = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
                r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                r = xlWorkSheet.get_Range("A2", "D2");
                r.MergeCells = true;
                r.Font.Bold = true;
                r.Value2 = "TRƯỜNG ĐẠI HỌC BÁCH KHOA";
                r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                r = xlWorkSheet.get_Range("F2", "I2");
                r.MergeCells = true;
                r.Font.Bold = true;
                r.Value2 = "Độc lập - Tự do - Hạnh phúc";
                r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                r = xlWorkSheet.get_Range("A5", "I5");
                r.MergeCells = true;
                r.Value2 = "BẢNG ĐIỂM";
                r.Font.Size = 17;
                r.Font.Bold = true;
                r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                r = xlWorkSheet.get_Range("A7", "D7");
                r.MergeCells = true;
                r.Font.Size = 12;
                r.Value2 = "MSHV: "+hv.ID;

                r = xlWorkSheet.get_Range("F7", "I7");
                r.MergeCells = true;
                r.Font.Size = 12;
                r.Value2 = "Học viên: " + hv.HoTen;

                r = xlWorkSheet.get_Range("A8", "D8");
                r.MergeCells = true;
                r.Font.Size = 12;
                r.Value2 = String.Format("Ngày sinh: {0}/{1}/{2}", hv.NgaySinh.Value.Day, hv.NgaySinh.Value.Month, hv.NgaySinh.Value.Year);

                r = xlWorkSheet.get_Range("F8", "I8");
                r.MergeCells = true;
                r.Font.Size = 12;
                r.Value2 = "Lớp: "+bLL.GetTenLop(MaHV);

                r = xlWorkSheet.get_Range("A11", "A11");
                r.Font.Bold = true;
                r.MergeCells = true;
                r.Value2 = "STT";
                r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                r = xlWorkSheet.get_Range("B11", "B11");
                r.MergeCells = true;
                r.Font.Bold = true;
                r.Value2 = "Tên học phần";
                r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                r = xlWorkSheet.get_Range("C11", "C11");
                r.MergeCells = true;
                r.Value2 = "TC";
                r.Font.Bold = true;
                r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                r = xlWorkSheet.get_Range("D11", "D11");
                r.MergeCells = true;
                r.Value2 = "Điểm";
                r.Font.Bold = true;
                r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                r = xlWorkSheet.get_Range("F11", "F11");
                r.MergeCells = true;
                r.Value2 = "STT";
                r.Font.Bold = true;
                r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                r = xlWorkSheet.get_Range("G11", "G11");
                r.MergeCells = true;
                r.Value2 = "Tên học phần";
                r.Font.Bold = true;
                r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                r = xlWorkSheet.get_Range("H11", "H11");
                r.MergeCells = true;
                r.Value2 = "TC";
                r.Font.Bold = true;
                r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                r = xlWorkSheet.get_Range("I11", "I11");
                r.MergeCells = true;
                r.Value2 = "Điểm";
                r.Font.Bold = true;
                r.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;


                //dua diem vao
                int row = 12; 
                for (int i = 0; i < db.Rows.Count; i++)
                {
                    if ( i < count)
                    {
                        dynamic[] arr = { i + 1, db.Rows[i]["Tên học phần"], db.Rows[i]["Số TC"], db.Rows[i]["Điểm TB"] };
                        r = xlWorkSheet.get_Range("A"+(row + i), "D"+(row+i));
                        r.Value2 = arr;
                        r.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        r.Cells.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                    }
                    else
                    {
                        dynamic[] arr = { i + 1, db.Rows[i]["Tên học phần"], db.Rows[i]["Số TC"], db.Rows[i]["Điểm TB"] };
                        r = xlWorkSheet.get_Range("F" + (row + i - count), "I" + (row + i  - count));
                        r.Value2 = arr;
                        r.Cells.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
                        r.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    }

                }




                row = row + count;
                r = xlWorkSheet.get_Range("A"+row, "B"+row);
                r.MergeCells = true;
                r.Value2 = "(TC: số tín chỉ; Điểm: thang điểm 10)";
                row+=2;
                r = xlWorkSheet.get_Range("B" + row, "B" + row);
                r.MergeCells = true;
                r.Value2 = "Điểm trung bình học tập:";
                r = xlWorkSheet.get_Range("D" + row, "D" + row);
                r.MergeCells = true;
                if (flag)
                r.Value2 = Math.Round(dtb / tc, 2, MidpointRounding.AwayFromZero);
                row += 2;
                r = xlWorkSheet.get_Range("F" + row, "I" + row);
                r.MergeCells = true;
                r.Font.Italic = true;
                r.Value2 = String.Format("Đà Nẵng, ngày {0} tháng {1} năm {2}",
                    DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                

                row++;
                r = xlWorkSheet.get_Range("G" + row, "G" + row);
                r.MergeCells = true;
                r.Font.Size = 12;
                r.Font.Bold = true;
                r.Value2 = "NGƯỜI LẬP";
                r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row += 4;
                r = xlWorkSheet.get_Range("G" + row, "G" + row);
                r.MergeCells = true;
                r.Font.Size = 12;
                r.Font.Bold = true;
                r.Value2 = FormLogin.User.displayName;
                r.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                /*
                 
                Microsoft.Office.Interop.Excel.Range head = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Range[xlWorkSheet.Cells[1,1],xlWorkSheet.Cells[1,dataGridViewDTBvXL.ColumnCount]];
                head.MergeCells = true;
                head.Value2 = "TỔNG HỢP KẾT QUẢ HỌC TẬP";
                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                dataGridViewDTBvXL.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                dataGridViewDTBvXL.SelectAll();
                DataObject dataObj = dataGridViewDTBvXL.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[2, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                string X = (dataGridViewDTBvXL.RowCount + 5).ToString();

                Microsoft.Office.Interop.Excel.Range head2 = xlWorkSheet.get_Range("A"+X, "D"+X);
                head2.MergeCells = true;
                head2.Value2 = "CHI TIẾT";
                head2.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                dataGridViewXemDiem.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                dataGridViewXemDiem.SelectAll();
                dataObj = dataGridViewXemDiem.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[dataGridViewDTBvXL.RowCount + 7, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                // Save the excel file under the captured location from the SaveFileDialog
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
                dataGridViewDTBvXL.ClearSelection();

                // Open the newly saved excel file
                //if (File.Exists(sfd.FileName))
                //    System.Diagnostics.Process.Start(sfd.FileName);
            }

        }
    }
}
