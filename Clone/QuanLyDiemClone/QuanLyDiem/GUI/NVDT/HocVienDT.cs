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
            if (radioButtonQuaTrinh.Checked == true)
            {
                comboBoxDoanXem.Items.Clear();
                comboBoxDoanXem.SelectedText = "";
                dataGridViewXemDiem.DataSource = null;
                dataGridViewXemDiem.DataSource = bLL.getDiemQTBLL(MaHV);
            }
            if (radioButtonNamHoc.Checked == true)
            {
                dataGridViewXemDiem.DataSource = null;
                dataGridViewXemDiem.DataSource = bLL.getDiemNHBLL(MaHV, strNH[comboBoxDoanXem.SelectedIndex]);
            }
            if (radioButtonHocKi.Checked == true)
            {
                dataGridViewXemDiem.DataSource = null;
                dataGridViewXemDiem.DataSource = bLL.getDiemHKBLL(MaHV, strHKNH[comboBoxDoanXem.SelectedIndex],
                                                                strHK[comboBoxDoanXem.SelectedIndex]);
            }
            dataGridViewXemDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
    }
}
