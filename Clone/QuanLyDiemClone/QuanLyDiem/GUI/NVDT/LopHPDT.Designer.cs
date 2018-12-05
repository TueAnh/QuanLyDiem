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
            this.panel1.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMaHP);
            this.panel1.Controls.Add(this.textBoxLDT);
            this.panel1.Controls.Add(this.panelButton);
            this.panel1.Controls.Add(this.textBoxGVPT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.dataGridViewDSHV);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 417);
            this.panel1.TabIndex = 0;
            // 
            // labelMaHP
            // 
            this.labelMaHP.AutoSize = true;
            this.labelMaHP.Location = new System.Drawing.Point(16, 46);
            this.labelMaHP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaHP.Name = "labelMaHP";
            this.labelMaHP.Size = new System.Drawing.Size(73, 13);
            this.labelMaHP.TabIndex = 29;
            this.labelMaHP.Text = "Mã học phần:";
            // 
            // textBoxLDT
            // 
            this.textBoxLDT.Location = new System.Drawing.Point(110, 46);
            this.textBoxLDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLDT.Name = "textBoxLDT";
            this.textBoxLDT.ReadOnly = true;
            this.textBoxLDT.Size = new System.Drawing.Size(192, 20);
            this.textBoxLDT.TabIndex = 28;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonXem);
            this.panelButton.Controls.Add(this.buttonBack);
            this.panelButton.Controls.Add(this.buttonOut);
            this.panelButton.Controls.Add(this.buttonInput);
            this.panelButton.Location = new System.Drawing.Point(8, 368);
            this.panelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(614, 46);
            this.panelButton.TabIndex = 27;
            // 
            // buttonXem
            // 
            this.buttonXem.Location = new System.Drawing.Point(349, 12);
            this.buttonXem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(116, 19);
            this.buttonXem.TabIndex = 0;
            this.buttonXem.Text = "Xem học viên";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(470, 12);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(116, 19);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Trở lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(132, 12);
            this.buttonOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(116, 19);
            this.buttonOut.TabIndex = 0;
            this.buttonOut.Text = "Xuất ra Excel";
            this.buttonOut.UseVisualStyleBackColor = true;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(11, 12);
            this.buttonInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(116, 19);
            this.buttonInput.TabIndex = 0;
            this.buttonInput.Text = "Nhập từ Excel";
            this.buttonInput.UseVisualStyleBackColor = true;
            // 
            // textBoxGVPT
            // 
            this.textBoxGVPT.Location = new System.Drawing.Point(110, 22);
            this.textBoxGVPT.Name = "textBoxGVPT";
            this.textBoxGVPT.ReadOnly = true;
            this.textBoxGVPT.Size = new System.Drawing.Size(192, 20);
            this.textBoxGVPT.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "GV phụ trách : ";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(362, 22);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(168, 20);
            this.textBoxSearch.TabIndex = 23;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(536, 20);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
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
            this.dataGridViewDSHV.Location = new System.Drawing.Point(7, 84);
            this.dataGridViewDSHV.Name = "dataGridViewDSHV";
            this.dataGridViewDSHV.ReadOnly = true;
            this.dataGridViewDSHV.RowHeadersVisible = false;
            this.dataGridViewDSHV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDSHV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDSHV.Size = new System.Drawing.Size(614, 278);
            this.dataGridViewDSHV.TabIndex = 19;
            this.dataGridViewDSHV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSHV_CellDoubleClick);
            this.dataGridViewDSHV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewDSHV_RowPostPaint);
            // 
            // LopHPDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(632, 422);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}