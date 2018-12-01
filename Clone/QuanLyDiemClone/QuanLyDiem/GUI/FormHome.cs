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
    public partial class FormHome : Form
    {
        private User userAcc;
        public User UserAcc { get => userAcc; set => userAcc = value; }
        public FormHome(User user)
        { 
            this.UserAcc = user;
            InitializeComponent();
            PhanQuyenUsers();
            LoadInfo();
            LoadPanel();
        }
        public void LoadPanel()
        {
            
            this.panelTools2.Location = this.panelTools1.Location;
            this.panelTools2.Hide();
        }
        public void LoadInfo()
        {
            labelUserName.Text = this.UserAcc.displayName;
            labelHello.Visible = true;
            labelHello.Text = "Xin chào " + this.UserAcc.displayName;
        }
        public void ClearView()
        {
            if (this.panel2.Controls.Count > 1)
                this.panel2.Controls.RemoveAt(this.panel2.Controls.Count - 1);
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonTools_Click(object sender, EventArgs e)
        {
            this.panelTools2.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //ClearView();
            this.panelTools2.Hide();
        }

        private void buttonViewHV_Click(object sender, EventArgs e)
        {
            if (this.UserAcc.typeAcc != 1)
            {
                ClearView();
                this.panelTools2.Hide();
                NVDT.SearchHocVien formView = new NVDT.SearchHocVien();
                formView.addControl += new SearchHocVien.AddRemoveControl(AddControlPanel);
                formView.removeControl += new SearchHocVien.AddRemoveControl(RemoveControlPanel);
                AddControlPanel(formView);
            }
            else
            {
                ClearView();
                this.panelTools2.Hide();
                FormViewHV formView = new FormViewHV(UserAcc.ID);
                formView.TopLevel = false;
                panel2.Controls.Add(formView);
                formView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formView.Dock = DockStyle.None;
                formView.Show();
            }
            
        }

        private void panel2_ControlAdded(object sender, ControlEventArgs e)
        {
            panel2.ScrollControlIntoView(e.Control);
        }
        public void AddControlPanel (Form form)
        {
            form.TopLevel = false;
            this.panel2.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.None;
            this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }
        public void RemoveControlPanel(Form form)
        {
            this.panel2.Controls.Remove(form);
            //this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }
        private void buttonViewLHP_Click(object sender, EventArgs e)
        {
            ClearView();
            this.panelTools2.Hide();
            ViewLopHP formView = new ViewLopHP();
            formView.addControl += new ViewLopHP.AddRemoveControl(AddControlPanel);
            formView.removeControl += new ViewLopHP.AddRemoveControl(RemoveControlPanel);
            AddControlPanel(formView);
            /*
            formView.TopLevel = false;
            panel2.Controls.Add(formView);
            formView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formView.Dock = DockStyle.None;
            formView.Show();
            */
        }

        private void buttonViewGV_Click(object sender, EventArgs e)
        {
            ClearView();
            this.panelTools2.Hide();
            FormViewGV formView = new FormViewGV();
            formView.TopLevel = false;
            panel2.Controls.Add(formView);
            formView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formView.Dock = DockStyle.None;
            formView.Show();
        }

        private void buttonViewLSH_Click(object sender, EventArgs e)
        {
            ClearView();
            this.panelTools2.Hide();
            ViewLopDT formView = new ViewLopDT();
            formView.addControl += new ViewLopDT.AddRemoveControl(AddControlPanel);
            formView.removeControl += new ViewLopDT.AddRemoveControl(RemoveControlPanel);
            AddControlPanel(formView);
            /*
            formView.TopLevel = false;
            panel2.Controls.Add(formView);
            formView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formView.Dock = DockStyle.None;
            formView.Show();
            */
        }
        public void PhanQuyenUsers()
        {
            if (userAcc.typeAcc == 1)
            {
                buttonViewGV.Enabled = false;
                buttonViewLHP.Enabled = false;
                buttonViewLSH.Enabled = false;
            }
        }
        private void labelUserName_Click(object sender, EventArgs e)
        {

        }
    }
}
