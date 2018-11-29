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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int flag = Login_BLL.BLL.CheckLogin(textBoxID.Text, textBoxPass.Text);
            if (flag != -1)
            {

                this.Hide();
                GUI.FormHome formHome = new GUI.FormHome(flag);
                formHome.ShowDialog();
                this.Show();
            }
            else
            {
                this.labelNoti.Text = "Sai ID và password!!";
                this.labelNoti.Visible = true;

            }
            /*
            formHome.TopLevel = false;
            panel2.Controls.Add(formHome);
            formHome.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formHome.Dock = DockStyle.Fill;
            */
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
	}
}
