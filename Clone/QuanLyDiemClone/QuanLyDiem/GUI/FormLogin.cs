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

namespace QuanLyDiem
{
    public partial class FormLogin : Form
    {
        private static User user;
        public static User User { get => user; set => user = value; }

        public FormLogin()
        {
            InitializeComponent();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            int flag = Login_BLL.BLL.CheckLogin(textBoxID.Text, textBoxPass.Text);
            if (flag != -1)
            {
                User = Login_BLL.BLL.GetUser(flag, textBoxID.Text);
                this.Hide();
                GUI.FormHome formHome = new GUI.FormHome(User);
                formHome.ShowDialog();
                textBoxPass.Text = "";
                this.Show();
                this.labelNoti.Visible = false;
            }
            else
            {
                this.labelNoti.Visible = true;

            }
           
            this.UseWaitCursor = false;
          
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
