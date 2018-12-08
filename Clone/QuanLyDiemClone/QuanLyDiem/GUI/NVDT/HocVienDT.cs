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
            textBoxNAME.Text = bLL.getHVBLL(MaHV);
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
