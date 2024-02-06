namespace txtedit
{
    partial class findReplace
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
            this.findBox = new System.Windows.Forms.TextBox();
            this.regexCheck = new System.Windows.Forms.CheckBox();
            this.replaceCheck = new System.Windows.Forms.CheckBox();
            this.replaceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findNextBtn = new System.Windows.Forms.Button();
            this.replaceNextBtn = new System.Windows.Forms.Button();
            this.replaceAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findBox
            // 
            this.findBox.Location = new System.Drawing.Point(12, 25);
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(260, 20);
            this.findBox.TabIndex = 0;
            // 
            // regexCheck
            // 
            this.regexCheck.AutoSize = true;
            this.regexCheck.Location = new System.Drawing.Point(12, 100);
            this.regexCheck.Name = "regexCheck";
            this.regexCheck.Size = new System.Drawing.Size(57, 17);
            this.regexCheck.TabIndex = 1;
            this.regexCheck.Text = "Regex";
            this.regexCheck.UseVisualStyleBackColor = true;
            // 
            // replaceCheck
            // 
            this.replaceCheck.AutoSize = true;
            this.replaceCheck.Location = new System.Drawing.Point(12, 51);
            this.replaceCheck.Name = "replaceCheck";
            this.replaceCheck.Size = new System.Drawing.Size(69, 17);
            this.replaceCheck.TabIndex = 2;
            this.replaceCheck.Text = "Replace:";
            this.replaceCheck.UseVisualStyleBackColor = true;
            // 
            // replaceBox
            // 
            this.replaceBox.Location = new System.Drawing.Point(12, 74);
            this.replaceBox.Name = "replaceBox";
            this.replaceBox.Size = new System.Drawing.Size(260, 20);
            this.replaceBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find:";
            // 
            // findNextBtn
            // 
            this.findNextBtn.Location = new System.Drawing.Point(12, 124);
            this.findNextBtn.Name = "findNextBtn";
            this.findNextBtn.Size = new System.Drawing.Size(75, 23);
            this.findNextBtn.TabIndex = 5;
            this.findNextBtn.Text = "Find Next";
            this.findNextBtn.UseVisualStyleBackColor = true;
            this.findNextBtn.Click += new System.EventHandler(this.findNextBtn_Click);
            // 
            // replaceNextBtn
            // 
            this.replaceNextBtn.Location = new System.Drawing.Point(93, 124);
            this.replaceNextBtn.Name = "replaceNextBtn";
            this.replaceNextBtn.Size = new System.Drawing.Size(87, 23);
            this.replaceNextBtn.TabIndex = 6;
            this.replaceNextBtn.Text = "Replace Next";
            this.replaceNextBtn.UseVisualStyleBackColor = true;
            this.replaceNextBtn.Click += new System.EventHandler(this.replaceNextBtn_Click);
            // 
            // replaceAllBtn
            // 
            this.replaceAllBtn.Location = new System.Drawing.Point(186, 124);
            this.replaceAllBtn.Name = "replaceAllBtn";
            this.replaceAllBtn.Size = new System.Drawing.Size(86, 23);
            this.replaceAllBtn.TabIndex = 7;
            this.replaceAllBtn.Text = "Replace All";
            this.replaceAllBtn.UseVisualStyleBackColor = true;
            this.replaceAllBtn.Click += new System.EventHandler(this.replaceAllBtn_Click);
            // 
            // findReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.replaceAllBtn);
            this.Controls.Add(this.replaceNextBtn);
            this.Controls.Add(this.findNextBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.replaceBox);
            this.Controls.Add(this.replaceCheck);
            this.Controls.Add(this.regexCheck);
            this.Controls.Add(this.findBox);
            this.Name = "findReplace";
            this.Text = "Find and Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox findBox;
        private System.Windows.Forms.CheckBox regexCheck;
        private System.Windows.Forms.TextBox replaceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findNextBtn;
        private System.Windows.Forms.Button replaceNextBtn;
        private System.Windows.Forms.Button replaceAllBtn;
        public System.Windows.Forms.CheckBox replaceCheck;
    }
}