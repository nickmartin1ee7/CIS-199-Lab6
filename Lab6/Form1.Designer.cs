namespace Lab6
{
    partial class Form1
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
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.NumWordsTypedLabel = new System.Windows.Forms.Label();
            this.NumWordsTypedTextBox = new System.Windows.Forms.TextBox();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.GradeResultLabel = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitBtn.Location = new System.Drawing.Point(217, 97);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 1;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // NumWordsTypedLabel
            // 
            this.NumWordsTypedLabel.AutoSize = true;
            this.NumWordsTypedLabel.Location = new System.Drawing.Point(12, 15);
            this.NumWordsTypedLabel.Name = "NumWordsTypedLabel";
            this.NumWordsTypedLabel.Size = new System.Drawing.Size(126, 13);
            this.NumWordsTypedLabel.TabIndex = 4;
            this.NumWordsTypedLabel.Text = "Number of Words Typed:";
            // 
            // NumWordsTypedTextBox
            // 
            this.NumWordsTypedTextBox.Location = new System.Drawing.Point(144, 12);
            this.NumWordsTypedTextBox.Name = "NumWordsTypedTextBox";
            this.NumWordsTypedTextBox.Size = new System.Drawing.Size(148, 20);
            this.NumWordsTypedTextBox.TabIndex = 0;
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Location = new System.Drawing.Point(99, 35);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(39, 13);
            this.GradeLabel.TabIndex = 5;
            this.GradeLabel.Text = "Grade:";
            // 
            // GradeResultLabel
            // 
            this.GradeResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GradeResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeResultLabel.Location = new System.Drawing.Point(144, 35);
            this.GradeResultLabel.Name = "GradeResultLabel";
            this.GradeResultLabel.Size = new System.Drawing.Size(148, 42);
            this.GradeResultLabel.TabIndex = 3;
            this.GradeResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ClearBtn.Location = new System.Drawing.Point(12, 97);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.SubmitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ClearBtn;
            this.ClientSize = new System.Drawing.Size(304, 132);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.GradeResultLabel);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.NumWordsTypedTextBox);
            this.Controls.Add(this.NumWordsTypedLabel);
            this.Controls.Add(this.SubmitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lab 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label NumWordsTypedLabel;
        private System.Windows.Forms.TextBox NumWordsTypedTextBox;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.Label GradeResultLabel;
        private System.Windows.Forms.Button ClearBtn;
    }
}

