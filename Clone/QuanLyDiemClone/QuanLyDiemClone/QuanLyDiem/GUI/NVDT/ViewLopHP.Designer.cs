namespace QuanLyDiem.GUI.NVDT
{
    partial class ViewLopHP
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
			this.panelButton = new System.Windows.Forms.Panel();
			this.buttonView = new System.Windows.Forms.Button();
			this.panelData = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panelTree = new System.Windows.Forms.Panel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.panel1.SuspendLayout();
			this.panelButton.SuspendLayout();
			this.panelData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panelTree.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panelButton);
			this.panel1.Controls.Add(this.panelData);
			this.panel1.Controls.Add(this.panelTree);
			this.panel1.Location = new System.Drawing.Point(16, 18);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(838, 574);
			this.panel1.TabIndex = 2;
			// 
			// panelButton
			// 
			this.panelButton.Controls.Add(this.buttonView);
			this.panelButton.Location = new System.Drawing.Point(191, 501);
			this.panelButton.Margin = new System.Windows.Forms.Padding(2);
			this.panelButton.Name = "panelButton";
			this.panelButton.Size = new System.Drawing.Size(643, 59);
			this.panelButton.TabIndex = 2;
			// 
			// buttonView
			// 
			this.buttonView.Location = new System.Drawing.Point(539, 22);
			this.buttonView.Margin = new System.Windows.Forms.Padding(2);
			this.buttonView.Name = "buttonView";
			this.buttonView.Size = new System.Drawing.Size(56, 19);
			this.buttonView.TabIndex = 0;
			this.buttonView.Text = "Xem";
			this.buttonView.UseVisualStyleBackColor = true;
			this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
			// 
			// panelData
			// 
			this.panelData.Controls.Add(this.dataGridView1);
			this.panelData.Location = new System.Drawing.Point(191, 72);
			this.panelData.Margin = new System.Windows.Forms.Padding(2);
			this.panelData.Name = "panelData";
			this.panelData.Size = new System.Drawing.Size(645, 413);
			this.panelData.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(0, 2);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(643, 408);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
			// 
			// panelTree
			// 
			this.panelTree.Controls.Add(this.treeView1);
			this.panelTree.Location = new System.Drawing.Point(2, 2);
			this.panelTree.Margin = new System.Windows.Forms.Padding(2);
			this.panelTree.Name = "panelTree";
			this.panelTree.Size = new System.Drawing.Size(184, 570);
			this.panelTree.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(2, 43);
			this.treeView1.Margin = new System.Windows.Forms.Padding(2);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(181, 525);
			this.treeView1.TabIndex = 0;
			this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
			// 
			// ViewLopHP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(890, 596);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ViewLopHP";
			this.Text = "ViewLopHP";
			this.panel1.ResumeLayout(false);
			this.panelButton.ResumeLayout(false);
			this.panelData.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panelTree.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelTree;
        private System.Windows.Forms.TreeView treeView1;
    }
}