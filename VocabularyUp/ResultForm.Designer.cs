namespace VocabularyUp
{
    partial class ResultForm
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
            this.pnlResultForm = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbWrong = new System.Windows.Forms.Label();
            this.lbCorrect = new System.Windows.Forms.Label();
            this.lbWrongWord = new System.Windows.Forms.Label();
            this.lbCorrectWord = new System.Windows.Forms.Label();
            this.pnlResultForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlResultForm
            // 
            this.pnlResultForm.BackColor = System.Drawing.SystemColors.Control;
            this.pnlResultForm.BorderRadius = 20;
            this.pnlResultForm.Controls.Add(this.btnDetails);
            this.pnlResultForm.Controls.Add(this.btnOK);
            this.pnlResultForm.Controls.Add(this.lbWrong);
            this.pnlResultForm.Controls.Add(this.lbCorrect);
            this.pnlResultForm.Controls.Add(this.lbWrongWord);
            this.pnlResultForm.Controls.Add(this.lbCorrectWord);
            this.pnlResultForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResultForm.Location = new System.Drawing.Point(0, 0);
            this.pnlResultForm.Margin = new System.Windows.Forms.Padding(2);
            this.pnlResultForm.Name = "pnlResultForm";
            this.pnlResultForm.ShadowDecoration.Parent = this.pnlResultForm;
            this.pnlResultForm.Size = new System.Drawing.Size(750, 422);
            this.pnlResultForm.TabIndex = 13;
            // 
            // btnDetails
            // 
            this.btnDetails.AutoSize = true;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnDetails.Location = new System.Drawing.Point(311, 344);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(115, 52);
            this.btnDetails.TabIndex = 5;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(318, 275);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 52);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbWrong
            // 
            this.lbWrong.AutoSize = true;
            this.lbWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbWrong.Location = new System.Drawing.Point(544, 166);
            this.lbWrong.Name = "lbWrong";
            this.lbWrong.Size = new System.Drawing.Size(30, 31);
            this.lbWrong.TabIndex = 3;
            this.lbWrong.Text = "1";
            // 
            // lbCorrect
            // 
            this.lbCorrect.AutoSize = true;
            this.lbCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbCorrect.Location = new System.Drawing.Point(544, 84);
            this.lbCorrect.Name = "lbCorrect";
            this.lbCorrect.Size = new System.Drawing.Size(30, 31);
            this.lbCorrect.TabIndex = 2;
            this.lbCorrect.Text = "1";
            // 
            // lbWrongWord
            // 
            this.lbWrongWord.AutoSize = true;
            this.lbWrongWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbWrongWord.Location = new System.Drawing.Point(176, 166);
            this.lbWrongWord.Name = "lbWrongWord";
            this.lbWrongWord.Size = new System.Drawing.Size(250, 31);
            this.lbWrongWord.TabIndex = 1;
            this.lbWrongWord.Text = "Number of Wrong:";
            // 
            // lbCorrectWord
            // 
            this.lbCorrectWord.AutoSize = true;
            this.lbCorrectWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbCorrectWord.Location = new System.Drawing.Point(176, 84);
            this.lbCorrectWord.Name = "lbCorrectWord";
            this.lbCorrectWord.Size = new System.Drawing.Size(263, 31);
            this.lbCorrectWord.TabIndex = 0;
            this.lbCorrectWord.Text = "Number of Correct:";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(750, 422);
            this.Controls.Add(this.pnlResultForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.pnlResultForm.ResumeLayout(false);
            this.pnlResultForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlResultForm;
        private System.Windows.Forms.Label lbWrong;
        private System.Windows.Forms.Label lbCorrect;
        private System.Windows.Forms.Label lbWrongWord;
        private System.Windows.Forms.Label lbCorrectWord;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDetails;
    }
}