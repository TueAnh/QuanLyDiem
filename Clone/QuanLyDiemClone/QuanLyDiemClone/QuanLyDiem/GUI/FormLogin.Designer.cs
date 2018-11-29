namespace QuanLyDiem
{
    partial class FormLogin
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelNoti = new System.Windows.Forms.Label();
			this.labelTitle = new System.Windows.Forms.Label();
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.labelLogin = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.labelPass = new System.Windows.Forms.Label();
			this.labelID = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.labelNoti);
			this.panel2.Controls.Add(this.labelTitle);
			this.panel2.Controls.Add(this.textBoxPass);
			this.panel2.Controls.Add(this.textBoxID);
			this.panel2.Controls.Add(this.labelLogin);
			this.panel2.Controls.Add(this.buttonCancel);
			this.panel2.Controls.Add(this.buttonOK);
			this.panel2.Controls.Add(this.labelPass);
			this.panel2.Controls.Add(this.labelID);
			this.panel2.Location = new System.Drawing.Point(9, 10);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(662, 479);
			this.panel2.TabIndex = 4;
			// 
			// labelNoti
			// 
			this.labelNoti.AutoSize = true;
			this.labelNoti.Location = new System.Drawing.Point(275, 265);
			this.labelNoti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelNoti.Name = "labelNoti";
			this.labelNoti.Size = new System.Drawing.Size(129, 13);
			this.labelNoti.TabIndex = 7;
			this.labelNoti.Text = "Notification                       ";
			this.labelNoti.Visible = false;
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelTitle.Location = new System.Drawing.Point(187, 15);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(313, 20);
			this.labelTitle.TabIndex = 6;
			this.labelTitle.Text = "Phần mềm quản lí điểm Đại học Bách Khoa";
			// 
			// textBoxPass
			// 
			this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBoxPass.Location = new System.Drawing.Point(256, 202);
			this.textBoxPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.Size = new System.Drawing.Size(254, 38);
			this.textBoxPass.TabIndex = 5;
			// 
			// textBoxID
			// 
			this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBoxID.Location = new System.Drawing.Point(256, 136);
			this.textBoxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Size = new System.Drawing.Size(254, 38);
			this.textBoxID.TabIndex = 5;
			// 
			// labelLogin
			// 
			this.labelLogin.AutoSize = true;
			this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelLogin.Location = new System.Drawing.Point(250, 65);
			this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(151, 31);
			this.labelLogin.TabIndex = 4;
			this.labelLogin.Text = "Đăng Nhập";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(392, 311);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(94, 37);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(181, 311);
			this.buttonOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(94, 37);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// labelPass
			// 
			this.labelPass.AutoSize = true;
			this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelPass.Location = new System.Drawing.Point(148, 210);
			this.labelPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPass.Name = "labelPass";
			this.labelPass.Size = new System.Drawing.Size(98, 25);
			this.labelPass.TabIndex = 1;
			this.labelPass.Text = "Password";
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelID.Location = new System.Drawing.Point(148, 144);
			this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(31, 25);
			this.labelID.TabIndex = 1;
			this.labelID.Text = "ID";
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 500);
			this.Controls.Add(this.panel2);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FormLogin";
			this.Text = "Login";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNoti;
    }
}

