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
                string MaHV = dataGridViewDSHV.SelectedRows[0].Cells["Mã số"].Value.ToString();
                GUI.NVDT.SuaDiemHocVienDT suaDiemHocVienDT_form = new SuaDiemHocVienDT(MaHV, MaHP);
                suaDiemHocVienDT_form.removeControl += new SuaDiemHocVienDT.AddRemoveControl(RemoveControlPanel);
                suaDiemHocVienDT_form.saveSuccess += new SuaDiemHocVienDT.SaveSuccess(LoadData);
                AddControlPanel(suaDiemHocVienDT_form);
            }
        }
        #endregion

        private void buttonXem_Click(object sender, EventArgs e)
        {
                string MaHV = dataGridViewDSHV.SelectedRows[0].Cells["Mã số"].Value.ToString();
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
                    if (File.Exists(sfd.FileName))
                        System.Diagnostics.Process.Start(sfd.FileName);
                }
            
        }
    }
}
