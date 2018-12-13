namespace QuanLyDiem.GUI.NVDT
{
    partial class ThemHocKy
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLuuMoi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxNamHoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxHocKi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaHK = new System.Windows.Forms.TextBox();
            this.labelMaHP = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(285, 264);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 35);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Thoát";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonLuuMoi
            // 
            this.buttonLuuMoi.Location = new System.Drawing.Point(171, 264);
            this.buttonLuuMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLuuMoi.Name = "buttonLuuMoi";
            this.buttonLuuMoi.Size = new System.Drawing.Size(98, 35);
            this.buttonLuuMoi.TabIndex = 11;
            this.buttonLuuMoi.Text = "Lưu mới";
            this.buttonLuuMoi.UseVisualStyleBackColor = true;
            this.buttonLuuMoi.Click += new System.EventHandler(this.buttonLuuMoi_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxNamHoc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.comboBoxHocKi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxMaHK);
            this.panel2.Controls.Add(this.labelMaHP);
            this.panel2.Location = new System.Drawing.Point(38, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 213);
            this.panel2.TabIndex = 10;
            // 
            // textBoxNamHoc
            // 
            this.textBoxNamHoc.Location = new System.Drawing.Point(134, 179);
            this.textBoxNamHoc.Name = "textBoxNamHoc";
            this.textBoxNamHoc.Size = new System.Drawing.Size(123, 20);
            this.textBoxNamHoc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Năm Học";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(134, 139);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBoxHocKi
            // 
            this.comboBoxHocKi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHocKi.FormattingEnabled = true;
            this.comboBoxHocKi.Location = new System.Drawing.Point(134, 56);
            this.comboBoxHocKi.Name = "comboBoxHocKi";
            this.comboBoxHocKi.Size = new System.Drawing.Size(123, 21);
            this.comboBoxHocKi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời Gian Kết Thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thời Gian Bắt Đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Học Kì";
            // 
            // textBoxMaHK
            // 
            this.textBoxMaHK.Location = new System.Drawing.Point(134, 17);
            this.textBoxMaHK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMaHK.Name = "textBoxMaHK";
            this.textBoxMaHK.Size = new System.Drawing.Size(200, 20);
            this.textBoxMaHK.TabIndex = 1;
            // 
            // labelMaHP
            // 
            this.labelMaHP.AutoSize = true;
            this.labelMaHP.Location = new System.Drawing.Point(24, 20);
            this.labelMaHP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaHP.Name = "labelMaHP";
            this.labelMaHP.Size = new System.Drawing.Size(57, 13);
            this.labelMaHP.TabIndex = 0;
            this.labelMaHP.Text = "Mã Học Kì";
            // 
            // ThemHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 320);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLuuMoi);
            this.Controls.Add(this.panel2);
            this.Name = "ThemHocKy";
            this.Text = "ThemHocKy";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLuuMoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxNamHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxHocKi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaHK;
        private System.Windows.Forms.Label labelMaHP;
    }
}