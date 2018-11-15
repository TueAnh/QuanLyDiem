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
            this.Hide();
            GUI.FormHome formHome = new GUI.FormHome(); 
            /*
            formHome.TopLevel = false;
            panel2.Controls.Add(formHome);
            formHome.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formHome.Dock = DockStyle.Fill;
            */
            formHome.Show();
        }
    }
}
