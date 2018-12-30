namespace QuanLyDiem.GUI.NVDT
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
            this.components = new System.ComponentModel.Container();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonXoaHV = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonThemHVExcel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelPath);
            this.panel1.Controls.Add(this.dataGridViewDSHV);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 550);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(443, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Khoa";
            // 
            // textBoxKhoa
            // 
            this.textBoxKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxKhoa.Location = new System.Drawing.Point(497, 9);
            this.textBoxKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxKhoa.Name = "textBoxKhoa";
            this.textBoxKhoa.ReadOnly = true;
            this.textBoxKhoa.Size = new System.Drawing.Size(241, 26);
            this.textBoxKhoa.TabIndex = 21;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(25, 531);
            this.labelPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(37, 17);
            this.labelPath.TabIndex = 19;
            this.labelPath.Text = "Path";
            this.labelPath.Visible = false;
            // 
            // textBoxTenLop
            // 
            this.textBoxTenLop.Enabled = false;
            this.textBoxTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxTenLop.Location = new System.Drawing.Point(100, 43);
            this.textBoxTenLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTenLop.Name = "textBoxTenLop";
            this.textBoxTenLop.Size = new System.Drawing.Size(274, 26);
            this.textBoxTenLop.TabIndex = 16;
            // 
            // textBoxMaLop
            // 
            this.textBoxMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxMaLop.Location = new System.Drawing.Point(100, 10);
            this.textBoxMaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaLop.Name = "textBoxMaLop";
            this.textBoxMaLop.ReadOnly = true;
            this.textBoxMaLop.Size = new System.Drawing.Size(274, 26);
            this.textBoxMaLop.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên Lớp";
            // 
            // labelML
            // 
            this.labelML.AutoSize = true;
            this.labelML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelML.Location = new System.Drawing.Point(16, 13);
            this.labelML.Name = "labelML";
            this.labelML.Size = new System.Drawing.Size(65, 20);
            this.labelML.TabIndex = 15;
            this.labelML.Text = "Mã Lớp";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(525, 43);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(213, 26);
            this.textBoxSearch.TabIndex = 12;
            // 
            // dataGridViewDSHV
            // 
            this.dataGridViewDSHV.AllowUserToAddRows = false;
            this.dataGridViewDSHV.AllowUserToDeleteRows = false;
            this.dataGridViewDSHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSHV.Location = new System.Drawing.Point(20, 100);
            this.dataGridViewDSHV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDSHV.Name = "dataGridViewDSHV";
            this.dataGridViewDSHV.ReadOnly = true;
            this.dataGridViewDSHV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDSHV.Size = new System.Drawing.Size(793, 367);
            this.dataGridViewDSHV.TabIndex = 8;
            this.dataGridViewDSHV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSHV_CellDoubleClick);
            this.dataGridViewDSHV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewDSHV_RowPostPaint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxMaLop);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.textBoxKhoa);
            this.panel2.Controls.Add(this.labelML);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxTenLop);
            this.panel2.Location = new System.Drawing.Point(20, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 82);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonBack);
            this.panel3.Controls.Add(this.buttonXoaHV);
            this.panel3.Controls.Add(this.buttonAdd);
            this.panel3.Controls.Add(this.buttonThemHVExcel);
            this.panel3.Controls.Add(this.buttonSave);
            this.panel3.Location = new System.Drawing.Point(20, 486);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(793, 44);
            this.panel3.TabIndex = 24;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.Image = global::QuanLyDiem.Properties.Resources.arrow_return_right_up_icon__1_;
            this.buttonBack.Location = new System.Drawing.Point(748, 2);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(41, 38);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonXoaHV
            // 
            this.buttonXoaHV.BackColor = System.Drawing.Color.White;
            this.buttonXoaHV.Image = global::QuanLyDiem.Properties.Resources.database_remove_icon;
            this.buttonXoaHV.Location = new System.Drawing.Point(699, 2);
            this.buttonXoaHV.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXoaHV.Name = "buttonXoaHV";
            this.buttonXoaHV.Size = new System.Drawing.Size(41, 38);
            this.buttonXoaHV.TabIndex = 10;
            this.buttonXoaHV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonXoaHV, "Xóa học viên");
            this.buttonXoaHV.UseVisualStyleBackColor = false;
            this.buttonXoaHV.Click += new System.EventHandler(this.buttonXoaHV_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Image = global::QuanLyDiem.Properties.Resources.database_add_icon__1_;
            this.buttonAdd.Location = new System.Drawing.Point(650, 2);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(41, 38);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonAdd, "Thêm một học viên");
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdđ_Click);
            // 
            // buttonThemHVExcel
            // 
            this.buttonThemHVExcel.BackColor = System.Drawing.Color.White;
            this.buttonThemHVExcel.Image = global::QuanLyDiem.Properties.Resources.excel_icon;
            this.buttonThemHVExcel.Location = new System.Drawing.Point(0, 2);
            this.buttonThemHVExcel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThemHVExcel.Name = "buttonThemHVExcel";
            this.buttonThemHVExcel.Size = new System.Drawing.Size(41, 38);
            this.buttonThemHVExcel.TabIndex = 18;
            this.buttonThemHVExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonThemHVExcel, "Thêm học viên từ Excel");
            this.buttonThemHVExcel.UseVisualStyleBackColor = false;
            this.buttonThemHVExcel.Click += new System.EventHandler(this.buttonThemHVExcel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.Image = global::QuanLyDiem.Properties.Resources.database_accept_icon;
            this.buttonSave.Location = new System.Drawing.Point(49, 2);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(41, 38);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.buttonSave, "Lưu");
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.White;
            this.buttonSearch.Image = global::QuanLyDiem.Properties.Resources.search_button_green_icon;
            this.buttonSearch.Location = new System.Drawing.Point(741, 38);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(41, 38);
            this.buttonSearch.TabIndex = 11;
            this.toolTip1.SetToolTip(this.buttonSearch, "Tìm kiếm");
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::QuanLyDiem.Properties.Resources.Actions_view_refresh_icon__1_;
            this.button1.Location = new System.Drawing.Point(772, 429);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 38);
            this.button1.TabIndex = 22;
            this.toolTip1.SetToolTip(this.button1, "Làm mới");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LopSHDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(819, 576);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LopSHDT";
            this.Text = "LopSHDT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel3;
    }
}