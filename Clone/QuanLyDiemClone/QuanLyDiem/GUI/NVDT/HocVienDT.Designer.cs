namespace QuanLyDiem.GUI.NVDT
{
    partial class HocVienDT
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
            this.buttonMore = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonHocKi = new System.Windows.Forms.RadioButton();
            this.radioButtonQuaTrinh = new System.Windows.Forms.RadioButton();
            this.radioButtonNamHoc = new System.Windows.Forms.RadioButton();
            this.textBoxNAME = new System.Windows.Forms.TextBox();
            this.textBoxMSHV = new System.Windows.Forms.TextBox();
            this.buttonXem = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxDoanXem = new System.Windows.Forms.ComboBox();
            this.dataGridViewDTBvXL = new System.Windows.Forms.DataGridView();
            this.dataGridViewXemDiem = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDTBvXL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScrollMargin = new System.Drawing.Size(5, 0);
            this.panel1.Controls.Add(this.buttonMore);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxNAME);
            this.panel1.Controls.Add(this.textBoxMSHV);
            this.panel1.Controls.Add(this.buttonXem);
            this.panel1.Controls.Add(this.buttonOut);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.comboBoxDoanXem);
            this.panel1.Controls.Add(this.dataGridViewDTBvXL);
            this.panel1.Controls.Add(this.dataGridViewXemDiem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 574);
            this.panel1.TabIndex = 1;
            // 
            // buttonMore
            // 
            this.buttonMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonMore.Location = new System.Drawing.Point(514, 50);
            this.buttonMore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(200, 28);
            this.buttonMore.TabIndex = 98;
            this.buttonMore.Text = "Thông tin thêm >>>>";
            this.buttonMore.UseVisualStyleBackColor = true;
            this.buttonMore.Click += new System.EventHandler(this.buttonMore_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonHocKi);
            this.panel2.Controls.Add(this.radioButtonQuaTrinh);
            this.panel2.Controls.Add(this.radioButtonNamHoc);
            this.panel2.Location = new System.Drawing.Point(18, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 39);
            this.panel2.TabIndex = 97;
            // 
            // radioButtonHocKi
            // 
            this.radioButtonHocKi.AutoSize = true;
            this.radioButtonHocKi.Location = new System.Drawing.Point(4, 14);
            this.radioButtonHocKi.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonHocKi.Name = "radioButtonHocKi";
            this.radioButtonHocKi.Size = new System.Drawing.Size(70, 21);
            this.radioButtonHocKi.TabIndex = 87;
            this.radioButtonHocKi.TabStop = true;
            this.radioButtonHocKi.Text = "Học Kì";
            this.radioButtonHocKi.UseVisualStyleBackColor = true;
            this.radioButtonHocKi.CheckedChanged += new System.EventHandler(this.radioButtonHocKi_CheckedChanged);
            // 
            // radioButtonQuaTrinh
            // 
            this.radioButtonQuaTrinh.AutoSize = true;
            this.radioButtonQuaTrinh.Location = new System.Drawing.Point(229, 14);
            this.radioButtonQuaTrinh.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonQuaTrinh.Name = "radioButtonQuaTrinh";
            this.radioButtonQuaTrinh.Size = new System.Drawing.Size(93, 21);
            this.radioButtonQuaTrinh.TabIndex = 89;
            this.radioButtonQuaTrinh.TabStop = true;
            this.radioButtonQuaTrinh.Text = "Quá Trình";
            this.radioButtonQuaTrinh.UseVisualStyleBackColor = true;
            this.radioButtonQuaTrinh.CheckedChanged += new System.EventHandler(this.radioButtonQuaTrinh_CheckedChanged);
            // 
            // radioButtonNamHoc
            // 
            this.radioButtonNamHoc.AutoSize = true;
            this.radioButtonNamHoc.Location = new System.Drawing.Point(100, 14);
            this.radioButtonNamHoc.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonNamHoc.Name = "radioButtonNamHoc";
            this.radioButtonNamHoc.Size = new System.Drawing.Size(87, 21);
            this.radioButtonNamHoc.TabIndex = 88;
            this.radioButtonNamHoc.TabStop = true;
            this.radioButtonNamHoc.Text = "Năm Học";
            this.radioButtonNamHoc.UseVisualStyleBackColor = true;
            this.radioButtonNamHoc.CheckedChanged += new System.EventHandler(this.radioButtonNamHoc_CheckedChanged);
            // 
            // textBoxNAME
            // 
            this.textBoxNAME.Location = new System.Drawing.Point(108, 50);
            this.textBoxNAME.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNAME.Name = "textBoxNAME";
            this.textBoxNAME.ReadOnly = true;
            this.textBoxNAME.Size = new System.Drawing.Size(379, 22);
            this.textBoxNAME.TabIndex = 95;
            // 
            // textBoxMSHV
            // 
            this.textBoxMSHV.Location = new System.Drawing.Point(108, 14);
            this.textBoxMSHV.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMSHV.Name = "textBoxMSHV";
            this.textBoxMSHV.ReadOnly = true;
            this.textBoxMSHV.Size = new System.Drawing.Size(379, 22);
            this.textBoxMSHV.TabIndex = 96;
            // 
            // buttonXem
            // 
            this.buttonXem.Location = new System.Drawing.Point(690, 249);
            this.buttonXem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(100, 28);
            this.buttonXem.TabIndex = 92;
            this.buttonXem.Text = "Xem";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(524, 534);
            this.buttonOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(116, 28);
            this.buttonOut.TabIndex = 93;
            this.buttonOut.Text = "Xuât ra Excel";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(690, 532);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 28);
            this.buttonBack.TabIndex = 94;
            this.buttonBack.Text = "Trở lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxDoanXem
            // 
            this.comboBoxDoanXem.FormattingEnabled = true;
            this.comboBoxDoanXem.Location = new System.Drawing.Point(385, 251);
            this.comboBoxDoanXem.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDoanXem.Name = "comboBoxDoanXem";
            this.comboBoxDoanXem.Size = new System.Drawing.Size(255, 24);
            this.comboBoxDoanXem.TabIndex = 90;
            // 
            // dataGridViewDTBvXL
            // 
            this.dataGridViewDTBvXL.AllowUserToAddRows = false;
            this.dataGridViewDTBvXL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDTBvXL.Location = new System.Drawing.Point(4, 80);
            this.dataGridViewDTBvXL.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewDTBvXL.Name = "dataGridViewDTBvXL";
            this.dataGridViewDTBvXL.ReadOnly = true;
            this.dataGridViewDTBvXL.RowHeadersVisible = false;
            this.dataGridViewDTBvXL.Size = new System.Drawing.Size(808, 152);
            this.dataGridViewDTBvXL.TabIndex = 85;
            this.dataGridViewDTBvXL.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewDTBvXL_RowPostPaint);
            // 
            // dataGridViewXemDiem
            // 
            this.dataGridViewXemDiem.AllowUserToAddRows = false;
            this.dataGridViewXemDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXemDiem.Location = new System.Drawing.Point(4, 284);
            this.dataGridViewXemDiem.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewXemDiem.Name = "dataGridViewXemDiem";
            this.dataGridViewXemDiem.ReadOnly = true;
            this.dataGridViewXemDiem.RowHeadersVisible = false;
            this.dataGridViewXemDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewXemDiem.Size = new System.Drawing.Size(808, 240);
            this.dataGridViewXemDiem.TabIndex = 86;
            this.dataGridViewXemDiem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewXemDiem_CellDoubleClick);
            this.dataGridViewXemDiem.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewXemDiem_RowPostPaint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 84;
            this.label1.Text = "MSHV";
            // 
            // HocVienDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(5, 0);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(820, 577);
            this.Controls.Add(this.panel1);
            this.Name = "HocVienDT";
            this.Text = "HocVienDT";
            this.Load += new System.EventHandler(this.HocVienDT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDTBvXL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxNAME;
        private System.Windows.Forms.TextBox textBoxMSHV;
        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxDoanXem;
        private System.Windows.Forms.RadioButton radioButtonHocKi;
        private System.Windows.Forms.RadioButton radioButtonNamHoc;
        private System.Windows.Forms.RadioButton radioButtonQuaTrinh;
        private System.Windows.Forms.DataGridView dataGridViewDTBvXL;
        private System.Windows.Forms.DataGridView dataGridViewXemDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonMore;
    }
}