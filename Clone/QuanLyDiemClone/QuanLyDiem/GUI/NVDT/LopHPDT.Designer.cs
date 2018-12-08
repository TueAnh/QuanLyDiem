namespace QuanLyDiem.GUI.NVDT
{
    partial class LopHPDT
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
            this.buttonSort = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelMaHP = new System.Windows.Forms.Label();
            this.textBoxLDT = new System.Windows.Forms.TextBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonXem = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBoxGVPT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewDSHV = new System.Windows.Forms.DataGridView();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSort);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.buttonChange);
            this.panel1.Controls.Add(this.labelMaHP);
            this.panel1.Controls.Add(this.textBoxLDT);
            this.panel1.Controls.Add(this.panelButton);
            this.panel1.Controls.Add(this.textBoxGVPT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.dataGridViewDSHV);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 513);
            this.panel1.TabIndex = 0;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(715, 57);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(100, 26);
            this.buttonSort.TabIndex = 32;
            this.buttonSort.Text = "Lọc";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Theo Mã",
            "Theo Tên",
            "Theo Điểm TB"});
            this.comboBox1.Location = new System.Drawing.Point(483, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 24);
            this.comboBox1.TabIndex = 31;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(408, 25);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(68, 58);
            this.buttonChange.TabIndex = 30;
            this.buttonChange.Text = "Chỉnh sửa";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelMaHP
            // 
            this.labelMaHP.AutoSize = true;
            this.labelMaHP.Location = new System.Drawing.Point(21, 57);
            this.labelMaHP.Name = "labelMaHP";
            this.labelMaHP.Size = new System.Drawing.Size(94, 17);
            this.labelMaHP.TabIndex = 29;
            this.labelMaHP.Text = "Mã học phần:";
            // 
            // textBoxLDT
            // 
            this.textBoxLDT.Location = new System.Drawing.Point(147, 57);
            this.textBoxLDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLDT.Name = "textBoxLDT";
            this.textBoxLDT.ReadOnly = true;
            this.textBoxLDT.Size = new System.Drawing.Size(255, 22);
            this.textBoxLDT.TabIndex = 28;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonXoa);
            this.panelButton.Controls.Add(this.buttonReload);
            this.panelButton.Controls.Add(this.buttonUpdate);
            this.panelButton.Controls.Add(this.labelPath);
            this.panelButton.Controls.Add(this.buttonXem);
            this.panelButton.Controls.Add(this.buttonBack);
            this.panelButton.Controls.Add(this.buttonOut);
            this.panelButton.Controls.Add(this.buttonInput);
            this.panelButton.Location = new System.Drawing.Point(11, 453);
            this.panelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(819, 60);
            this.panelButton.TabIndex = 27;
            // 
            // buttonXem
            // 
            this.buttonXem.Location = new System.Drawing.Point(605, 15);
            this.buttonXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(123, 23);
            this.buttonXem.TabIndex = 0;
            this.buttonXem.Text = "Xem học viên";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(734, 15);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(82, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Trở lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(142, 15);
            this.buttonOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(129, 23);
            this.buttonOut.TabIndex = 0;
            this.buttonOut.Text = "Xuất ra Excel";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(3, 15);
            this.buttonInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(133, 23);
            this.buttonInput.TabIndex = 0;
            this.buttonInput.Text = "Nhập từ Excel";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // textBoxGVPT
            // 
            this.textBoxGVPT.Location = new System.Drawing.Point(147, 27);
            this.textBoxGVPT.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGVPT.Name = "textBoxGVPT";
            this.textBoxGVPT.ReadOnly = true;
            this.textBoxGVPT.Size = new System.Drawing.Size(255, 22);
            this.textBoxGVPT.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "GV phụ trách : ";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(483, 27);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(223, 22);
            this.textBoxSearch.TabIndex = 23;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(715, 25);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 28);
            this.buttonSearch.TabIndex = 22;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewDSHV
            // 
            this.dataGridViewDSHV.AllowUserToAddRows = false;
            this.dataGridViewDSHV.AllowUserToDeleteRows = false;
            this.dataGridViewDSHV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSHV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDSHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSHV.Location = new System.Drawing.Point(9, 103);
            this.dataGridViewDSHV.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDSHV.Name = "dataGridViewDSHV";
            this.dataGridViewDSHV.ReadOnly = true;
            this.dataGridViewDSHV.RowHeadersVisible = false;
            this.dataGridViewDSHV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDSHV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDSHV.Size = new System.Drawing.Size(819, 342);
            this.dataGridViewDSHV.TabIndex = 19;
            this.dataGridViewDSHV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSHV_CellDoubleClick);
            this.dataGridViewDSHV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewDSHV_RowPostPaint);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(12, 40);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(46, 17);
            this.labelPath.TabIndex = 1;
            this.labelPath.Text = "label2";
            this.labelPath.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(277, 15);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(114, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Cập nhập";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(521, 15);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(36, 23);
            this.buttonReload.TabIndex = 3;
            this.buttonReload.Text = "+";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(563, 15);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(36, 23);
            this.buttonXoa.TabIndex = 3;
            this.buttonXoa.Text = "-";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // LopHPDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(843, 519);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LopHPDT";
            this.Text = "LopHPDT";
            this.Load += new System.EventHandler(this.LopHPDT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panelButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxGVPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewDSHV;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Label labelMaHP;
        private System.Windows.Forms.TextBox textBoxLDT;
        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonReload;
    }
}