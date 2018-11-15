namespace QuanLyDiem.GUI
{
    partial class FormViewGV
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
            this.panelTree = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelTree.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelButton);
            this.panel1.Controls.Add(this.panelData);
            this.panel1.Controls.Add(this.panelTree);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 707);
            this.panel1.TabIndex = 0;
            // 
            // panelTree
            // 
            this.panelTree.Controls.Add(this.treeView1);
            this.panelTree.Location = new System.Drawing.Point(3, 3);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(246, 701);
            this.panelTree.TabIndex = 0;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dataGridView1);
            this.panelData.Location = new System.Drawing.Point(255, 88);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(860, 508);
            this.panelData.TabIndex = 1;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonCancel);
            this.panelButton.Controls.Add(this.buttonOut);
            this.panelButton.Controls.Add(this.buttonInput);
            this.panelButton.Controls.Add(this.buttonSave);
            this.panelButton.Location = new System.Drawing.Point(255, 617);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(857, 73);
            this.panelButton.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 53);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(240, 645);
            this.treeView1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(857, 502);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(538, 25);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(155, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Lưu thay đổi";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(699, 25);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(155, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(12, 25);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(155, 23);
            this.buttonInput.TabIndex = 0;
            this.buttonInput.Text = "Nhập từ Excel";
            this.buttonInput.UseVisualStyleBackColor = true;
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(173, 25);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(155, 23);
            this.buttonOut.TabIndex = 0;
            this.buttonOut.Text = "Xuất ra Excel";
            this.buttonOut.UseVisualStyleBackColor = true;
            // 
            // FormViewGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 754);
            this.Controls.Add(this.panel1);
            this.Name = "FormViewGV";
            this.Text = "FormViewGV";
            this.panel1.ResumeLayout(false);
            this.panelTree.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelTree;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
    }
}