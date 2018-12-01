namespace QuanLyDiem.GUI
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.panelTools1 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonUserInfo = new System.Windows.Forms.Button();
            this.buttonTools = new System.Windows.Forms.Button();
            this.buttonFeedBack = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTools2 = new System.Windows.Forms.Panel();
            this.buttonViewGV = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonViewLSH = new System.Windows.Forms.Button();
            this.buttonViewLHP = new System.Windows.Forms.Button();
            this.buttonViewHV = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTools1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTools2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelTools1);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 628);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(6, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 180);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelUserName);
            this.panel3.Location = new System.Drawing.Point(-1, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 29);
            this.panel3.TabIndex = 3;
            // 
            // labelUserName
            // 
            this.labelUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUserName.Location = new System.Drawing.Point(0, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(200, 29);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Username";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            // 
            // panelTools1
            // 
            this.panelTools1.Controls.Add(this.buttonLogout);
            this.panelTools1.Controls.Add(this.buttonUserInfo);
            this.panelTools1.Controls.Add(this.buttonTools);
            this.panelTools1.Controls.Add(this.buttonFeedBack);
            this.panelTools1.Controls.Add(this.buttonHelp);
            this.panelTools1.Controls.Add(this.buttonAbout);
            this.panelTools1.Controls.Add(this.buttonChangePass);
            this.panelTools1.Location = new System.Drawing.Point(3, 237);
            this.panelTools1.Name = "panelTools1";
            this.panelTools1.Size = new System.Drawing.Size(192, 376);
            this.panelTools1.TabIndex = 2;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(3, 309);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(186, 42);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Đăng Xuất";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonUserInfo
            // 
            this.buttonUserInfo.Location = new System.Drawing.Point(3, 21);
            this.buttonUserInfo.Name = "buttonUserInfo";
            this.buttonUserInfo.Size = new System.Drawing.Size(186, 42);
            this.buttonUserInfo.TabIndex = 0;
            this.buttonUserInfo.Text = "Thông tin người dùng";
            this.buttonUserInfo.UseVisualStyleBackColor = true;
            // 
            // buttonTools
            // 
            this.buttonTools.Location = new System.Drawing.Point(3, 69);
            this.buttonTools.Name = "buttonTools";
            this.buttonTools.Size = new System.Drawing.Size(186, 42);
            this.buttonTools.TabIndex = 1;
            this.buttonTools.Text = "Chức năng";
            this.buttonTools.UseVisualStyleBackColor = true;
            this.buttonTools.Click += new System.EventHandler(this.buttonTools_Click);
            // 
            // buttonFeedBack
            // 
            this.buttonFeedBack.Location = new System.Drawing.Point(3, 261);
            this.buttonFeedBack.Name = "buttonFeedBack";
            this.buttonFeedBack.Size = new System.Drawing.Size(186, 42);
            this.buttonFeedBack.TabIndex = 5;
            this.buttonFeedBack.Text = "Báo lỗi";
            this.buttonFeedBack.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(3, 165);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(186, 42);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Trợ giúp";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(3, 213);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(186, 42);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.Text = "Về tác giả";
            this.buttonAbout.UseVisualStyleBackColor = true;
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.Location = new System.Drawing.Point(3, 117);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(186, 42);
            this.buttonChangePass.TabIndex = 2;
            this.buttonChangePass.Text = "Đổi mật khẩu";
            this.buttonChangePass.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMargin = new System.Drawing.Size(5, 0);
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panelTools2);
            this.panel2.Location = new System.Drawing.Point(218, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 628);
            this.panel2.TabIndex = 4;
            this.panel2.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panel2_ControlAdded);
            // 
            // panelTools2
            // 
            this.panelTools2.BackColor = System.Drawing.Color.Transparent;
            this.panelTools2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTools2.Controls.Add(this.buttonViewGV);
            this.panelTools2.Controls.Add(this.buttonBack);
            this.panelTools2.Controls.Add(this.buttonViewLSH);
            this.panelTools2.Controls.Add(this.buttonViewLHP);
            this.panelTools2.Controls.Add(this.buttonViewHV);
            this.panelTools2.Location = new System.Drawing.Point(597, 66);
            this.panelTools2.Name = "panelTools2";
            this.panelTools2.Size = new System.Drawing.Size(197, 285);
            this.panelTools2.TabIndex = 1;
            // 
            // buttonViewGV
            // 
            this.buttonViewGV.Location = new System.Drawing.Point(3, 73);
            this.buttonViewGV.Name = "buttonViewGV";
            this.buttonViewGV.Size = new System.Drawing.Size(186, 42);
            this.buttonViewGV.TabIndex = 8;
            this.buttonViewGV.Text = "Xem Giảng viên";
            this.buttonViewGV.UseVisualStyleBackColor = true;
            this.buttonViewGV.Click += new System.EventHandler(this.buttonViewGV_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(3, 217);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(186, 42);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Trở lại";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonViewLSH
            // 
            this.buttonViewLSH.Location = new System.Drawing.Point(3, 169);
            this.buttonViewLSH.Name = "buttonViewLSH";
            this.buttonViewLSH.Size = new System.Drawing.Size(186, 42);
            this.buttonViewLSH.TabIndex = 10;
            this.buttonViewLSH.Text = "Xem Lớp Đào Tạo";
            this.buttonViewLSH.UseVisualStyleBackColor = true;
            this.buttonViewLSH.Click += new System.EventHandler(this.buttonViewLSH_Click);
            // 
            // buttonViewLHP
            // 
            this.buttonViewLHP.Location = new System.Drawing.Point(3, 121);
            this.buttonViewLHP.Name = "buttonViewLHP";
            this.buttonViewLHP.Size = new System.Drawing.Size(186, 42);
            this.buttonViewLHP.TabIndex = 9;
            this.buttonViewLHP.Text = "Xem Lớp Học Phần";
            this.buttonViewLHP.UseVisualStyleBackColor = true;
            this.buttonViewLHP.Click += new System.EventHandler(this.buttonViewLHP_Click);
            // 
            // buttonViewHV
            // 
            this.buttonViewHV.Location = new System.Drawing.Point(3, 25);
            this.buttonViewHV.Name = "buttonViewHV";
            this.buttonViewHV.Size = new System.Drawing.Size(186, 42);
            this.buttonViewHV.TabIndex = 7;
            this.buttonViewHV.Text = "Xem Học Viên";
            this.buttonViewHV.UseVisualStyleBackColor = true;
            this.buttonViewHV.Click += new System.EventHandler(this.buttonViewHV_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(16, 680);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(46, 17);
            this.labelHello.TabIndex = 6;
            this.labelHello.Text = "label1";
            this.labelHello.Visible = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyDiem.Properties.Resources.Wiki_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1319, 721);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelTools1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTools2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTools1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonTools;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonChangePass;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonUserInfo;
        private System.Windows.Forms.Button buttonFeedBack;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelTools2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonViewLSH;
        private System.Windows.Forms.Button buttonViewLHP;
        private System.Windows.Forms.Button buttonViewHV;
        private System.Windows.Forms.Button buttonViewGV;
        private System.Windows.Forms.Panel panel4;
    }
}