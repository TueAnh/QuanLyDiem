using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiem.BLL;

namespace QuanLyDiem.GUI.NVDT
{
    public partial class HocVienDT : Form
    {
		BLL.HocVienDT_BLL bLL = new HocVienDT_BLL();
		string MaHV;
		List<int> strNH = new List<int>();
		List<string> strHK = new List<string>();
		List<int> strHKNH = new List<int>();
		public HocVienDT(string str)
        {
            InitializeComponent();
			MaHV = str;
			textBoxMSHV.Text = MaHV;
			textBoxNAME.Text = bLL.getHVBLL(MaHV);
			dataGridViewDTBvXL.DataSource = bLL.getDTBvXLBLL(MaHV);
			dataGridViewDTBvXL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			radioButtonQuaTrinh.Checked = true;
			dataGridViewXemDiem.DataSource = bLL.getDiemQTBLL(MaHV);
			dataGridViewXemDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

		private void radioButtonNamHoc_CheckedChanged(object sender, EventArgs e)
		{
			comboBoxDoanXem.Items.Clear();
			comboBoxDoanXem.ResetText();
			if (radioButtonNamHoc.Checked == true)
			{
				comboBoxDoanXem.Items.Clear();
				foreach(int y in strNH)
				{
					comboBoxDoanXem.Items.Add("Năm học "+y+" - "+(y+1));

				}
			}
		}

		private void radioButtonHocKi_CheckedChanged(object sender, EventArgs e)
		{
			comboBoxDoanXem.Items.Clear();
			comboBoxDoanXem.ResetText();
			if (radioButtonHocKi.Checked == true)
			{
				for (int i=0;i<strHK.Count;i++)
				{
					comboBoxDoanXem.Items.Add(strHK[i] + " Năm học " + strHKNH[i] +" - "+(strHKNH[i] + 1));
				}
			}
		}

		private void radioButtonQuaTrinh_CheckedChanged(object sender, EventArgs e)
		{
			comboBoxDoanXem.Items.Clear();
			comboBoxDoanXem.ResetText();
		}

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
				dataGridViewXemDiem.DataSource = bLL.getDiemNHBLL( MaHV , strNH[comboBoxDoanXem.SelectedIndex]);
			}
			if(radioButtonHocKi.Checked == true)
			{
				dataGridViewXemDiem.DataSource = null;
				dataGridViewXemDiem.DataSource = bLL.getDiemHKBLL(MaHV, strHKNH[comboBoxDoanXem.SelectedIndex],
																strHK[comboBoxDoanXem.SelectedIndex]);
			}
			dataGridViewXemDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
		}

        private void dataGridViewXemDiem_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            GUI.NVDT.SuaDiemHocVienDT suaDiemHocVienDT_form = new SuaDiemHocVienDT(textBoxMSHV.Text, dataGridViewXemDiem.SelectedRows[0].Cells["Mã học phần"].Value.ToString());
            suaDiemHocVienDT_form.Show();
        }
    }
}
