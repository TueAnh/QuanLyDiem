﻿namespace QuanLyDiem.GUI.NVDT
{
    partial class ThemLopCH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxKhoa = new System.Windows.Forms.TextBox();
            this.textBoxTenLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaLop = new System.Windows.Forms.TextBox();
            this.labelMaLop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 266);
            this.panel1.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(245, 178);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 43);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Thêm lớp";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(381, 178);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(131, 43);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Thoát";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxKhoa);
            this.panel2.Controls.Add(this.textBoxTenLop);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxMaLop);
            this.panel2.Controls.Add(this.labelMaLop);
            this.panel2.Location = new System.Drawing.Point(64, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 126);
            this.panel2.TabIndex = 2;
            // 
            // textBoxKhoa
            // 
            this.textBoxKhoa.Location = new System.Drawing.Point(108, 75);
            this.textBoxKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKhoa.Name = "textBoxKhoa";
            this.textBoxKhoa.ReadOnly = true;
            this.textBoxKhoa.Size = new System.Drawing.Size(308, 22);
            this.textBoxKhoa.TabIndex = 1;
            // 
            // textBoxTenLop
            // 
            this.textBoxTenLop.Location = new System.Drawing.Point(108, 46);
            this.textBoxTenLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTenLop.Name = "textBoxTenLop";
            this.textBoxTenLop.Size = new System.Drawing.Size(308, 22);
            this.textBoxTenLop.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Lớp";
            // 
            // textBoxMaLop
            // 
            this.textBoxMaLop.Location = new System.Drawing.Point(155, 16);
            this.textBoxMaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaLop.Name = "textBoxMaLop";
            this.textBoxMaLop.Size = new System.Drawing.Size(261, 22);
            this.textBoxMaLop.TabIndex = 1;
            // 
            // labelMaLop
            // 
            this.labelMaLop.AutoSize = true;
            this.labelMaLop.Location = new System.Drawing.Point(32, 20);
            this.labelMaLop.Name = "labelMaLop";
            this.labelMaLop.Size = new System.Drawing.Size(55, 17);
            this.labelMaLop.TabIndex = 0;
            this.labelMaLop.Text = "Mã Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "LCH -";
            // 
            // ThemLopCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 266);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThemLopCH";
            this.Text = "ThemLopCH";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBoxKhoa;
		private System.Windows.Forms.TextBox textBoxTenLop;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxMaLop;
		private System.Windows.Forms.Label labelMaLop;
        private System.Windows.Forms.Label label1;
    }
}