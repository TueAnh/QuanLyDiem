﻿namespace QuanLyDiem.GUI.NVDT
{
    partial class LopSHDT
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKhoa = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxTenLop = new System.Windows.Forms.TextBox();
            this.textBoxMaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelML = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewDSHV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonThemHVExcel = new System.Windows.Forms.Button();
            this.buttonXoaHV = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxKhoa);
            this.panel1.Controls.Add(this.labelPath);
            this.panel1.Controls.Add(this.buttonThemHVExcel);
            this.panel1.Controls.Add(this.textBoxTenLop);
            this.panel1.Controls.Add(this.textBoxMaLop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelML);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.buttonXoaHV);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.dataGridViewDSHV);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 447);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(327, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Khoa";
            // 
            // textBoxKhoa
            // 
            this.textBoxKhoa.Location = new System.Drawing.Point(378, 19);
            this.textBoxKhoa.Multiline = true;
            this.textBoxKhoa.Name = "textBoxKhoa";
            this.textBoxKhoa.ReadOnly = true;
            this.textBoxKhoa.Size = new System.Drawing.Size(182, 23);
            this.textBoxKhoa.TabIndex = 21;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(12, 356);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(29, 13);
            this.labelPath.TabIndex = 19;
            this.labelPath.Text = "Path";
            this.labelPath.Visible = false;
            // 
            // textBoxTenLop
            // 
            this.textBoxTenLop.Enabled = false;
            this.textBoxTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxTenLop.Location = new System.Drawing.Point(87, 49);
            this.textBoxTenLop.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTenLop.Name = "textBoxTenLop";
            this.textBoxTenLop.Size = new System.Drawing.Size(170, 23);
            this.textBoxTenLop.TabIndex = 16;
            // 
            // textBoxMaLop
            // 
            this.textBoxMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxMaLop.Location = new System.Drawing.Point(87, 17);
            this.textBoxMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaLop.Name = "textBoxMaLop";
            this.textBoxMaLop.ReadOnly = true;
            this.textBoxMaLop.Size = new System.Drawing.Size(158, 23);
            this.textBoxMaLop.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên Lớp";
            // 
            // labelML
            // 
            this.labelML.AutoSize = true;
            this.labelML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelML.Location = new System.Drawing.Point(24, 17);
            this.labelML.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelML.Name = "labelML";
            this.labelML.Size = new System.Drawing.Size(62, 20);
            this.labelML.TabIndex = 15;
            this.labelML.Text = "Mã Lớp";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(378, 48);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(141, 24);
            this.textBoxSearch.TabIndex = 12;
            // 
            // dataGridViewDSHV
            // 
            this.dataGridViewDSHV.AllowUserToAddRows = false;
            this.dataGridViewDSHV.AllowUserToDeleteRows = false;
            this.dataGridViewDSHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSHV.Location = new System.Drawing.Point(15, 89);
            this.dataGridViewDSHV.Name = "dataGridViewDSHV";
            this.dataGridViewDSHV.ReadOnly = true;
            this.dataGridViewDSHV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDSHV.Size = new System.Drawing.Size(579, 261);
            this.dataGridViewDSHV.TabIndex = 8;
            this.dataGridViewDSHV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSHV_CellDoubleClick);
            this.dataGridViewDSHV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewDSHV_RowPostPaint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightYellow;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::QuanLyDiem.Properties.Resources.reload32;
            this.button1.Location = new System.Drawing.Point(553, 307);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 43);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonThemHVExcel
            // 
            this.buttonThemHVExcel.Image = global::QuanLyDiem.Properties.Resources.csv_321;
            this.buttonThemHVExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThemHVExcel.Location = new System.Drawing.Point(15, 374);
            this.buttonThemHVExcel.Name = "buttonThemHVExcel";
            this.buttonThemHVExcel.Size = new System.Drawing.Size(90, 33);
            this.buttonThemHVExcel.TabIndex = 18;
            this.buttonThemHVExcel.Text = "Excel ...";
            this.buttonThemHVExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThemHVExcel.UseVisualStyleBackColor = true;
            this.buttonThemHVExcel.Click += new System.EventHandler(this.buttonThemHVExcel_Click);
            // 
            // buttonXoaHV
            // 
            this.buttonXoaHV.Image = global::QuanLyDiem.Properties.Resources.important;
            this.buttonXoaHV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonXoaHV.Location = new System.Drawing.Point(484, 356);
            this.buttonXoaHV.Name = "buttonXoaHV";
            this.buttonXoaHV.Size = new System.Drawing.Size(110, 50);
            this.buttonXoaHV.TabIndex = 10;
            this.buttonXoaHV.Text = "Xóa học viên";
            this.buttonXoaHV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonXoaHV.UseVisualStyleBackColor = true;
            this.buttonXoaHV.Click += new System.EventHandler(this.buttonXoaHV_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::QuanLyDiem.Properties.Resources.Ribbon_Add_32x32;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(351, 356);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 51);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Thêm học viên";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdđ_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::QuanLyDiem.Properties.Resources.Save__1_;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(111, 374);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(76, 35);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonBack.Image = global::QuanLyDiem.Properties.Resources.Back32;
            this.buttonBack.Location = new System.Drawing.Point(554, 412);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 32);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonSearch.Image = global::QuanLyDiem.Properties.Resources.Ribbon_Preview_16x16;
            this.buttonSearch.Location = new System.Drawing.Point(519, 47);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(41, 25);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // LopSHDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(614, 468);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LopSHDT";
            this.Text = "LopSHDT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewDSHV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelML;
        private System.Windows.Forms.TextBox textBoxTenLop;
        private System.Windows.Forms.TextBox textBoxMaLop;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonThemHVExcel;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKhoa;
        private System.Windows.Forms.Button buttonXoaHV;
        private System.Windows.Forms.Button button1;
    }
}