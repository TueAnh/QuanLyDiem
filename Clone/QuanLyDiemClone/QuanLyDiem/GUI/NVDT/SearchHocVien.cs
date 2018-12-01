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
    public partial class SearchHocVien : Form
    {
        SearchHocVien_BLL Search_bll = new SearchHocVien_BLL();
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
            if (panel2.Controls.Count > 1)
                this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }
        public void RemoveControlPanel(Form form)
        {
            //removeControl(form);
            this.panel2.Controls.Remove(form);
            if (panel2.Controls.Count > 1)
                this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }
        
        public SearchHocVien()
        {
            InitializeComponent();
            LoadAllHocVien();
        }
        void LoadAllHocVien()
        {
            dataGridView.DataSource = Search_bll.LoadAllHocVien();
        }

        private void buttonReLoad_Click(object sender, EventArgs e)
        {
            LoadAllHocVien();
        }

        private void buttonSearchMaHV_HoTen_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = Search_bll.LoadSearchedHocVien(textBoxSearchMaHV_HoTen.Text);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HocVienDT hocVienDT = new HocVienDT(dataGridView.SelectedRows[0].Cells["Mã Học Viên"].Value.ToString());
            hocVienDT.addControl += new HocVienDT.AddRemoveControl(AddControlPanel);
            hocVienDT.removeControl += new HocVienDT.AddRemoveControl(RemoveControlPanel);
            AddControlPanel(hocVienDT);
        }
    }
}
