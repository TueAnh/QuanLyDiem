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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMaHP = new System.Windows.Forms.Label();
            this.labelMaHV = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.MaHP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxSuaDiemThi = new System.Windows.Forms.TextBox();
            this.textboxSuaDiemGK = new System.Windows.Forms.TextBox();
            this.textboxSuaDiemBT = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelMaHP);
            this.panel1.Controls.Add(this.labelMaHV);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.MaHP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 249);
            this.panel1.TabIndex = 0;
            // 
            // labelMaHP
            // 
            this.labelMaHP.AutoSize = true;
            this.labelMaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMaHP.Location = new System.Drawing.Point(632, 45);
            this.labelMaHP.Name = "labelMaHP";
            this.labelMaHP.Size = new System.Drawing.Size(67, 25);
            this.labelMaHP.TabIndex = 24;
            this.labelMaHP.Text = "MaHP";
            // 
            // labelMaHV
            // 
            this.labelMaHV.AutoSize = true;
            this.labelMaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMaHV.Location = new System.Drawing.Point(233, 45);
            this.labelMaHV.Name = "labelMaHV";
            this.labelMaHV.Size = new System.Drawing.Size(68, 25);
            this.labelMaHV.TabIndex = 24;
            this.labelMaHV.Text = "MaHV";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(650, 201);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(93, 28);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "Trở lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(163, 201);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 28);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // MaHP
            // 
            this.MaHP.AutoSize = true;
            this.MaHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaHP.Location = new System.Drawing.Point(485, 45);
            this.MaHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaHP.Name = "MaHP";
            this.MaHP.Size = new System.Drawing.Size(137, 25);
            this.MaHP.TabIndex = 20;
            this.MaHP.Text = "Mã Học Phần:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(81, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mã Học Viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Điểm Thi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Điểm GK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Điểm BT";
            // 
            // textboxSuaDiemThi
            // 
            this.textboxSuaDiemThi.Location = new System.Drawing.Point(729, 23);
            this.textboxSuaDiemThi.Margin = new System.Windows.Forms.Padding(4);
            this.textboxSuaDiemThi.Name = "textboxSuaDiemThi";
            this.textboxSuaDiemThi.Size = new System.Drawing.Size(93, 22);
            this.textboxSuaDiemThi.TabIndex = 14;
            // 
            // textboxSuaDiemGK
            // 
            this.textboxSuaDiemGK.Location = new System.Drawing.Point(399, 23);
            this.textboxSuaDiemGK.Margin = new System.Windows.Forms.Padding(4);
            this.textboxSuaDiemGK.Name = "textboxSuaDiemGK";
            this.textboxSuaDiemGK.Size = new System.Drawing.Size(99, 22);
            this.textboxSuaDiemGK.TabIndex = 15;
            // 
            // textboxSuaDiemBT
            // 
            this.textboxSuaDiemBT.Location = new System.Drawing.Point(109, 23);
            this.textboxSuaDiemBT.Margin = new System.Windows.Forms.Padding(4);
            this.textboxSuaDiemBT.Name = "textboxSuaDiemBT";
            this.textboxSuaDiemBT.Size = new System.Drawing.Size(79, 22);
            this.textboxSuaDiemBT.TabIndex = 13;
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
            this.panel2.Location = new System.Drawing.Point(3, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 73);
            this.panel2.TabIndex = 25;
            // 
            // SuaDiemHocVienDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 257);
            this.Controls.Add(this.panel1);
            this.Name = "SuaDiemHocVienDT";
            this.Text = "SuaDiemHocVienDT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label labelMaHP;
        private System.Windows.Forms.Label labelMaHV;
        private System.Windows.Forms.Panel panel2;
    }
}