namespace QuanLyDiem.GUI.NVDT
{
    partial class SuaDiemHocVienDT
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
            this.textBoxMaHP = new System.Windows.Forms.TextBox();
            this.textBoxMaHV = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxSuaDiemBT = new System.Windows.Forms.TextBox();
            this.textboxSuaDiemGK = new System.Windows.Forms.TextBox();
            this.textboxSuaDiemThi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.MaHP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProviderSuaDiem = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSuaDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxMaHP);
            this.panel1.Controls.Add(this.textBoxMaHV);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.MaHP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 145);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 203);
            this.panel1.TabIndex = 0;
            // 
            // textBoxMaHP
            // 
            this.textBoxMaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxMaHP.Location = new System.Drawing.Point(149, 45);
            this.textBoxMaHP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaHP.Name = "textBoxMaHP";
            this.textBoxMaHP.ReadOnly = true;
            this.textBoxMaHP.Size = new System.Drawing.Size(254, 23);
            this.textBoxMaHP.TabIndex = 26;
            // 
            // textBoxMaHV
            // 
            this.textBoxMaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxMaHV.Location = new System.Drawing.Point(149, 15);
            this.textBoxMaHV.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaHV.Name = "textBoxMaHV";
            this.textBoxMaHV.ReadOnly = true;
            this.textBoxMaHV.Size = new System.Drawing.Size(254, 23);
            this.textBoxMaHV.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textboxSuaDiemBT);
            this.panel2.Controls.Add(this.textboxSuaDiemGK);
            this.panel2.Controls.Add(this.textboxSuaDiemThi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 60);
            this.panel2.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Điểm Thi";
            // 
            // textboxSuaDiemBT
            // 
            this.textboxSuaDiemBT.Location = new System.Drawing.Point(68, 19);
            this.textboxSuaDiemBT.Name = "textboxSuaDiemBT";
            this.textboxSuaDiemBT.ReadOnly = true;
            this.textboxSuaDiemBT.Size = new System.Drawing.Size(60, 20);
            this.textboxSuaDiemBT.TabIndex = 13;
            this.textboxSuaDiemBT.Validating += new System.ComponentModel.CancelEventHandler(this.textboxSuaDiemBT_Validating);
            this.textboxSuaDiemBT.Validated += new System.EventHandler(this.textboxSuaDiemBT_Validated);
            // 
            // textboxSuaDiemGK
            // 
            this.textboxSuaDiemGK.Location = new System.Drawing.Point(286, 19);
            this.textboxSuaDiemGK.Name = "textboxSuaDiemGK";
            this.textboxSuaDiemGK.ReadOnly = true;
            this.textboxSuaDiemGK.Size = new System.Drawing.Size(75, 20);
            this.textboxSuaDiemGK.TabIndex = 15;
            this.textboxSuaDiemGK.Validating += new System.ComponentModel.CancelEventHandler(this.textboxSuaDiemGK_Validating);
            this.textboxSuaDiemGK.Validated += new System.EventHandler(this.textboxSuaDiemGK_Validated);
            // 
            // textboxSuaDiemThi
            // 
            this.textboxSuaDiemThi.Location = new System.Drawing.Point(533, 19);
            this.textboxSuaDiemThi.Name = "textboxSuaDiemThi";
            this.textboxSuaDiemThi.ReadOnly = true;
            this.textboxSuaDiemThi.Size = new System.Drawing.Size(71, 20);
            this.textboxSuaDiemThi.TabIndex = 14;
            this.textboxSuaDiemThi.Validating += new System.ComponentModel.CancelEventHandler(this.textboxSuaDiemThi_Validating);
            this.textboxSuaDiemThi.Validated += new System.EventHandler(this.textboxSuaDiemThi_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Điểm BT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Điểm GK";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.Image = global::QuanLyDiem.Properties.Resources.arrow_return_right_up_icon__1_;
            this.buttonBack.Location = new System.Drawing.Point(492, 156);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(70, 34);
            this.buttonBack.TabIndex = 22;
            this.toolTip1.SetToolTip(this.buttonBack, "Trở lại");
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.Enabled = false;
            this.buttonSave.Image = global::QuanLyDiem.Properties.Resources.Save_icon;
            this.buttonSave.Location = new System.Drawing.Point(122, 156);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(70, 34);
            this.buttonSave.TabIndex = 23;
            this.toolTip1.SetToolTip(this.buttonSave, "Lưu");
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // MaHP
            // 
            this.MaHP.AutoSize = true;
            this.MaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaHP.Location = new System.Drawing.Point(41, 46);
            this.MaHP.Name = "MaHP";
            this.MaHP.Size = new System.Drawing.Size(105, 20);
            this.MaHP.TabIndex = 20;
            this.MaHP.Text = "Mã Học Phần";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(46, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mã Học Viên";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(2, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(637, 73);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(214, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thông tin chi tiết";
            // 
            // errorProviderSuaDiem
            // 
            this.errorProviderSuaDiem.ContainerControl = this;
            // 
            // SuaDiemHocVienDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 404);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SuaDiemHocVienDT";
            this.Text = "Xem điểm chi tiết";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSuaDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label MaHP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxSuaDiemThi;
        private System.Windows.Forms.TextBox textboxSuaDiemGK;
        private System.Windows.Forms.TextBox textboxSuaDiemBT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxMaHP;
        private System.Windows.Forms.TextBox textBoxMaHV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProviderSuaDiem;
    }
}