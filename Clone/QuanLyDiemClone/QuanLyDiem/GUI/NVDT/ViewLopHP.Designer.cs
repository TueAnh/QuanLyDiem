namespace QuanLyDiem.GUI.NVDT
{
    partial class ViewLopHP
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonThemLopHP = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThemHPExcel = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolTipAdd = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "Thêm học phần";
            this.panel1.Controls.Add(this.labelPath);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 504);
            this.panel1.TabIndex = 2;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(156, 490);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(29, 13);
            this.labelPath.TabIndex = 22;
            this.labelPath.Text = "Path";
            this.labelPath.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonThemLopHP);
            this.panel3.Controls.Add(this.buttonXoa);
            this.panel3.Controls.Add(this.buttonThemHPExcel);
            this.panel3.Controls.Add(this.buttonBack);
            this.panel3.Controls.Add(this.buttonSave);
            this.panel3.Location = new System.Drawing.Point(154, 445);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 50);
            this.panel3.TabIndex = 23;
            // 
            // buttonThemLopHP
            // 
            this.buttonThemLopHP.BackColor = System.Drawing.Color.White;
            this.buttonThemLopHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonThemLopHP.Image = global::QuanLyDiem.Properties.Resources.Add_icon1;
            this.buttonThemLopHP.Location = new System.Drawing.Point(519, 5);
            this.buttonThemLopHP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonThemLopHP.Name = "buttonThemLopHP";
            this.buttonThemLopHP.Size = new System.Drawing.Size(38, 38);
            this.buttonThemLopHP.TabIndex = 3;
            this.toolTipAdd.SetToolTip(this.buttonThemLopHP, "Thêm lớp học phần");
            this.buttonThemLopHP.UseVisualStyleBackColor = false;
            this.buttonThemLopHP.Click += new System.EventHandler(this.buttonThemLopHP_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.AccessibleDescription = "Xóa Học Phần";
            this.buttonXoa.BackColor = System.Drawing.Color.White;
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonXoa.Image = global::QuanLyDiem.Properties.Resources.Delete_icon;
            this.buttonXoa.Location = new System.Drawing.Point(561, 5);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(38, 38);
            this.buttonXoa.TabIndex = 3;
            this.toolTipAdd.SetToolTip(this.buttonXoa, "Xóa lớp học phần");
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThemHPExcel
            // 
            this.buttonThemHPExcel.BackColor = System.Drawing.Color.White;
            this.buttonThemHPExcel.Image = global::QuanLyDiem.Properties.Resources.excel_icon;
            this.buttonThemHPExcel.Location = new System.Drawing.Point(3, 5);
            this.buttonThemHPExcel.Name = "buttonThemHPExcel";
            this.buttonThemHPExcel.Size = new System.Drawing.Size(38, 38);
            this.buttonThemHPExcel.TabIndex = 21;
            this.buttonThemHPExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipAdd.SetToolTip(this.buttonThemHPExcel, "Thêm lớp học phần từ Excel");
            this.buttonThemHPExcel.UseVisualStyleBackColor = false;
            this.buttonThemHPExcel.Click += new System.EventHandler(this.buttonThemHPExcel_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.AccessibleDescription = "Trở lại";
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBack.Image = global::QuanLyDiem.Properties.Resources.arrow_return_down_left_icon;
            this.buttonBack.Location = new System.Drawing.Point(603, 5);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(38, 38);
            this.buttonBack.TabIndex = 3;
            this.toolTipAdd.SetToolTip(this.buttonBack, "Thoát chức năng");
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.Image = global::QuanLyDiem.Properties.Resources.Save__1_;
            this.buttonSave.Location = new System.Drawing.Point(46, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(38, 38);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipAdd.SetToolTip(this.buttonSave, "Lưu thay đổi");
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMargin = new System.Drawing.Size(5, 0);
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(153, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 412);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(650, 410);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(10, 30);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(140, 412);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // ViewLopHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(806, 504);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewLopHP";
            this.Text = "ViewLopHP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonThemLopHP;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonThemHPExcel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTipAdd;
    }
}