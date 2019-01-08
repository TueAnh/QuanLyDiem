namespace QuanLyDiem.GUI.NVDT
{
    partial class AddSVtoLHP
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxSearchMaHV_HoTen = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAddHV = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonSearchMaHV_HoTen = new System.Windows.Forms.Button();
            this.buttonReLoad = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonReLoad);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.buttonAddHV);
            this.panel3.Controls.Add(this.buttonBack);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.buttonSort);
            this.panel3.Controls.Add(this.buttonSearchMaHV_HoTen);
            this.panel3.Controls.Add(this.textBoxSearchMaHV_HoTen);
            this.panel3.Controls.Add(this.dataGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(854, 585);
            this.panel3.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Theo Mã",
            "Theo Tên",
            "Theo Lớp",
            "Theo Khoa"});
            this.comboBox1.Location = new System.Drawing.Point(21, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 28);
            this.comboBox1.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(843, 70);
            this.panel4.TabIndex = 20;
            // 
            // textBoxSearchMaHV_HoTen
            // 
            this.textBoxSearchMaHV_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxSearchMaHV_HoTen.Location = new System.Drawing.Point(367, 103);
            this.textBoxSearchMaHV_HoTen.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchMaHV_HoTen.Name = "textBoxSearchMaHV_HoTen";
            this.textBoxSearchMaHV_HoTen.Size = new System.Drawing.Size(316, 26);
            this.textBoxSearchMaHV_HoTen.TabIndex = 16;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(21, 174);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(805, 327);
            this.dataGridView.TabIndex = 15;
            this.dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // buttonAddHV
            // 
            this.buttonAddHV.BackColor = System.Drawing.Color.White;
            this.buttonAddHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAddHV.Image = global::QuanLyDiem.Properties.Resources.user_add_icon;
            this.buttonAddHV.Location = new System.Drawing.Point(619, 511);
            this.buttonAddHV.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddHV.Name = "buttonAddHV";
            this.buttonAddHV.Size = new System.Drawing.Size(100, 57);
            this.buttonAddHV.TabIndex = 22;
            this.buttonAddHV.UseVisualStyleBackColor = false;
            this.buttonAddHV.Click += new System.EventHandler(this.buttonAddHV_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBack.Image = global::QuanLyDiem.Properties.Resources.arrow_return_down_left_icon;
            this.buttonBack.Location = new System.Drawing.Point(726, 511);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 57);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.White;
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSort.Image = global::QuanLyDiem.Properties.Resources.data_sort_icon;
            this.buttonSort.Location = new System.Drawing.Point(215, 116);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(55, 50);
            this.buttonSort.TabIndex = 19;
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click_1);
            // 
            // buttonSearchMaHV_HoTen
            // 
            this.buttonSearchMaHV_HoTen.BackColor = System.Drawing.Color.White;
            this.buttonSearchMaHV_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSearchMaHV_HoTen.Image = global::QuanLyDiem.Properties.Resources.search_button_icon;
            this.buttonSearchMaHV_HoTen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearchMaHV_HoTen.Location = new System.Drawing.Point(706, 97);
            this.buttonSearchMaHV_HoTen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchMaHV_HoTen.Name = "buttonSearchMaHV_HoTen";
            this.buttonSearchMaHV_HoTen.Size = new System.Drawing.Size(139, 38);
            this.buttonSearchMaHV_HoTen.TabIndex = 17;
            this.buttonSearchMaHV_HoTen.Text = "Tìm kiếm";
            this.buttonSearchMaHV_HoTen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearchMaHV_HoTen.UseVisualStyleBackColor = false;
            this.buttonSearchMaHV_HoTen.Click += new System.EventHandler(this.buttonSearchMaHV_HoTen_Click);
            // 
            // buttonReLoad
            // 
            this.buttonReLoad.BackColor = System.Drawing.Color.White;
            this.buttonReLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonReLoad.Image = global::QuanLyDiem.Properties.Resources.Actions_view_refresh_icon__1_;
            this.buttonReLoad.Location = new System.Drawing.Point(21, 509);
            this.buttonReLoad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReLoad.Name = "buttonReLoad";
            this.buttonReLoad.Size = new System.Drawing.Size(100, 57);
            this.buttonReLoad.TabIndex = 25;
            this.buttonReLoad.UseVisualStyleBackColor = false;
            this.buttonReLoad.Click += new System.EventHandler(this.buttonReLoad_Click);
            // 
            // AddSVtoLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 585);
            this.Controls.Add(this.panel3);
            this.Name = "AddSVtoLHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sinh viên";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAddHV;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonSearchMaHV_HoTen;
        private System.Windows.Forms.TextBox textBoxSearchMaHV_HoTen;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonReLoad;
    }
}