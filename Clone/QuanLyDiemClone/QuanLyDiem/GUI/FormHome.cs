using QuanLyDiem.BLL;
using QuanLyDiem.GUI.NVDT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.GUI
{
    public partial class FormHome : Form
    {
        private static User userAcc;
        public  static User UserAcc { get => userAcc; set => userAcc = value; }
        public FormHome(User user)
        { 
            UserAcc = user;
            InitializeComponent();
            PhanQuyenUsers();
            LoadInfo();
            LoadPanel();
            loadImage(user.Image);
        }
        public void LoadPanel()
        {
            
            this.panelTools2.Location = this.panelTools1.Location;
            this.panelTools2.Hide();
        }
        public void LoadInfo()
        {
            labelUserName.Text = UserAcc.displayName;
            labelHello.Visible = true;
            labelHello.Text = "Xin chào " + UserAcc.displayName;
        }
        public void ClearView()
        {
            if (this.panel2.Controls.Count > 1)
                this.panel2.Controls.RemoveAt(this.panel2.Controls.Count - 1);
        }
        private void buttonUserInfo_Click(object sender, EventArgs e)
        {
            ClearView();
            this.panelTools2.Hide();
            UserInfo formView = new UserInfo(userAcc);
            formView.updateImageSuccess += new UserInfo.UpdateImageSuccess(loadImage);
            AddControlPanel(formView);
            
            formView.Dock = DockStyle.Fill;
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
            this.panelTools2.Hide();
        }
        #region ViewBTT
        private void buttonViewHV_Click(object sender, EventArgs e)
        {
            if (UserAcc.typeAcc != 1)
            {
                ClearView();
                this.panelTools2.Hide();
                NVDT.SearchHocVien formView = new NVDT.SearchHocVien();
                formView.TopLevel = false;
                panel2.Controls.Add(formView);
                formView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formView.Dock = DockStyle.Fill;
                formView.Show();
            }
            else
            {
                ClearView();
                this.panelTools2.Hide();
                FormViewHV formView = new FormViewHV(UserAcc.ID);
                formView.TopLevel = false;
                panel2.Controls.Add(formView);
                formView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formView.Dock = DockStyle.Fill;
                formView.Show();
            }
            
        }
        private void buttonViewLHP_Click(object sender, EventArgs e)
        {
            ClearView();
            this.panelTools2.Hide();
            ViewLopHP formView = new ViewLopHP();
            formView.addControl += new ViewLopHP.AddRemoveControl(AddControlPanel);
            formView.removeControl += new ViewLopHP.AddRemoveControl(RemoveControlPanel);
            AddControlPanel(formView);
            formView.Dock = DockStyle.Fill;
        }

        private void buttonViewGV_Click(object sender, EventArgs e)
        {
            if (userAcc.typeAcc == 2)
            {
                ClearView();
                this.panelTools2.Hide();
                FormViewGV formView = new FormViewGV(userAcc.ID);
                formView.TopLevel = false;
                panel2.Controls.Add(formView);
                formView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formView.Dock = DockStyle.Fill;
                formView.Show();
            }
            else 
            {
                ClearView();
                this.panelTools2.Hide();
                SearchGiangVienDT formView = new SearchGiangVienDT();
                formView.TopLevel = false;
                panel2.Controls.Add(formView);
                formView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formView.Dock = DockStyle.Fill;
                formView.Show();
            }
        }


        private void buttonViewLSH_Click(object sender, EventArgs e)
        {
            ClearView();
            this.panelTools2.Hide();
            ViewLopDT formView = new ViewLopDT();
            formView.addControl += new ViewLopDT.AddRemoveControl(AddControlPanel);
            formView.removeControl += new ViewLopDT.AddRemoveControl(RemoveControlPanel);
            AddControlPanel(formView);
            formView.Dock = DockStyle.Fill;
         
        }

        #endregion

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
            if (this.panel2.Controls.Count >= 2)
                this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }
        public void RemoveControlPanel(Form form)
        {
            this.panel2.Controls.Remove(form);
            if (this.panel2.Controls.Count >= 2)
                this.panel2.Controls[panel2.Controls.Count - 2].Hide();
            this.panel2.Controls[panel2.Controls.Count - 1].Show();
        }
        
        public void PhanQuyenUsers()
        {
            if (userAcc.typeAcc == 1)
            {
                buttonViewGV.Enabled = false;
                buttonViewLHP.Enabled = false;
                buttonViewLSH.Enabled = false;
                return;
            }
            if (userAcc.typeAcc == 2)
            {
                //buttonViewLHP.Enabled = false;
                //buttonViewLSH.Enabled = false;
                return;              
            }
            if (UserAcc.typeAcc == 3)
            {
                //buttonViewGV.Enabled = false;
                return;
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.Blue, ButtonBorderStyle.Solid);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Blue, ButtonBorderStyle.Solid);
        }

        

        private void panelTools1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelTools1.ClientRectangle, Color.Yellow, ButtonBorderStyle.Solid);
        }

        private void panelTools2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelTools2.ClientRectangle, Color.Yellow, ButtonBorderStyle.Solid);
        }
        public void loadImage(byte[] data)
        {

            if (data == null)
            {
                pictureBox1.Image = null;
            }
            else
            {
                MemoryStream memoryStream = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(memoryStream);
            }
        }

        private void buttonDonate_Click(object sender, EventArgs e)
        {
            DonateUs du = new DonateUs();
            du.Show();
        }

        private void buttonFeedBack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mọi vấn đề xin vui lòng gửi mail về địa chỉ AHATeam@gmail.com hoặc gọi 0909-678-789", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"..\..\Resources\Help.pdf");
            }
            catch
            { }
        }
    }
}
