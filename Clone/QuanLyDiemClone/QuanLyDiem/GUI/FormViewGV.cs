using QuanLyDiem.BLL;
using QuanLyDiem.GUI.NVDT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.GUI
{
    public partial class FormViewGV : Form
    {
        #region DelegateFunction
        public delegate void AddRemoveControl(Form form);
        public AddRemoveControl addControl;
        public AddRemoveControl removeControl;
        public void AddControlPanel(Form form)
        {
            //addControl(form);
            form.TopLevel = false;
            this.panel2.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.None;
            this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }
        public void RemoveControlPanel(Form form)
        {
            //removeControl(form);
            this.panel2.Controls.Remove(form);
            if (this.panel2.Controls.Count >= 2)
                this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }
        #endregion


        string MaGV;
        public FormViewGV(string ID)
        {
            InitializeComponent();
            MaGV = ID;
        }

        private void FormViewGV_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(GiangVien_BLL.BLL.GetNode()[0]);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            int length1 = e.Node.Text.IndexOf(" năm học ");
            string s1= "";
            if (length1 > 0)
                s1 = e.Node.Text.Substring(0, length1);

            int length2 = e.Node.Text.IndexOf(" - ");
            string s2="";
            if (length2 > 0)
                s2 = e.Node.Text.Substring(length1 + 9, length2 - length1 - 9);
            if (s2 != "" && s1 != "")
            {
                var source = GiangVien_BLL.BLL.GetListHP(MaGV, s1, s2);
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("STT", "STT");
                dataGridView1.DataSource = source;
                dataGridView1.Columns[dataGridView1.ColumnCount - 2].HeaderText = "Mã học phần";
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].HeaderText = "Tên học phần";
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["STT"].Width = 50;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.Refresh();
                this.panel2.Controls.Add(dataGridView1);
                if (panel2.Controls.Count > 1)
                    this.panel2.Controls[panel2.Controls.Count - 2].Hide();
                this.panel2.Controls[panel2.Controls.Count - 1].Show();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 )
            {
                string MaHP = dataGridView1.SelectedRows[0].Cells["MaHP"].Value.ToString();
                LopHPDT f = new LopHPDT(MaHP);// mở form HPDT
                f.addControl += new LopHPDT.AddRemoveControl(AddControlPanel);
                f.removeControl += new LopHPDT.AddRemoveControl(RemoveControlPanel);
                AddControlPanel(f);
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            removeControl(this);
            this.Dispose();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < dataGridView1.Rows.Count)
                this.dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

    }
}
