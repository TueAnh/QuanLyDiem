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
using Microsoft.Office.Interop.Excel;
using System.IO;

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
            if (e.RowIndex != -1)
            {
                string MaHV = dataGridViewDSHV.SelectedRows[0].Cells["Mã HV"].Value.ToString();
                GUI.NVDT.SuaDiemHocVienDT suaDiemHocVienDT_form = new SuaDiemHocVienDT(MaHV, MaHP);
                suaDiemHocVienDT_form.removeControl += new SuaDiemHocVienDT.AddRemoveControl(RemoveControlPanel);
                suaDiemHocVienDT_form.saveSuccess += new SuaDiemHocVienDT.SaveSuccess(LoadData);
                AddControlPanel(suaDiemHocVienDT_form);
            }
        }
        #endregion

        private void buttonXem_Click(object sender, EventArgs e)
        {
                string MaHV = dataGridViewDSHV.SelectedRows[0].Cells["Mã HV"].Value.ToString();
                NVDT.HocVienDT f = new HocVienDT(MaHV);
                f.addControl += new HocVienDT.AddRemoveControl(AddControlPanel);
                f.removeControl += new HocVienDT.AddRemoveControl(RemoveControlPanel);
                AddControlPanel(f);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            ThemLopHP themLopHP = new ThemLopHP(textBoxLDT.Text);
            themLopHP.ShowDialog();
            this.removeControl(this);

        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string x = comboBox1.SelectedItem.ToString().Trim();
            if (x == null) { MessageBox.Show("Chọn loại sắp xếp ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {

                if (x.Length > 0)
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
                copyAlltoClipboard();
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
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

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
                try
                {
                    Microsoft.Office.Interop.Excel._Worksheet sheet = wb.Sheets[1];
                    Microsoft.Office.Interop.Excel.Range range = sheet.UsedRange;
                    //doc du lieu
                    int rows = range.Rows.Count;
                    int cols = range.Columns.Count;
                    System.Data.DataTable tb = new System.Data.DataTable();
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
                    dataGridViewDSHV.DataSource = tb;
                    releaseObject(app);
                    releaseObject(wb);
                    releaseObject(sheet);
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
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
                }
                catch
                {

                }
                int key = 
                bLL.UpdateKQHP(new KetQuaHocPhan
                {
                    DiemBT = DBT,
                    DiemGK = DGK,
                    DiemThi = DT
                }, r.Cells["Mã HV"].Value.ToString().Trim(), textBoxLDT.Text.Trim());
                if (key == -1) r.DefaultCellStyle.BackColor = Color.Red;
                if (key == 1 ) r.DefaultCellStyle.BackColor = Color.Lime;
                //    r.DefaultCellStyle.BackColor = Color.Lime;
                //else
                //    r.DefaultCellStyle.BackColor = Color.Red;
            }
            dataGridViewDSHV.ClearSelection();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dataGridViewDSHV.SelectedRows)
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

        private void buttonReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
