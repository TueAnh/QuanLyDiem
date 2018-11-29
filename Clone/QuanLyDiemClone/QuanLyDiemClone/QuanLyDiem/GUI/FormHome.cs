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
    public partial class FormHome : Form
    {
        public FormHome(int flag)
        {
            InitializeComponent();
        }
        public void LoadInfo()
        {
           // labelUserName = Login_BLL.LoadInfo()[1];
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
