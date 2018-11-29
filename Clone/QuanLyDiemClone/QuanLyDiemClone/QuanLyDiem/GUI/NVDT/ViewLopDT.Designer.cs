namespace QuanLyDiem.GUI.NVDT
{
	partial class ViewLopDT
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.panelData = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panelTree = new System.Windows.Forms.Panel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.panel1.SuspendLayout();
			this.panelData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panelTree.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.buttonSearch);
			this.panel1.Controls.Add(this.buttonBack);
			this.panel1.Controls.Add(this.panelData);
			this.panel1.Controls.Add(this.panelTree);
			this.panel1.Location = new System.Drawing.Point(0, 3);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(838, 470);
			this.panel1.TabIndex = 3;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(535, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(187, 20);
			this.textBox1.TabIndex = 2;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(728, 3);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(104, 23);
			this.buttonSearch.TabIndex = 1;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(190, 3);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(104, 23);
			this.buttonBack.TabIndex = 1;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// panelData
			// 
			this.panelData.Controls.Add(this.dataGridView1);
			this.panelData.Location = new System.Drawing.Point(190, 31);
			this.panelData.Margin = new System.Windows.Forms.Padding(2);
			this.panelData.Name = "panelData";
			this.panelData.Size = new System.Drawing.Size(645, 429);
			this.panelData.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(643, 427);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
			// 
			// panelTree
			// 
			this.panelTree.Controls.Add(this.treeView1);
			this.panelTree.Location = new System.Drawing.Point(1, 31);
			this.panelTree.Margin = new System.Windows.Forms.Padding(2);
			this.panelTree.Name = "panelTree";
			this.panelTree.Size = new System.Drawing.Size(184, 429);
			this.panelTree.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(3, 2);
			this.treeView1.Margin = new System.Windows.Forms.Padding(2);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(181, 425);
			this.treeView1.TabIndex = 0;
			this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
			// 
			// ViewLopDT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 471);
			this.Controls.Add(this.panel1);
			this.Name = "ViewLopDT";
			this.Text = "ViewLopDT";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelData.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panelTree.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panelData;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panelTree;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonSearch;
	}
}