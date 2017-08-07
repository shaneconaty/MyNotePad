namespace myNotepad
{
    partial class frmReplace
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
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.findLbl = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.replaceLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(65, 83);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(83, 17);
            this.chkMatchCase.TabIndex = 11;
            this.chkMatchCase.Text = "Match Case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(65, 21);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(214, 20);
            this.FindTextBox.TabIndex = 10;
            // 
            // findLbl
            // 
            this.findLbl.AutoSize = true;
            this.findLbl.Location = new System.Drawing.Point(12, 24);
            this.findLbl.Name = "findLbl";
            this.findLbl.Size = new System.Drawing.Size(30, 13);
            this.findLbl.TabIndex = 9;
            this.findLbl.Text = "Find:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(308, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(308, 21);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(308, 50);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 14;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(308, 79);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.btnReplaceAll.TabIndex = 15;
            this.btnReplaceAll.Text = "Replace All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.BtnReplaceAll_Click);
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Location = new System.Drawing.Point(65, 47);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(214, 20);
            this.replaceTextBox.TabIndex = 17;
            // 
            // replaceLbl
            // 
            this.replaceLbl.AutoSize = true;
            this.replaceLbl.Location = new System.Drawing.Point(12, 50);
            this.replaceLbl.Name = "replaceLbl";
            this.replaceLbl.Size = new System.Drawing.Size(50, 13);
            this.replaceLbl.TabIndex = 16;
            this.replaceLbl.Text = "Replace:";
            // 
            // frmReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 147);
            this.Controls.Add(this.replaceTextBox);
            this.Controls.Add(this.replaceLbl);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.FindTextBox);
            this.Controls.Add(this.findLbl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.Name = "frmReplace";
            this.Text = "Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.CheckBox chkMatchCase;
        public System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label findLbl;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
        public System.Windows.Forms.TextBox replaceTextBox;
        private System.Windows.Forms.Label replaceLbl;
    }
}