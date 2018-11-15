namespace QuanLyDiem.GUI.NVDT
{
    partial class LopSHDT
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
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.dataGridViewDSHV = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHV)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBoxSearch);
			this.panel1.Controls.Add(this.buttonSave);
			this.panel1.Controls.Add(this.buttonCancel);
			this.panel1.Controls.Add(this.buttonSearch);
			this.panel1.Controls.Add(this.dataGridViewDSHV);
			this.panel1.Location = new System.Drawing.Point(104, 48);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(718, 491);
			this.panel1.TabIndex = 0;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(375, 51);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(168, 20);
			this.textBoxSearch.TabIndex = 12;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(493, 417);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 9;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(574, 417);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 10;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(549, 51);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 11;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			// 
			// dataGridViewDSHV
			// 
			this.dataGridViewDSHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDSHV.Location = new System.Drawing.Point(70, 92);
			this.dataGridViewDSHV.Name = "dataGridViewDSHV";
			this.dataGridViewDSHV.Size = new System.Drawing.Size(579, 278);
			this.dataGridViewDSHV.TabIndex = 8;
			// 
			// LopSHDT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(932, 596);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "LopSHDT";
			this.Text = "LopSHDT";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHV)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewDSHV;
    }
}