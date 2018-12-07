namespace QuanLyDiem.GUI.NVDT
{
	partial class SearchGiangVienDT
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.buttonDel = new System.Windows.Forms.Button();
			this.buttonAddGV = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.buttonSort = new System.Windows.Forms.Button();
			this.buttonReLoad = new System.Windows.Forms.Button();
			this.buttonSearchMaGV_HoTen = new System.Windows.Forms.Button();
			this.textBoxSearchMaHV_HoTen = new System.Windows.Forms.TextBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.treeView1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 497);
			this.panel1.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.AutoScrollMargin = new System.Drawing.Size(5, 0);
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Location = new System.Drawing.Point(156, 10);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(639, 475);
			this.panel2.TabIndex = 11;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.comboBox1);
			this.panel3.Controls.Add(this.buttonDel);
			this.panel3.Controls.Add(this.buttonAddGV);
			this.panel3.Controls.Add(this.buttonBack);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.buttonSort);
			this.panel3.Controls.Add(this.buttonReLoad);
			this.panel3.Controls.Add(this.buttonSearchMaGV_HoTen);
			this.panel3.Controls.Add(this.textBoxSearchMaHV_HoTen);
			this.panel3.Controls.Add(this.dataGridView);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(637, 473);
			this.panel3.TabIndex = 0;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Theo Mã",
            "Theo Tên",
            "Theo Lớp"});
			this.comboBox1.Location = new System.Drawing.Point(131, 113);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(141, 21);
			this.comboBox1.TabIndex = 24;
			// 
			// buttonDel
			// 
			this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonDel.Location = new System.Drawing.Point(428, 427);
			this.buttonDel.Margin = new System.Windows.Forms.Padding(2);
			this.buttonDel.Name = "buttonDel";
			this.buttonDel.Size = new System.Drawing.Size(113, 31);
			this.buttonDel.TabIndex = 23;
			this.buttonDel.Text = "Xóa giảng viên";
			this.buttonDel.UseVisualStyleBackColor = true;
			// 
			// buttonAddGV
			// 
			this.buttonAddGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonAddGV.Location = new System.Drawing.Point(279, 427);
			this.buttonAddGV.Name = "buttonAddGV";
			this.buttonAddGV.Size = new System.Drawing.Size(144, 32);
			this.buttonAddGV.TabIndex = 22;
			this.buttonAddGV.Text = "Thêm giảng viên";
			this.buttonAddGV.UseVisualStyleBackColor = true;
			this.buttonAddGV.Click += new System.EventHandler(this.buttonAddGV_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonBack.Location = new System.Drawing.Point(546, 427);
			this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 32);
			this.buttonBack.TabIndex = 21;
			this.buttonBack.Text = "Trở lại";
			this.buttonBack.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Location = new System.Drawing.Point(2, 2);
			this.panel4.Margin = new System.Windows.Forms.Padding(2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(633, 57);
			this.panel4.TabIndex = 20;
			// 
			// buttonSort
			// 
			this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonSort.Location = new System.Drawing.Point(16, 111);
			this.buttonSort.Name = "buttonSort";
			this.buttonSort.Size = new System.Drawing.Size(110, 23);
			this.buttonSort.TabIndex = 19;
			this.buttonSort.Text = "Sort";
			this.buttonSort.UseVisualStyleBackColor = true;
			// 
			// buttonReLoad
			// 
			this.buttonReLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonReLoad.Location = new System.Drawing.Point(546, 111);
			this.buttonReLoad.Name = "buttonReLoad";
			this.buttonReLoad.Size = new System.Drawing.Size(75, 23);
			this.buttonReLoad.TabIndex = 18;
			this.buttonReLoad.Text = "Reload";
			this.buttonReLoad.UseVisualStyleBackColor = true;
			// 
			// buttonSearchMaGV_HoTen
			// 
			this.buttonSearchMaGV_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.buttonSearchMaGV_HoTen.Location = new System.Drawing.Point(546, 79);
			this.buttonSearchMaGV_HoTen.Name = "buttonSearchMaGV_HoTen";
			this.buttonSearchMaGV_HoTen.Size = new System.Drawing.Size(75, 23);
			this.buttonSearchMaGV_HoTen.TabIndex = 17;
			this.buttonSearchMaGV_HoTen.Text = "Search";
			this.buttonSearchMaGV_HoTen.UseVisualStyleBackColor = true;
			// 
			// textBoxSearchMaHV_HoTen
			// 
			this.textBoxSearchMaHV_HoTen.Location = new System.Drawing.Point(303, 82);
			this.textBoxSearchMaHV_HoTen.Name = "textBoxSearchMaHV_HoTen";
			this.textBoxSearchMaHV_HoTen.Size = new System.Drawing.Size(238, 20);
			this.textBoxSearchMaHV_HoTen.TabIndex = 16;
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(16, 141);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(604, 266);
			this.dataGridView.TabIndex = 15;
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(9, 10);
			this.treeView1.Margin = new System.Windows.Forms.Padding(2);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(144, 474);
			this.treeView1.TabIndex = 10;
			// 
			// SearchGiangVienDT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 497);
			this.Controls.Add(this.panel1);
			this.Name = "SearchGiangVienDT";
			this.Text = "SearchGiangVienDT";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button buttonDel;
		private System.Windows.Forms.Button buttonAddGV;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button buttonSort;
		private System.Windows.Forms.Button buttonReLoad;
		private System.Windows.Forms.Button buttonSearchMaGV_HoTen;
		private System.Windows.Forms.TextBox textBoxSearchMaHV_HoTen;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.TreeView treeView1;
	}
}