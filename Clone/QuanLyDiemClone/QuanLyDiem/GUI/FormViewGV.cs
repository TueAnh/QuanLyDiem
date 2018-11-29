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

namespace QuanLyDiem.GUI
{
    public partial class FormViewGV : Form
    {
        public FormViewGV()
        {
            InitializeComponent();
            
        }

        private void FormViewGV_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = Login_BLL.BLL.GetList().ToList();
            treeView1.Nodes.Add(Login_BLL.BLL.GetNode()[0]);
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
                var source = Login_BLL.BLL.GetListHP("GV010", s1, s2);
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = source;
                dataGridView1.Columns[dataGridView1.ColumnCount - 2].HeaderText = "Mã học phần";
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].HeaderText = "Tên học phần";
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            //MessageBox.Show("dataGridView1.SelectedRows[0].Cells[0].ToString()");
            //NVDT.LopHPDT lopHPDT = new NVDT.LopHPDT(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            //lopHPDT.ShowDialog();
            
            dataGridView1.DataSource = Login_BLL.BLL.GetListHV(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            /*
            dataGridView1.Columns.Add("DTB","DTB");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["DTB"].Value = (Convert.ToDouble(row.Cells["DiemBT"].Value) * 0.2 +
                                          Convert.ToDouble(row.Cells["DiemGK"].Value) * 0.2 +
                                          Convert.ToDouble(row.Cells["DiemThi"].Value) * 0.6).ToString();
            }
            */
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
