﻿using QuanLyDiem.GUI;
using QuanLyDiem.GUI.NVDT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ThemLopHP());
            //Application.Run(new ThemLopCH("CNTT"));
        }
    }
}
