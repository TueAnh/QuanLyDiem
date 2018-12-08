namespace QuanLyDiem.GUI.NVDT
{
    partial class ThemKhoa
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
            this.buttonThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTenKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaKhoa = new System.Windows.Forms.TextBox();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(288, 199);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(100, 28);
            this.buttonThoat.TabIndex = 7;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxTenKhoa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxMaKhoa);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 153);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa";
            // 
            // textBoxTenKhoa
            // 
            this.textBoxTenKhoa.Location = new System.Drawing.Point(112, 89);
            this.textBoxTenKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenKhoa.Name = "textBoxTenKhoa";
            this.textBoxTenKhoa.Size = new System.Drawing.Size(239, 22);
            this.textBoxTenKhoa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khoa";
            // 
            // textBoxMaKhoa
            // 
            this.textBoxMaKhoa.Location = new System.Drawing.Point(112, 31);
            this.textBoxMaKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaKhoa.Name = "textBoxMaKhoa";
            this.textBoxMaKhoa.Size = new System.Drawing.Size(239, 22);
            this.textBoxMaKhoa.TabIndex = 2;
            // 
            // buttonLuu
            // 
            this.buttonLuu.Location = new System.Drawing.Point(149, 199);
            this.buttonLuu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(100, 28);
            this.buttonLuu.TabIndex = 5;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // ThemKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 250);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLuu);
            this.Name = "ThemKhoa";
            this.Text = "ThemKhoa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTenKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaKhoa;
        private System.Windows.Forms.Button buttonLuu;
    }
}