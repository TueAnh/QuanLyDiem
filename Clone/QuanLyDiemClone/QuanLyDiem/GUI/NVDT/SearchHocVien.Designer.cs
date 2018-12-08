﻿namespace QuanLyDiem.GUI.NVDT
{
    partial class SearchHocVien
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAddHV = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonReLoad = new System.Windows.Forms.Button();
            this.buttonSearchMaHV_HoTen = new System.Windows.Forms.Button();
            this.textBoxSearchMaHV_HoTen = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 607);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMargin = new System.Drawing.Size(5, 0);
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(208, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 584);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.buttonDel);
            this.panel3.Controls.Add(this.buttonAddHV);
            this.panel3.Controls.Add(this.buttonBack);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.buttonSort);
            this.panel3.Controls.Add(this.buttonReLoad);
            this.panel3.Controls.Add(this.buttonSearchMaHV_HoTen);
            this.panel3.Controls.Add(this.textBoxSearchMaHV_HoTen);
            this.panel3.Controls.Add(this.dataGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 582);
            this.panel3.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Theo Mã",
            "Theo Tên",
            "Theo Lớp",
            "Theo Khoa"});
            this.comboBox1.Location = new System.Drawing.Point(175, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 24);
            this.comboBox1.TabIndex = 24;
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonDel.Location = new System.Drawing.Point(571, 526);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(151, 38);
            this.buttonDel.TabIndex = 23;
            this.buttonDel.Text = "Xóa học viên";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAddHV
            // 
            this.buttonAddHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAddHV.Location = new System.Drawing.Point(417, 525);
            this.buttonAddHV.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddHV.Name = "buttonAddHV";
            this.buttonAddHV.Size = new System.Drawing.Size(147, 39);
            this.buttonAddHV.TabIndex = 22;
            this.buttonAddHV.Text = "Thêm học viên";
            this.buttonAddHV.UseVisualStyleBackColor = true;
            this.buttonAddHV.Click += new System.EventHandler(this.buttonAddHV_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBack.Location = new System.Drawing.Point(728, 526);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 39);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Trở lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(843, 70);
            this.panel4.TabIndex = 20;
            // 
            // buttonSort
            // 
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSort.Location = new System.Drawing.Point(21, 137);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(147, 28);
            this.buttonSort.TabIndex = 19;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click_1);
            // 
            // buttonReLoad
            // 
            this.buttonReLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonReLoad.Location = new System.Drawing.Point(728, 137);
            this.buttonReLoad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReLoad.Name = "buttonReLoad";
            this.buttonReLoad.Size = new System.Drawing.Size(100, 28);
            this.buttonReLoad.TabIndex = 18;
            this.buttonReLoad.Text = "Reload";
            this.buttonReLoad.UseVisualStyleBackColor = true;
            this.buttonReLoad.Click += new System.EventHandler(this.buttonReLoad_Click);
            // 
            // buttonSearchMaHV_HoTen
            // 
            this.buttonSearchMaHV_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSearchMaHV_HoTen.Location = new System.Drawing.Point(728, 97);
            this.buttonSearchMaHV_HoTen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchMaHV_HoTen.Name = "buttonSearchMaHV_HoTen";
            this.buttonSearchMaHV_HoTen.Size = new System.Drawing.Size(100, 28);
            this.buttonSearchMaHV_HoTen.TabIndex = 17;
            this.buttonSearchMaHV_HoTen.Text = "Search";
            this.buttonSearchMaHV_HoTen.UseVisualStyleBackColor = true;
            this.buttonSearchMaHV_HoTen.Click += new System.EventHandler(this.buttonSearchMaHV_HoTen_Click);
            // 
            // textBoxSearchMaHV_HoTen
            // 
            this.textBoxSearchMaHV_HoTen.Location = new System.Drawing.Point(404, 101);
            this.textBoxSearchMaHV_HoTen.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchMaHV_HoTen.Name = "textBoxSearchMaHV_HoTen";
            this.textBoxSearchMaHV_HoTen.Size = new System.Drawing.Size(316, 22);
            this.textBoxSearchMaHV_HoTen.TabIndex = 16;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(21, 174);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(805, 327);
            this.dataGridView.TabIndex = 15;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            this.dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(191, 582);
            this.treeView1.TabIndex = 10;
            // 
            // SearchHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1079, 607);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchHocVien";
            this.Text = "SearchHocVien";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonReLoad;
        private System.Windows.Forms.Button buttonSearchMaHV_HoTen;
        private System.Windows.Forms.TextBox textBoxSearchMaHV_HoTen;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Button buttonAddHV;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}