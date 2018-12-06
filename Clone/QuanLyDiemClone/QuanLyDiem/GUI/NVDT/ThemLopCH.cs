﻿using System;
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
	public partial class ThemLopCH : Form
	{
        ThemLopCH_BLL bLL = new ThemLopCH_BLL();

        public ThemLopCH(string tenKhoa)
        {
            InitializeComponent();
            textBoxKhoa.Text = tenKhoa;
            //	LoadMaLop();
        }

        public bool checkMaLop()
        {
            if (textBoxMaLop.Text.Length != 3) return false;
            string s = textBoxMaLop.Text;
            for (int i = 0; i < 3; i++)
            {
                if (s[i] < '0' || s[i] > '9') return false;
            }
            return true;
        }

        //void LoadMaLop()
        //{
        //	string s = "LCH";
        //	if (bLL.getSoLopBLL()+1 < 100)
        //		s += "0";
        //	if (bLL.getSoLopBLL()+1 < 10)
        //		s += "0";
        //	s += (bLL.getSoLopBLL()+1);
        //	textBoxMaLop.Text = s;
        //}

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (bLL.checkMaKhoaBLL(textBoxTenLop.Text) && checkMaLop() && textBoxTenLop.Text != "")
            {
                try
                {
                    bLL.getAddLopBLL(new LopDaoTao
                    {
                        MaLop = "LCH" + textBoxMaLop.Text,
                        TenLop = textBoxTenLop.Text,
                        MaKhoa = bLL.getMaKhoaBLL(textBoxKhoa.Text),
                    });
                    MessageBox.Show("Thêm lớp thành công");
                }
                catch
                {
                    MessageBox.Show("Nhập sai !");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Trùng tên lớp");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}