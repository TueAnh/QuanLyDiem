namespace QuanLyDiem.GUI.NVDT
{
    partial class LopHPDT
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
			this.textBoxGVPT = new System.Windows.Forms.TextBox();
			this.buttonAddEXCEL = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
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
			this.panel1.Controls.Add(this.textBoxGVPT);
			this.panel1.Controls.Add(this.buttonAddEXCEL);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBoxSearch);
			this.panel1.Controls.Add(this.buttonSave);
			this.panel1.Controls.Add(this.buttonCancel);
			this.panel1.Controls.Add(this.buttonSearch);
			this.panel1.Controls.Add(this.dataGridViewDSHV);
			this.panel1.Location = new System.Drawing.Point(43, 28);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(821, 498);
			this.panel1.TabIndex = 0;
			// 
			// textBoxGVPT
			// 
			this.textBoxGVPT.Location = new System.Drawing.Point(139, 38);
			this.textBoxGVPT.Name = "textBoxGVPT";
			this.textBoxGVPT.Size = new System.Drawing.Size(200, 20);
			this.textBoxGVPT.TabIndex = 26;
			// 
			// buttonAddEXCEL
			// 
			this.buttonAddEXCEL.Location = new System.Drawing.Point(121, 418);
			this.buttonAddEXCEL.Name = "buttonAddEXCEL";
			this.buttonAddEXCEL.Size = new System.Drawing.Size(75, 23);
			this.buttonAddEXCEL.TabIndex = 25;
			this.buttonAddEXCEL.Text = "Add ECXEL";
			this.buttonAddEXCEL.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 24;
			this.label1.Text = "GV phụ trách : ";
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(445, 67);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(168, 20);
			this.textBoxSearch.TabIndex = 23;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(518, 418);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 20;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(599, 418);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 21;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(625, 65);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(75, 23);
			this.buttonSearch.TabIndex = 22;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// dataGridViewDSHV
			// 
			this.dataGridViewDSHV.AllowUserToAddRows = false;
			this.dataGridViewDSHV.AllowUserToDeleteRows = false;
			this.dataGridViewDSHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDSHV.Location = new System.Drawing.Point(121, 93);
			this.dataGridViewDSHV.Name = "dataGridViewDSHV";
			this.dataGridViewDSHV.Size = new System.Drawing.Size(579, 278);
			this.dataGridViewDSHV.TabIndex = 19;
			this.dataGridViewDSHV.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDSHV_RowHeaderMouseDoubleClick);
			// 
			// LopHPDT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(961, 596);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "LopHPDT";
			this.RightToLeftLayout = true;
			this.Text = "LopHPDT";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSHV)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxGVPT;
        private System.Windows.Forms.Button buttonAddEXCEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewDSHV;
    }
}