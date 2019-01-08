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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelMaHP = new System.Windows.Forms.Label();
            this.textBoxLDT = new System.Windows.Forms.TextBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonXem = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBoxGVPT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewDSHV = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPath);
            this.panel1.Controls.Add(this.buttonSort);
            this.panel1.Controls.Add(this.buttonReload);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 513);
            this.panel1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.panel1, "Lọc theo");
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(14, 479);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(46, 17);
            this.labelPath.TabIndex = 1;
            this.labelPath.Text = "label2";
            this.labelPath.Visible = false;
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.White;
            this.buttonSort.Image = global::QuanLyDiem.Properties.Resources.data_sort_icon__1_;
            this.buttonSort.Location = new System.Drawing.Point(545, 39);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(44, 40);
            this.buttonSort.TabIndex = 32;
            this.toolTip1.SetToolTip(this.buttonSort, "Lọc theo");
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.BackColor = System.Drawing.Color.White;
            this.buttonReload.Image = global::QuanLyDiem.Properties.Resources.Actions_view_refresh_icon__1_;
            this.buttonReload.Location = new System.Drawing.Point(788, 394);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(41, 38);
            this.buttonReload.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonReload, "Làm mới");
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Theo Mã",
            "Theo Tên",
            "Theo Điểm TB"});
            this.comboBox1.Location = new System.Drawing.Point(595, 49);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 24);
            this.comboBox1.TabIndex = 31;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.White;
            this.buttonChange.Image = global::QuanLyDiem.Properties.Resources.Edit_icon;
            this.buttonChange.Location = new System.Drawing.Point(384, 14);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(56, 55);
            this.buttonChange.TabIndex = 30;
            this.toolTip1.SetToolTip(this.buttonChange, "Chỉnh sửa lớp học phần");
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelMaHP
            // 
            this.labelMaHP.AutoSize = true;
            this.labelMaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMaHP.Location = new System.Drawing.Point(12, 49);
            this.labelMaHP.Name = "labelMaHP";
            this.labelMaHP.Size = new System.Drawing.Size(98, 18);
            this.labelMaHP.TabIndex = 29;
            this.labelMaHP.Text = "Mã học phần:";
            // 
            // textBoxLDT
            // 
            this.textBoxLDT.Location = new System.Drawing.Point(121, 49);
            this.textBoxLDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLDT.Name = "textBoxLDT";
            this.textBoxLDT.ReadOnly = true;
            this.textBoxLDT.Size = new System.Drawing.Size(255, 22);
            this.textBoxLDT.TabIndex = 28;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.GhostWhite;
            this.panelButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButton.Controls.Add(this.buttonAdd);
            this.panelButton.Controls.Add(this.buttonXoa);
            this.panelButton.Controls.Add(this.buttonUpdate);
            this.panelButton.Controls.Add(this.buttonXem);
            this.panelButton.Controls.Add(this.buttonBack);
            this.panelButton.Controls.Add(this.buttonOut);
            this.panelButton.Controls.Add(this.buttonInput);
            this.panelButton.Location = new System.Drawing.Point(10, 436);
            this.panelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(819, 44);
            this.panelButton.TabIndex = 27;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Image = global::QuanLyDiem.Properties.Resources.database_add_icon__1_;
            this.buttonAdd.Location = new System.Drawing.Point(144, 2);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(41, 38);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonAdd, "Thêm học viên");
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.White;
            this.buttonXoa.Image = global::QuanLyDiem.Properties.Resources.database_remove_icon;
            this.buttonXoa.Location = new System.Drawing.Point(192, 2);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(41, 38);
            this.buttonXoa.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonXoa, "Xóa học viên");
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.White;
            this.buttonUpdate.Image = global::QuanLyDiem.Properties.Resources.database_accept_icon;
            this.buttonUpdate.Location = new System.Drawing.Point(96, 2);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(41, 38);
            this.buttonUpdate.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonUpdate, "Lưu");
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonXem
            // 
            this.buttonXem.BackColor = System.Drawing.Color.White;
            this.buttonXem.Image = global::QuanLyDiem.Properties.Resources.student_boy_icon__1_;
            this.buttonXem.Location = new System.Drawing.Point(239, 2);
            this.buttonXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(41, 38);
            this.buttonXem.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonXem, "Xem học viên");
            this.buttonXem.UseVisualStyleBackColor = false;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.Image = global::QuanLyDiem.Properties.Resources.arrow_return_right_up_icon__1_;
            this.buttonBack.Location = new System.Drawing.Point(774, 2);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(41, 38);
            this.buttonBack.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonBack, "Trở lại");
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.BackColor = System.Drawing.Color.White;
            this.buttonOut.Image = global::QuanLyDiem.Properties.Resources.export_excel_icon;
            this.buttonOut.Location = new System.Drawing.Point(49, 2);
            this.buttonOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(41, 38);
            this.buttonOut.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonOut, "Xuất ra Excel");
            this.buttonOut.UseVisualStyleBackColor = false;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonInput
            // 
            this.buttonInput.BackColor = System.Drawing.Color.White;
            this.buttonInput.Image = global::QuanLyDiem.Properties.Resources.excel_icon;
            this.buttonInput.Location = new System.Drawing.Point(2, 2);
            this.buttonInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(41, 38);
            this.buttonInput.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonInput, "Nhập từ Excel");
            this.buttonInput.UseVisualStyleBackColor = false;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // textBoxGVPT
            // 
            this.textBoxGVPT.Location = new System.Drawing.Point(121, 13);
            this.textBoxGVPT.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGVPT.Name = "textBoxGVPT";
            this.textBoxGVPT.ReadOnly = true;
            this.textBoxGVPT.Size = new System.Drawing.Size(255, 22);
            this.textBoxGVPT.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "GV phụ trách : ";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(545, 13);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(223, 22);
            this.textBoxSearch.TabIndex = 23;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.White;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.Image = global::QuanLyDiem.Properties.Resources.search_button_green_icon;
            this.buttonSearch.Location = new System.Drawing.Point(777, 5);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(41, 38);
            this.buttonSearch.TabIndex = 22;
            this.toolTip1.SetToolTip(this.buttonSearch, "Tìm kiếm");
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewDSHV
            // 
            this.dataGridViewDSHV.AllowUserToAddRows = false;
            this.dataGridViewDSHV.AllowUserToDeleteRows = false;
            this.dataGridViewDSHV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDSHV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDSHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSHV.Location = new System.Drawing.Point(10, 90);
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
            // LopHPDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(836, 513);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LopHPDT";
            this.Text = "LopHPDT";
            this.Load += new System.EventHandler(this.LopHPDT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelButton.ResumeLayout(false);
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonAdd;
    }
}