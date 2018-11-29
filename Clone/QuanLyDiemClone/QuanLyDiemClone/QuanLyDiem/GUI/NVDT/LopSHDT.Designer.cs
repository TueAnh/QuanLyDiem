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
			this.dataGridViewDSHV = new System.Windows.Forms.DataGridView();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBoxSearch = new System.Windows.Forms.ComboBox();
			this.buttonChange = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonExcel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHV)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewDSHV
			// 
			this.dataGridViewDSHV.AllowUserToAddRows = false;
			this.dataGridViewDSHV.AllowUserToDeleteRows = false;
			this.dataGridViewDSHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDSHV.Location = new System.Drawing.Point(3, 64);
			this.dataGridViewDSHV.Name = "dataGridViewDSHV";
			this.dataGridViewDSHV.ReadOnly = true;
			this.dataGridViewDSHV.Size = new System.Drawing.Size(579, 271);
			this.dataGridViewDSHV.TabIndex = 8;
			this.dataGridViewDSHV.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDSHV_RowHeaderMouseDoubleClick);
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(507, 35);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 11;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(507, 341);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 10;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(426, 341);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 9;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(382, 37);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(119, 20);
			this.textBoxSearch.TabIndex = 12;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBoxSearch);
			this.panel1.Controls.Add(this.buttonChange);
			this.panel1.Controls.Add(this.buttonAdd);
			this.panel1.Controls.Add(this.buttonExcel);
			this.panel1.Controls.Add(this.textBoxSearch);
			this.panel1.Controls.Add(this.buttonSave);
			this.panel1.Controls.Add(this.buttonCancel);
			this.panel1.Controls.Add(this.buttonSearch);
			this.panel1.Controls.Add(this.dataGridViewDSHV);
			this.panel1.Location = new System.Drawing.Point(11, 11);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(589, 367);
			this.panel1.TabIndex = 0;
			// 
			// comboBoxSearch
			// 
			this.comboBoxSearch.FormattingEnabled = true;
			this.comboBoxSearch.Location = new System.Drawing.Point(282, 37);
			this.comboBoxSearch.Name = "comboBoxSearch";
			this.comboBoxSearch.Size = new System.Drawing.Size(94, 21);
			this.comboBoxSearch.TabIndex = 14;
			// 
			// buttonChange
			// 
			this.buttonChange.Location = new System.Drawing.Point(165, 341);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(75, 23);
			this.buttonChange.TabIndex = 13;
			this.buttonChange.Text = "Change";
			this.buttonChange.UseVisualStyleBackColor = true;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(84, 341);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 13;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			// 
			// buttonExcel
			// 
			this.buttonExcel.Location = new System.Drawing.Point(3, 341);
			this.buttonExcel.Name = "buttonExcel";
			this.buttonExcel.Size = new System.Drawing.Size(75, 23);
			this.buttonExcel.TabIndex = 13;
			this.buttonExcel.Text = "Excel";
			this.buttonExcel.UseVisualStyleBackColor = true;
			// 
			// LopSHDT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 381);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "LopSHDT";
			this.Text = "LopSHDT";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHV)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewDSHV;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonChange;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonExcel;
		private System.Windows.Forms.ComboBox comboBoxSearch;
	}
}